using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.CommonTools.Converts;
using DOGAN.AmbarStokTakip.CommonTools.Document.Excel.SarfCikis;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
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
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmCikisSarf : Form // Check
    {
        private readonly IPersonelService _personelService;
        private readonly IUrunKayitService _urunKayitService;
        private readonly ICikisSarfService _cikisSarfService;
        public frmCikisSarf()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            _urunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            _cikisSarfService = InstanceFactory.GetInstance<ICikisSarfService>();
            dateSarfTarih.Value = DateTime.Now;
            DepoUrunListele();
        }
        #region List
        internal int DepoUrunListele()
        {
            DateTime tarih = DateTime.Parse(dateSarfTarih.Value.ToShortDateString());
            var result = _urunKayitService.GetUrunKayitDetalisForSarfNotDeleted(tarih);
            datagridDepoUrunList.DataSource = result.Data;
            datagridDepoUrunList.Columns["Id"].Visible = false;
            return result.Data.Count;

        }
        #endregion
        #region Method
        private void UpdateUrunKayit(long urunkayitId, decimal miktar)
        {
            _urunKayitService.UpdateForIaseOrSarf(urunkayitId, miktar);
        }

        private void AddCikisSarf(long urunKayitId, decimal miktar, long personelId, long birimId)
        {
            var cikisSarf = new CikisSarfDtoAdd
            {
                UrunKayitId = urunKayitId,
                Miktar = miktar,
                APersonelId = personelId,
                BirimId = birimId,
                CikisSarfTarihi = DateTime.Parse(dateSarfTarih.Value.ToShortDateString()),
            };
            _cikisSarfService.AddOnDto(cikisSarf);
        }
        internal int ComboBoxDoldur()
        {
            var result = _personelService.GetPersonelDetailsNotDeleted();
            cmbTeslimEdilenKisi.DataSource = result.Data;
            cmbTeslimEdilenKisi.DisplayMember = "PersonelAdPersonelSoyad";
            cmbTeslimEdilenKisi.ValueMember = "Id";
            GetBirim();
            return result.Data.Count;
        }
        private void GetBirim()
        {
            try
            {
                long Id = long.Parse(cmbTeslimEdilenKisi.SelectedValue.ToString());
                var result = _personelService.GetPersonelDetailsById(Id);
                txtBirim.Text = result.Data.BirimAdi.ToString();
            }
            catch
            {}
        }
        internal void ToplamTutarHesapla()
        {
            double result = (from DataGridViewRow row in datagridCikisSarf.Rows
                             where row.Cells["ToplamTutar"].Value.ToString() != ""
                             select Convert.ToDouble(row.Cells["ToplamTutar"].Value.ToString())).Sum();
            string formatResult = MoneyConvert.ConvertMoneyFormat(result);
            lblToplam.Text = formatResult;
        }
        #endregion
        #region Event
        private void datagridCikisSarf_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    int _selectedRow = datagridCikisSarf.SelectedCells[0].RowIndex;
                    string _urunAdi = datagridCikisSarf.Rows[_selectedRow].Cells["UrunAdi"].Value.ToString();
                    if (DialogResult.Yes == MessageBox.Show(_urunAdi + " Adlı ürünü listeden çıkartmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                    {
                        datagridCikisSarf.Rows.RemoveAt(_selectedRow);
                        ToplamTutarHesapla();
                    }
                }
            }
            catch
            {
            }
        }
        private void btnileri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void cmbTeslimEdilenKisi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBirim();
        }
        private void datagridDepoUrunList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool _cikisOnay = false;
                if (cmbTeslimEdilenKisi.SelectedValue != null)
                {
                    int _selectedRow = Convert.ToInt32(datagridDepoUrunList.SelectedCells[0].RowIndex);
                    string _urunAdi = datagridDepoUrunList.Rows[_selectedRow].Cells["UrunAdi"].Value.ToString();
                    DateTime _urunkayitTarih = DateTime.Parse(datagridDepoUrunList.Rows[_selectedRow].Cells["UrunKayitTarihi"].Value.ToString());
                    int _urunKayitId = Convert.ToInt32(datagridDepoUrunList.Rows[_selectedRow].Cells["Id"].Value.ToString());
                    var urunKayitTarihiKontrolIlkGelenIlkCikarPrensip = _urunKayitService.IlkUrunKayitCıkısKontrol(_urunkayitTarih, _urunAdi);
                    if (!urunKayitTarihiKontrolIlkGelenIlkCikarPrensip.IsSuccess && DialogResult.Yes ==
                        MessageBox.Show("Çıkış yapmak istediğiniz üründen daha önce kaydı yapılmış ürün bulunmaktadır.Yine de bu ürünün çıkışının yapılmasını istiyormusunuz?",
                        "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        _cikisOnay = true;
                    }
                    else if (urunKayitTarihiKontrolIlkGelenIlkCikarPrensip.IsSuccess)
                    {
                        _cikisOnay = true;
                    }
                    if (_cikisOnay == true)
                    {
                        SarfDusDto.UrunKayitId = _urunKayitId;
                        frmSarfDus frm = new frmSarfDus();
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen sarf malzeme çıkışı için gerekli alanları eksiksiz doldurunuz ve tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Parse(dateSarfTarih.Value.ToShortDateString());
            string ara = txtAra.Text;
            var result = _urunKayitService.SearchUrunKayitDetailsForSarfNotDeleted(ara, tarih);
            datagridDepoUrunList.DataSource = result.Data;
            datagridDepoUrunList.Columns["Id"].Visible = false;
        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    if (datagridCikisSarf.Rows.Count > 0 && dateSarfTarih.Value != null && cmbTeslimEdilenKisi.Text != String.Empty)
                    {
                        long personelId = long.Parse(cmbTeslimEdilenKisi.SelectedValue.ToString());
                        var personelEntity = _personelService.GetById(personelId).Data;
                        long birimId = personelEntity.BirimId;
                        foreach (DataGridViewRow row in datagridCikisSarf.Rows)
                        {
                            long urunkayitId = long.Parse(row.Cells["Id"].Value.ToString());
                            decimal miktar = Convert.ToDecimal(row.Cells["Miktar"].Value.ToString());
                            AddCikisSarf(urunkayitId, miktar, personelId, birimId);
                            UpdateUrunKayit(urunkayitId, miktar);
                        }
                        DokumanOlustur();
                        transactionScope.Complete();
                        MessageBox.Show("Sarf malzeme çıkışı başarıyla kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MdiFormsOn frm = (MdiFormsOn)Application.OpenForms["MdiFormsOn"];
                        frm.Reset();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen sarf malzeme çıkışı için istenilen bilgileri eksiksiz doldurup tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        private void DokumanOlustur()
        {
            try
            {
                if(checkTasinir.Checked)
                {
                    var filePath = new FileInfo(fileName: Application.StartupPath + @"\Documents\Sarf\SarfDefault.xlsx");
                    var sarfCikisListeDocuments = GetSarfCikisListeSetup();
                    SarfCikisListeDocumentCreate.SarfCikisListeDocument(sarfCikisListeDocuments, filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<DtoSarfCikisListeDocument> GetSarfCikisListeSetup()
        {
            datagridCikisSarf.CurrentCell = null;
            List<DtoSarfCikisListeDocument> document = new List<DtoSarfCikisListeDocument>();
            foreach (DataGridViewRow row in datagridCikisSarf.Rows)
            {
                DtoSarfCikisListeDocument sarfCikisListe = new DtoSarfCikisListeDocument
                {
                    UrunAdi = row.Cells["UrunAdi"].Value.ToString(),
                    Birim = row.Cells["Birim"].Value.ToString(),
                    BirimFiyat = Convert.ToDouble(row.Cells["BirimFiyat"].Value.ToString()),
                    CikisTarihi = DateTime.Parse(dateSarfTarih.Value.ToShortDateString()),
                    Miktar = Convert.ToDouble(row.Cells["Miktar"].Value.ToString()),
                    TeslimEdilenBirim = txtBirim.Text,
                    TeslimEdilenKisi = cmbTeslimEdilenKisi.Text,
                    ToplamTutar = Convert.ToDouble(row.Cells["ToplamTutar"].Value.ToString()),
                };
                document.Add(sarfCikisListe);
            }
            return document;
        }

        private void lblTasinir_Click(object sender, EventArgs e)
        {
            if (checkTasinir.Checked)
                checkTasinir.Checked = false;
            else
                checkTasinir.Checked = true;
        }
    }
}
