using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.CommonTools.Converts;
using DOGAN.AmbarStokTakip.CommonTools.Document.Excel.SarfCikis;
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
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmDokumanSarfKayit : Form
    {
        private readonly ICikisSarfService _cikisSarfService;
        private readonly IUrunKayitService _urunKayitService;
        WaitFormFunc waitForm = new WaitFormFunc();
        bool tumunuSecFlag = true;
        public frmDokumanSarfKayit()
        {
            _cikisSarfService = InstanceFactory.GetInstance<ICikisSarfService>();
            _urunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            InitializeComponent();
            dateSarfVerilisTarih.Value = DateTime.Now;
            DataGridViewReadOnly();
        }
        private void Listele()
        {
            DateTime tarih = DateTime.Parse(dateSarfVerilisTarih.Value.ToShortDateString());
            var result = _cikisSarfService.GetCikisSarfDetailByTarih(tarih);
            if(result.Data.Count<=0)
            {
                datagridSarficerik.Visible = false;
                lblSarficerik.Visible = false;
            }
            else
            {
                datagridSarficerik.Visible = true;
                lblSarficerik.Visible = true;
                DataGridDataSourceAndStyle(result);
            }
        }
        private void DataGridViewReadOnly()
        {
            foreach (DataGridViewColumn item in datagridSarficerik.Columns)
            {
                if (item.Name != "sec")
                {
                    item.ReadOnly = true;
                }
            }
        }
        private void dateSarfVerilisTarih_onValueChanged(object sender, EventArgs e)
        {
            Listele();
            DataGridViewReadOnly();
        }
        private void ToplamHesapla()
        {
            double toplam = (from DataGridViewRow row in datagridSarficerik.Rows
                             where (row.Cells["Miktar"].Value.ToString() != "")
                             select Convert.ToDouble(row.Cells["ToplamTutar"].Value)).Sum();

            string formatted = MoneyConvert.ConvertMoneyFormat(toplam);

            lblToplam.Text = "Toplam : " + formatted;
        }
        private void DataGridDataSourceAndStyle(IDataResult<List<CikisSarfDtoSelect>> list)
        {
            datagridSarficerik.DataSource = null;
            datagridSarficerik.DataSource = list.Data;
            datagridSarficerik.Columns["UrunKayitId"].Visible = false;
            datagridSarficerik.Columns["Id"].Visible = false;
            datagridSarficerik.AutoResizeColumns();
            ToplamHesapla();
        }
        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            if (txtAra.Text.Length > 0)
            {
                DateTime tarih = DateTime.Parse(dateSarfVerilisTarih.Value.ToShortDateString());
                string ara = txtAra.Text;
                var result = _cikisSarfService.GetCikisSarfDetailByTarih(tarih, ara);
                DataGridDataSourceAndStyle(result);
            }
            else
            {
                Listele();
            }
        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
        private bool DataGridViewCheckKontrol()
        {
            datagridSarficerik.CurrentCell = null;
            bool flag = false;
            foreach (DataGridViewRow row in datagridSarficerik.Rows)
            {
                if (Convert.ToBoolean(row.Cells["sec"].Value) == true)
                    flag = true;
            }
            return flag;
        }
        private void btnSarfMalzemeIptal_Click(object sender, EventArgs e)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    if (DataGridViewCheckKontrol() && DialogResult.Yes == MessageBox.Show("Seçili sarf malzeme çıkışlarını iptal etmek istediğnize eminmisiniz?",
                        "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        foreach (DataGridViewRow row in datagridSarficerik.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["sec"].Value) == true)
                            {
                                long urunKayitId = long.Parse(row.Cells["UrunKayitId"].Value.ToString());
                                long cikisSarfId = long.Parse(row.Cells["Id"].Value.ToString());
                                decimal miktar = Convert.ToDecimal(row.Cells["Miktar"].Value.ToString());
                                UrunKayitUpdate(urunKayitId, miktar);
                                CikisSarfUpdate(cikisSarfId);

                            }
                        }
                        transactionScope.Complete();
                        MessageBox.Show("Seçili sarf malzeme çıkışları başarı ile iptal edilerek depoya düşülen miktarlar eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MdiFormsOn frm = (MdiFormsOn)Application.OpenForms["MdiFormsOn"];
                        frm.Reset();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen İptal etmek istediğiniz ürünleri seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void UrunKayitUpdate(long urunKayitId, decimal miktar)
        {
            _urunKayitService.UpdateDeleteForIaseIptal(urunKayitId, miktar);
        }
        private bool CikisSarfUpdate(long cikisSarfId)
        {
            return _cikisSarfService.UpdateDeleteForUser(cikisSarfId).IsSuccess;
        }

        private void datagridSarficerik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void DokumanOlustur()
        {
            waitForm.Show(this);
            try
            {
                var filePath = new FileInfo(fileName: Application.StartupPath + @"\Documents\Sarf\SarfDefault.xlsx");
                var sarfCikisListeDocuments = GetSarfCikisListeSetup();
                SarfCikisListeDocumentCreate.SarfCikisListeDocument(sarfCikisListeDocuments, filePath);
            }
            catch (Exception ex)
            {
                waitForm.Close();
                MessageBox.Show(ex.Message);
            }
            waitForm.Close();
        }
        private List<DtoSarfCikisListeDocument> GetSarfCikisListeSetup()
        {
            datagridSarficerik.CurrentCell = null;
            List<DtoSarfCikisListeDocument> document = new List<DtoSarfCikisListeDocument>();
            foreach (DataGridViewRow row in datagridSarficerik.Rows)
            {
                if (Convert.ToBoolean(row.Cells["sec"].Value) == true)
                {
                    DtoSarfCikisListeDocument sarfCikisListe = new DtoSarfCikisListeDocument
                    {
                        UrunAdi = row.Cells["UrunAdi"].Value.ToString(),
                        Birim = row.Cells["Birim"].Value.ToString(),
                        BirimFiyat = Convert.ToDouble(row.Cells["BirimFiyat"].Value.ToString()),
                        CikisTarihi = DateTime.Parse(row.Cells["CikisTarihi"].Value.ToString()),
                        Miktar = Convert.ToDouble(row.Cells["Miktar"].Value.ToString()),
                        TeslimEdilenBirim = row.Cells["TeslimEdilenBirim"].Value.ToString(),
                        TeslimEdilenKisi = row.Cells["TeslimEdilenKisi"].Value.ToString(),
                        ToplamTutar = Convert.ToDouble(row.Cells["ToplamTutar"].Value.ToString()),
                    };
                    document.Add(sarfCikisListe);
                }
            }
            return document;
        }

        private void btnDokuman_Click(object sender, EventArgs e)
        {

            if (DataGridViewCheckKontrol())
            {
                DokumanOlustur();
            }
            else
            {
                MessageBox.Show("Döküman oluşturmak için en az bir ürün seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TumunuSecOptions(bool value)
        {
            datagridSarficerik.CurrentCell = null;
            foreach (DataGridViewRow row in datagridSarficerik.Rows)
            {
                row.Cells["sec"].Value = value;
            }
        }
        private void lblTumunuSec_Click(object sender, EventArgs e)
        {
            if (datagridSarficerik.Rows.Count > 0)
            {
                TumunuSecOptions(tumunuSecFlag);
                if (tumunuSecFlag == true)
                {
                    lblTumunuSec.Text = "Tümünü Kaldır";
                    tumunuSecFlag = false;
                }
                else
                {
                    lblTumunuSec.Text = "Tümünü Seç";
                    tumunuSecFlag = true;
                }

            }
        }
    }
}
