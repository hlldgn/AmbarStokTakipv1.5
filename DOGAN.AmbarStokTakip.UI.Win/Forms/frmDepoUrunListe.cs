using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.CommonTools.Converts;
using DOGAN.AmbarStokTakip.CommonTools.Document.Excel.depoUrunListe;
using DOGAN.AmbarStokTakip.CommonTools.List;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using DOGAN.AmbarStokTakip.UI.Win.WaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmDepoUrunListe : Form // Check
    {
        private readonly IDepoService _depoService;
        private readonly IUrunKayitService _urunKayitService;
        private readonly IAlimService  _alimService;
        private readonly IAlimUrunService  _alimUrunService;
        WaitFormFunc waitForm = new WaitFormFunc();
        public frmDepoUrunListe()
        {
            InitializeComponent();
            _depoService = InstanceFactory.GetInstance<IDepoService>();
            _urunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            _alimService = InstanceFactory.GetInstance<IAlimService>();
            _alimUrunService = InstanceFactory.GetInstance<IAlimUrunService>();
            ComboboxDoldur();
        }
        #region Method
        private void UpdateUrunKayit(long urunKayitId)
        {
            _urunKayitService.DeleteForUser(urunKayitId);
        }
        private void UpdateAlim(long alimId)
        {
            _alimService.UpdateDelete(alimId, false, false);
        }
        private void UpdateAlimUrun(long alimUrunId, decimal miktar)
        {
            _alimUrunService.UpdateDeleteForUser(alimUrunId, miktar);
        }
        private List<DtoDepoUrunListeDocument> GetDepoUrunListeSetup()
        {
            datagridDepoListe.CurrentCell = null;
            List<DtoDepoUrunListeDocument> document = new List<DtoDepoUrunListeDocument>();
            foreach (DataGridViewRow row in datagridDepoListe.Rows)
            {
                DtoDepoUrunListeDocument depoUrunListe = new DtoDepoUrunListeDocument
                {
                    UrunAdi = row.Cells["UrunAdi"].Value.ToString(),
                    Birim = row.Cells["Birim"].Value.ToString(),
                    BirimFiyat = Convert.ToDouble(row.Cells["BirimFiyat"].Value.ToString()),
                    AlinanMiktar = Convert.ToDouble(row.Cells["AlinanMiktar"].Value.ToString()),
                    KalanMiktar = Convert.ToDouble(row.Cells["KalanMiktar"].Value.ToString()),
                    UrunKayitTarihi = DateTime.Parse(row.Cells["UrunKayitTarihi"].Value.ToString()),
                    TedarikciFirma = row.Cells["TedarikciFirma"].Value.ToString(),
                    Fatura = row.Cells["Fatura"].Value.ToString(),
                    Odeme = row.Cells["Odeme"].Value.ToString(),
                    ToplamTutar =Convert.ToDouble(row.Cells["ToplamTutar"].Value.ToString()),
                };
                document.Add(depoUrunListe);
            }
            return document;
        }
        internal int ComboboxDoldur()
        {
            var result = _depoService.GetDepoDetailsNotDeleted();
            if (result.IsSuccess)
            {
                cmbDepo.DataSource = result.Data;
                cmbDepo.DisplayMember = "DepoAdi";
                cmbDepo.ValueMember = "Id";
            }
            cmbYuzde.DataSource = UrunGrubuCombobox.kalanMiktarAlarmSeviyesi;
            cmbYuzde.SelectedIndex = 0;
            return result.Data.Count;
        }
        private int YuzdeChanged()
        {
            int yuzde = Convert.ToInt32(cmbYuzde.SelectedItem.ToString());
            return yuzde;
        }
        private void DataGridViewStyleAndDataSource(IDataResult<List<UrunKayitDtoSelectForDepo>> result)
        {
            datagridDepoListe.DataSource = null;
            datagridDepoListe.DataSource = result.Data;
            datagridDepoListe.Columns["Id"].Visible = false;
            datagridDepoListe.Columns["AlimId"].Visible = false;
            datagridDepoListe.Columns["AlimUrunId"].Visible = false;
            datagridDepoListe.Columns["DepoId"].Visible = false;
            datagridDepoListe.Columns["ProgramDeleted"].Visible = false;
            datagridDepoListe.Columns["UserDeleted"].Visible = false;
            datagridDepoListe.Columns["IaseOrSarf"].Visible = false;
            datagridDepoListe.AutoResizeColumns();
            DataGridViewStyleFaturaAndOdeme(YuzdeChanged());
        }
        private void DataGridViewStyleFaturaAndOdeme(int yuzde)
        {
            foreach (DataGridViewRow item in datagridDepoListe.Rows)
            {
                if (item.Cells["Fatura"].Value.ToString() == "Fatura Kesilmiş")
                {
                    item.Cells["Fatura"].Style.SelectionForeColor = Color.Red;
                    item.Cells["Fatura"].Style.ForeColor = Color.IndianRed;
                }
                if (item.Cells["Odeme"].Value.ToString() == "Odeme Yapılmış")
                {
                    item.Cells["Odeme"].Style.SelectionForeColor = Color.Red;
                    item.Cells["Odeme"].Style.ForeColor = Color.IndianRed;
                }
                double alinanMiktar = Convert.ToDouble(item.Cells["AlinanMiktar"].Value.ToString());
                double kalanMiktar = Convert.ToDouble(item.Cells["KalanMiktar"].Value.ToString());
                if ((alinanMiktar * yuzde) / 100 >= kalanMiktar)
                {
                    item.Cells["KalanMiktar"].Style.SelectionForeColor = Color.Red;
                    item.Cells["KalanMiktar"].Style.ForeColor = Color.IndianRed;
                }
                else
                {
                    item.Cells["KalanMiktar"].Style.SelectionForeColor = Color.White;
                    item.Cells["KalanMiktar"].Style.ForeColor = Color.Black;
                }
            }
        }
        private void ToplamTutar()
        {
            double toplamTutar = (from DataGridViewRow row in datagridDepoListe.Rows
                                  select Convert.ToDouble(row.Cells["ToplamTutar"].Value.ToString())).Sum();
            string formatted= MoneyConvert.ConvertMoneyFormat(toplamTutar);
            lblToplamTutar.Text = "Toplam Tutar : " + formatted;
        }
        #endregion
        #region List
        private void Listele()
        {
            if (cmbDepo.Items.Count > 0)
            {
                int _id = Convert.ToInt32(cmbDepo.SelectedValue);
                var result = _urunKayitService.GetUrunKayitDetailsNotDeletedForDepoDepoId(_id);
                DataGridViewStyleAndDataSource(result);
                if (result.Data.Count > 0)
                {
                    lblDepoListesi.Visible = true;
                    datagridDepoListe.Visible = true;
                }
                else
                {
                    lblDepoListesi.Visible = false;
                    datagridDepoListe.Visible = false;
                }
                ToplamTutar();
            }
        }
        #endregion
        #region Event
        private void btniptal_Click(object sender, EventArgs e)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    int _selectedRow = datagridDepoListe.SelectedCells[0].RowIndex;
                    long urunKayitId = long.Parse(datagridDepoListe.Rows[_selectedRow].Cells["Id"].Value.ToString());
                    long alimId = long.Parse(datagridDepoListe.Rows[_selectedRow].Cells["AlimId"].Value.ToString());
                    long alimUrunId = long.Parse(datagridDepoListe.Rows[_selectedRow].Cells["AlimUrunId"].Value.ToString());
                    decimal miktar = Convert.ToDecimal(datagridDepoListe.Rows[_selectedRow].Cells["KalanMiktar"].Value.ToString());
                    string urunAdi = datagridDepoListe.Rows[_selectedRow].Cells["UrunAdi"].Value.ToString();
                    if (DialogResult.Yes == MessageBox.Show(urunAdi + " adlı ürünü iptal etmek istediğinize eminmisiniz? Bu işlem için birden fazla doğrulama kullanılacak.", "Onay"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                    {
                        DialogResult result = MessageBox.Show(urunAdi + " adlı ürünün kalan miktarı bağlı bulunduğu alıma eklenmesini istiyormusunuz?", "Onay"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (DialogResult.Yes == result)
                        {
                            if (DialogResult.Yes == MessageBox.Show(urunAdi + " adlı ürünün kalan miktarı bağlı olduğu alıma eklenecek. ONAYLIYORMUSUNZ?", "Onay",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                            {
                                UpdateUrunKayit(urunKayitId);
                                UpdateAlim(alimId);
                                UpdateAlimUrun(alimUrunId, miktar);
                                MessageBox.Show(urunAdi + " adlı ürün kalan miktarı bağlı olduğu alıma başarı ile eklenerek iptal edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (DialogResult.No == result)
                        {
                            if (DialogResult.Yes == MessageBox.Show(urunAdi + " adlı ürünün kalan miktarı bağlı olduğu alıma eklenmeden iptal edilecek. ONAYLIYORMUSUNUZ?", "Onay",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                            {
                                UpdateUrunKayit(urunKayitId);
                                MessageBox.Show(urunAdi + " adlı ürün kalan miktarı bağlı olduğu alıma eklenmeden başarı ile iptal edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        transactionScope.Complete();
                        Listele();
                    }
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void cmbYuzde_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewStyleFaturaAndOdeme(YuzdeChanged());
        }
        private void frmDepoUrunListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDokuman_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            try
            {
                var filePath = new FileInfo(fileName: Application.StartupPath + @"\Documents\DepoUrunListe\DepoUrunListe.xlsx");
                var depoUrunListeDocuments = GetDepoUrunListeSetup();
                string depoAdi = cmbDepo.Text.ToString() + " DEPOSU ÜRÜN LİSTESİ";
                DepoUrunListeDocumentCreate.DepoUrunListeDocumentInsert(depoUrunListeDocuments, "A5", depoAdi, filePath);
            }
            catch (Exception ex)
            {
                waitForm.Close();
                MessageBox.Show(ex.Message);
            }
            waitForm.Close();
        }
        private void cmbDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepo.ValueMember == "Id")
            {
                Listele();
            }
        }

        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            if (cmbDepo.Items.Count > 0 && cmbDepo.SelectedValue != null)
            {
                int _id = Convert.ToInt32(cmbDepo.SelectedValue);
                string _contains = txtAra.Text;
                var result = _urunKayitService.GetUrunKayitDetailsNotDeletedForDepoDepoId(_id, _contains);
                DataGridViewStyleAndDataSource(result);
            }
        }
        #endregion
        #region KeyPress
        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
        #endregion
    }
}
