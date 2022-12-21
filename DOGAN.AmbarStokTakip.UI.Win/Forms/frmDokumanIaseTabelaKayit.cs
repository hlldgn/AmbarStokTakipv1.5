using Bunifu.Framework.UI;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.CommonTools.Converts;
using DOGAN.AmbarStokTakip.CommonTools.Document.Excel.Iase;
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
    public partial class frmDokumanIaseTabelaKayit : Form // Check
    {
        private readonly ITabelaService _tabelaService;
        private readonly ICikisIaseService _cikisIaseService;
        private readonly ICikisIaseTabelaService _cikisIaseTabelaService;
        private readonly IUrunKayitService _urunKayitService;
        int maxRow = 50;
        WaitFormFunc waitForm = new WaitFormFunc();
        public frmDokumanIaseTabelaKayit()
        {
            InitializeComponent();
            _tabelaService = InstanceFactory.GetInstance<ITabelaService>();
            _cikisIaseService = InstanceFactory.GetInstance<ICikisIaseService>();
            _cikisIaseTabelaService = InstanceFactory.GetInstance<ICikisIaseTabelaService>();
            _urunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            maxRow = Properties.Settings.Default.SatirSayisi;
            lblMaxRow.Text = "En Fazla " + maxRow.ToString() + " Satır Gösteriliyor.";
            GetYemekTabelasi();
        }
        #region Method
        private List<DtoIaseTabelaAksamDocument> GetIaseTabelaAksamSetup()
        {
            List<DtoIaseTabelaAksamDocument> document = new List<DtoIaseTabelaAksamDocument>();
            foreach (DataGridViewRow _row in datagridiaseicerik.Rows)
            {
                if (_row.Cells[2].Value.ToString() == "Akşam")
                {
                    DtoIaseTabelaAksamDocument iaseTabelaAksam = new DtoIaseTabelaAksamDocument
                    {
                        UrunAdi = _row.Cells["UrunAdi"].Value.ToString(),
                        Birim = _row.Cells["Birim"].Value.ToString(),
                        Ogun = _row.Cells["Ogun"].Value.ToString(),
                        BirimFiyat = Convert.ToDouble(_row.Cells["BirimFiyat"].Value.ToString()),
                        DusulenMiktar = Convert.ToDouble(_row.Cells["Miktar"].Value.ToString()),
                        KBasiFiyat = Convert.ToDouble(_row.Cells["KisiBasiFiyat"].Value.ToString()),
                        KBasiKalori = Convert.ToDouble(_row.Cells["KisiBasiKalori"].Value.ToString()),
                    };
                    document.Add(iaseTabelaAksam);
                }
            }
            return document;
        }

        private List<DtoIaseTabelaOgleDocument> GetIaseTabelaOgleSetup()
        {
            List<DtoIaseTabelaOgleDocument> document = new List<DtoIaseTabelaOgleDocument>();
            foreach (DataGridViewRow _row in datagridiaseicerik.Rows)
            {
                if (_row.Cells[2].Value.ToString() == "Öğle")
                {
                    DtoIaseTabelaOgleDocument iaseTabelaOgle = new DtoIaseTabelaOgleDocument
                    {
                        UrunAdi = _row.Cells["UrunAdi"].Value.ToString(),
                        Birim = _row.Cells["Birim"].Value.ToString(),
                        Ogun = _row.Cells["Ogun"].Value.ToString(),
                        BirimFiyat = Convert.ToDouble(_row.Cells["BirimFiyat"].Value.ToString()),
                        DusulenMiktar = Convert.ToDouble(_row.Cells["Miktar"].Value.ToString()),
                        KBasiFiyat = Convert.ToDouble(_row.Cells["KisiBasiFiyat"].Value.ToString()),
                        KBasiKalori = Convert.ToDouble(_row.Cells["KisiBasiKalori"].Value.ToString()),
                    };
                    document.Add(iaseTabelaOgle);
                }
            }
            return document;
        }

        private List<DtoIaseTabelaSabahDocumet> GetIaseTabelaSabahSetup()
        {
            List<DtoIaseTabelaSabahDocumet> document = new List<DtoIaseTabelaSabahDocumet>();
            foreach (DataGridViewRow _row in datagridiaseicerik.Rows)
            {
                if (_row.Cells[2].Value.ToString() == "Sabah")
                {
                    DtoIaseTabelaSabahDocumet iaseTabelaSabah = new DtoIaseTabelaSabahDocumet
                    {
                        UrunAdi = _row.Cells["UrunAdi"].Value.ToString(),
                        Birim = _row.Cells["Birim"].Value.ToString(),
                        Ogun = _row.Cells["Ogun"].Value.ToString(),
                        BirimFiyat = Convert.ToDouble(_row.Cells["BirimFiyat"].Value.ToString()),
                        DusulenMiktar = Convert.ToDouble(_row.Cells["Miktar"].Value.ToString()),
                        KBasiFiyat = Convert.ToDouble(_row.Cells["KisiBasiFiyat"].Value.ToString()),
                        KBasiKalori = Convert.ToDouble(_row.Cells["KisiBasiKalori"].Value.ToString()),
                    };
                    document.Add(iaseTabelaSabah);
                }
            }
            return document;
        }

        private List<DtoIaseTabelaDocument> GetIaseTabelaSetup(int iasePlanRowIndex,int yemekTabelasiRowIndex)
        {
            List<DtoIaseTabelaDocument> document = new List<DtoIaseTabelaDocument>();
            DtoIaseTabelaDocument iaseTabela = new DtoIaseTabelaDocument
            {
                AcikHT = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["AcikHT"].Value.ToString()),
                AclikGrevi = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["AclikGrevi"].Value.ToString()),
                AksamPer = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["AksamPer"].Value.ToString()),
                Bebek = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["Bebek"].Value.ToString()),
                Cocuk = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["Cocuk"].Value.ToString()),
                Diyet = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["Diyet"].Value.ToString()),
                HamileBayan = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["HamileBayan"].Value.ToString()),
                KapaliHT = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["KapaliHT"].Value.ToString()),
                OglePer = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["OglePer"].Value.ToString()),
                SabahPer = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["SabahPer"].Value.ToString()),
                TAksam = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["TAksam"].Value.ToString()),
                TOgle = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["TOgle"].Value.ToString()),
                TSabah = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["TSabah"].Value.ToString()),
                iaseAd = datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["iaseAd"].Value.ToString(),
                YemekAksam = datagridYemekTabelasi.Rows[yemekTabelasiRowIndex].Cells["Aksam"].Value.ToString(),
                YemekOgle = datagridYemekTabelasi.Rows[yemekTabelasiRowIndex].Cells["Ogle"].Value.ToString(),
                YemekSabah = datagridYemekTabelasi.Rows[yemekTabelasiRowIndex].Cells["Sabah"].Value.ToString(),
                IaseTarihi = DateTime.Parse(datagridYemekTabelasi.Rows[yemekTabelasiRowIndex].Cells["TabelaTarihi"].Value.ToString()),
                DateYil = DateTime.Parse(datagridYemekTabelasi.Rows[yemekTabelasiRowIndex].Cells["TabelaTarihi"].Value.ToString()).DayOfYear.ToString(),
            };
            document.Add(iaseTabela);
            return document;

        }
        private void ControlVisible(bool deger)
        {
            btnDokuman.Visible = deger;
            btniaseiptal.Visible = deger;
            lbliaseTutar.Visible = deger;
            lblKaloriToplam.Visible = deger;
            lbliaseiceregi.Visible = deger;
            lbliasePlanKisiSayilari.Visible = deger;
            datagridiaseicerik.Visible = deger;
            datagridIaseIptalPlan.Visible = deger;
        }
        private void GetIaseIcerikSayi(DateTime yemekTabelaTarih)
        {
            var iaseTabelaSayi = _cikisIaseService.GetCikisIaseDetailsNotDeleted(yemekTabelaTarih).Data;
            if (iaseTabelaSayi.Count > 0)
            {
                ControlVisible(true);
                datagridIaseIptalPlan.DataSource = null;
                datagridIaseIptalPlan.DataSource = iaseTabelaSayi;
                datagridIaseIptalPlan.Columns["Id"].Visible = false;
                datagridIaseIptalPlan.AutoResizeColumns();
            }
            else
            {
                datagridiaseicerik.DataSource = null;
                datagridIaseIptalPlan.DataSource = null;
                ControlVisible(false);
            }
        }
        private void ToplamIaseHesapla()
        {
            double iase = (from DataGridViewRow row in datagridiaseicerik.Rows
                           where (row.Cells["Miktar"].Value.ToString() != "")
                           select Convert.ToDouble(row.Cells["KisiBasiFiyat"].Value)).Sum();
            string formatted = MoneyConvert.ConvertMoneyFormat(iase);
            string kalori = (from DataGridViewRow row in datagridiaseicerik.Rows
                             select Convert.ToDouble(row.Cells["KisiBasiKalori"].Value)).Sum().ToString();

            lbliaseTutar.Text = "İaşe Toplam Tutar : " + formatted;
            lblKaloriToplam.Text = "Kalori Toplam : " + kalori.ToString();
        }
        #endregion
        #region InsertAndUpdate
        private bool CikisIaseUpdate(long id)
        {
            return _cikisIaseService.UpdateDeleteForUser(id).IsSuccess;
        }
        private void CikisIaseTabelaUpdate(int id)
        {
            _cikisIaseTabelaService.UpdateDeleteForUser(id);
        }
        private void UrunKayitUpdate(int id, decimal miktar)
        {
            _urunKayitService.UpdateDeleteForIaseIptal(id, miktar);
        }
        #endregion
        #region Event
        private void datagridYemekTabelasi_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridYemekTabelasi.Rows.Count > 0)
            {
                DateTime _tarih = DateTime.Parse(datagridYemekTabelasi.CurrentRow.Cells["TabelaTarihi"].Value.ToString());
                GetIaseIcerikSayi(_tarih);
                ToplamIaseHesapla();
            }
        }
        private void btniaseiptal_Click(object sender, EventArgs e)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    int _selectedRowYemekTabelasi = datagridYemekTabelasi.SelectedCells[0].RowIndex;
                    int _selectedRowiasePlan = datagridIaseIptalPlan.SelectedCells[0].RowIndex;
                    DateTime _tarih = DateTime.Parse(datagridYemekTabelasi.Rows[_selectedRowYemekTabelasi].Cells["TabelaTarihi"].Value.ToString());
                    if (DialogResult.Yes == MessageBox.Show(_tarih.ToShortDateString() + " Tarihli İaşe Kaydını iptal etmek istediğinize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        var iaseTabelaSayi = _cikisIaseService.GetCikisIaseDetailsNotDeleted(_tarih).Data;
                        if (iaseTabelaSayi.Count() > 0)
                        {
                            long CikisIaseId = long.Parse(datagridIaseIptalPlan.Rows[_selectedRowiasePlan].Cells["Id"].Value.ToString());
                            if (CikisIaseUpdate(CikisIaseId))
                            {
                                for (int i = 0; i < datagridiaseicerik.Rows.Count; i++)
                                {
                                    int urunKayitId = Convert.ToInt32(datagridiaseicerik.Rows[i].Cells["UrunKayitId"].Value.ToString());
                                    int cikisIaseTabelaId = Convert.ToInt32(datagridiaseicerik.Rows[i].Cells["Id"].Value.ToString());
                                    decimal miktar = Convert.ToDecimal(datagridiaseicerik.Rows[i].Cells["Miktar"].Value.ToString());
                                    UrunKayitUpdate(urunKayitId, miktar);
                                    CikisIaseTabelaUpdate(cikisIaseTabelaId);
                                }
                                MessageBox.Show(_tarih.ToShortDateString() + " Tarihli İaşe kaydı İptal edilerek düşülen miktarlar tekrar depoya aktarılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetYemekTabelasi();
                            }
                        }
                    }
                    transactionScope.Complete();
                }
                catch
                {
                    MessageBox.Show("İaşe iptale edilirken bir sorunla karşılaşıldı. lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transactionScope.Dispose();
                }
            }
        }

        private void btnDokuman_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);            
            try
            {                
                int _selectedRowYemekTabelasi = datagridYemekTabelasi.SelectedCells[0].RowIndex;
                int _selectedRowIasePlan = datagridIaseIptalPlan.SelectedCells[0].RowIndex;
                var filePath = new FileInfo(fileName: Application.StartupPath + @"\Documents\iase\iase.xlsx");
                var IaseTabelaDocument = GetIaseTabelaSetup(_selectedRowIasePlan, _selectedRowYemekTabelasi);
                var IaseTabelaSabahDocument = GetIaseTabelaSabahSetup();
                var IaseTabelaOgleDocument = GetIaseTabelaOgleSetup();
                var IaseTabelaAksamDocument = GetIaseTabelaAksamSetup();
                IaseTabelaDocumentCreate.IaseTabelaDocumentInsert(IaseTabelaDocument, "A1", IaseTabelaSabahDocument, "A4", IaseTabelaOgleDocument, "I4", IaseTabelaAksamDocument, "Q4", filePath);
            }
            catch (Exception ex)
            {
                waitForm.Close();
                MessageBox.Show(ex.Message);
            }
            waitForm.Close();
        }

        private void datagridIaseIptalPlan_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridIaseIptalPlan.Rows.Count > 0)
            {
                int id = Convert.ToInt32(datagridIaseIptalPlan.CurrentRow.Cells["Id"].Value.ToString());
                datagridiaseicerik.DataSource = _cikisIaseTabelaService.GetCikisIaseTabelaDetails(id).Data;
                datagridiaseicerik.Columns["Id"].Visible = false;
                datagridiaseicerik.Columns["UrunKayitId"].Visible = false;
                datagridiaseicerik.AutoResizeColumns();
                ToplamIaseHesapla();
            }
            else
            {
                datagridiaseicerik.DataSource = null;
            }
        }

        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAra.Text.Length > 0)
                {
                    DateTime _tarih = DateTime.Parse(txtAra.Text);
                    datagridYemekTabelasi.DataSource = _tabelaService.GetTabelaDetailsTarihNotDeleted(_tarih).Data;
                    datagridYemekTabelasi.Columns["Id"].Visible = false;
                    datagridYemekTabelasi.AutoResizeColumns();
                }
                else
                {
                    GetYemekTabelasi();
                }
            }
            catch
            {

            }
        }
        #endregion
        #region List
        internal int GetYemekTabelasi()
        {
            var result = _tabelaService.SelectTabelaDetailsNotDeleted();
            datagridYemekTabelasi.DataSource = null;
            datagridYemekTabelasi.DataSource = result.Data.Take(maxRow).ToList();
            datagridYemekTabelasi.Columns["Id"].Visible = false;
            datagridYemekTabelasi.AutoResizeColumns();
            return result.Data.Count;
        }
        #endregion
    }
}
