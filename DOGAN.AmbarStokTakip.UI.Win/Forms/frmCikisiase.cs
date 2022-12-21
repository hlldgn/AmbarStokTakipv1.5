using Bunifu.Framework.UI;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.CommonTools.Converts;
using DOGAN.AmbarStokTakip.CommonTools.List;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmCikisiase : Form // Check
    {
        private readonly ITabelaService _tabelaService;
        private readonly IUrunKayitService _urunKayitService;
        private readonly IOtomatikCikisService _otomatikCikisService;
        private readonly ICikisIaseService _cikisIaseService;
        private readonly ICikisIaseTabelaService _cikisIaseTabelaService;
        private DateTime iaseTarih;
        int iasePlanRowIndex;
        public frmCikisiase()
        {
            InitializeComponent();
            _tabelaService = InstanceFactory.GetInstance<ITabelaService>();
            _urunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            _otomatikCikisService = InstanceFactory.GetInstance<IOtomatikCikisService>();
            _cikisIaseService = InstanceFactory.GetInstance<ICikisIaseService>();
            _cikisIaseTabelaService = InstanceFactory.GetInstance<ICikisIaseTabelaService>();
            dateiaseTarih.Value = DateTime.Now;
            OgunComboboxDoldur();
            datagridCikisiase.Columns["Id"].Visible = false;

        }
        #region InsertAndUpdate
        private void UrunKayit(long cikisIaseId)
        {
            for (int i = 0; i < datagridCikisiase.Rows.Count; i++)
            {
                decimal miktar = Convert.ToDecimal(datagridCikisiase.Rows[i].Cells["miktar"].Value.ToString());
                decimal kisiBasiFiyat = Convert.ToDecimal(datagridCikisiase.Rows[i].Cells["kbasifiyat"].Value.ToString());
                decimal kisiBasiKalori = Convert.ToDecimal(datagridCikisiase.Rows[i].Cells["kbasikalori"].Value.ToString());
                string ogun = datagridCikisiase.Rows[i].Cells["ogun"].Value.ToString();
                int urunKayitId = Convert.ToInt32(datagridCikisiase.Rows[i].Cells["Id"].Value.ToString());
                CikisIaseTabelaAdd(cikisIaseId, miktar, urunKayitId, ogun, kisiBasiKalori, kisiBasiFiyat);
                UrunkayitUpdate(urunKayitId, miktar);
            }
        }
        private long CikisIaseAdd()
        {
            var cikisIase = new CikisIaseDtoAdd
            {
                AcikHT = Convert.ToInt32(txtAcikHT.Text),
                KapaliHT = Convert.ToInt32(txtKapaliHT.Text),
                SabahPer = Convert.ToInt32(txtSabahPer.Text),
                OglePer = Convert.ToInt32(txtOglePer.Text),
                AksamPer = Convert.ToInt32(txtAksamPer.Text),
                Cocuk = Convert.ToInt32(txtCocuk.Text),
                Bebek = Convert.ToInt32(txtBebek.Text),
                AclikGrevi = Convert.ToInt32(txtAclikGrevi.Text),
                Diyet = Convert.ToInt32(txtDiyet.Text),
                HamileBayan = Convert.ToInt32(txtHamileBayan.Text),
                TSabah = Convert.ToInt32(txtTSabah.Text),
                TOgle = Convert.ToInt32(txtTOgle.Text),
                TAksam = Convert.ToInt32(txtTAksam.Text),
                iaseAd = txtiaseAd.Text,
                CikisIaseTarihi = iaseTarih,
                TabelaId = Convert.ToInt32(datagridYemekTabela.Rows[0].Cells["Id"].Value.ToString()),
            };
            return _cikisIaseService.AddonDto(cikisIase).Id;
        }
        private bool CikisIaseUpdate()
        {
            var cikisIase = new CikisIaseDtoSelect
            {
                AcikHT = Convert.ToInt32(txtAcikHT.Text),
                KapaliHT = Convert.ToInt32(txtKapaliHT.Text),
                SabahPer = Convert.ToInt32(txtSabahPer.Text),
                OglePer = Convert.ToInt32(txtOglePer.Text),
                AksamPer = Convert.ToInt32(txtAksamPer.Text),
                Cocuk = Convert.ToInt32(txtCocuk.Text),
                Bebek = Convert.ToInt32(txtBebek.Text),
                AclikGrevi = Convert.ToInt32(txtAclikGrevi.Text),
                Diyet = Convert.ToInt32(txtDiyet.Text),
                HamileBayan = Convert.ToInt32(txtHamileBayan.Text),
                TSabah = Convert.ToInt32(txtTSabah.Text),
                TOgle = Convert.ToInt32(txtTOgle.Text),
                TAksam = Convert.ToInt32(txtTAksam.Text),
                iaseAd = txtiaseAd.Text,
                CikisIaseTarihi = iaseTarih,
                Id = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["Id"].Value.ToString()),
            };
            return _cikisIaseService.UpdateDeleteForIaseIptal(cikisIase).IsSuccess;

        }
        private bool CikisIaseTabelaDelete(int cikisIaseId)
        {
            return _cikisIaseTabelaService.Delete(cikisIaseId).IsSuccess;
        }
        private bool CikisIaseTabelaAdd(long cikisIaseId, decimal miktar, int urunKayitId, string ogun, decimal kisiBasiKalori, decimal kisiBasiFiyat)
        {
            var cikisIaseTabela = new CikisIaseTabelaDtoAdd
            {
                CikisIaseId = cikisIaseId,
                Miktar = miktar,
                UrunKayitId = urunKayitId,
                KisiBasiFiyat = kisiBasiFiyat,
                KisiBasiKalori = kisiBasiKalori,
                Ogun = ogun,
            };
            return _cikisIaseTabelaService.AddonDto(cikisIaseTabela).IsSuccess;

        }
        private bool UrunkayitUpdate(int urunKayitId, decimal dusulenMiktar)
        {
            return _urunKayitService.UpdateForIaseOrSarf(urunKayitId, dusulenMiktar).IsSuccess;
        }
        #endregion
        #region KeyPress
        private void datagridCikisiase_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    int _selectedRow = datagridCikisiase.SelectedCells[0].RowIndex;
                    string _urunAdi = datagridCikisiase.Rows[_selectedRow].Cells["urunadi"].Value.ToString();
                    if (DialogResult.Yes == MessageBox.Show(_urunAdi + " Adlı ürünü listeden çıkartmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                    {
                        datagridCikisiase.Rows.RemoveAt(_selectedRow);
                        ToplamIaseHesapla(datagridCikisiase, "kbasifiyat", "kbasikalori");
                    }
                }
            }
            catch
            {
            }
        }
        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
        private void Key_Press_Sayilar_Text(object sender, KeyPressEventArgs e)
        {
            foreach (Control textBox in cardsSayilar.Controls)
            {
                if (textBox.Name != "txtiaseAd" && textBox is BunifuMetroTextbox)
                {
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar);
                }
            }
        }
        private void txtKapaliHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press_Sayilar_Text(sender, e);
        }

        private void txtAcikHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press_Sayilar_Text(sender, e);
        }

        private void txtSabahPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press_Sayilar_Text(sender, e);
        }

        private void txtOglePer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press_Sayilar_Text(sender, e);
        }

        private void txtAksamPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press_Sayilar_Text(sender, e);
        }

        private void txtCocuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press_Sayilar_Text(sender, e);
        }

        private void txtBebek_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press_Sayilar_Text(sender, e);
        }

        private void txtAclikGrevi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press_Sayilar_Text(sender, e);
        }

        private void txtDiyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press_Sayilar_Text(sender, e);
        }

        private void txtHamileBayan_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press_Sayilar_Text(sender, e);
        }
        #endregion
        #region Event
        private void datagridDepoUrunList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool _cikisOnay = false;
                if (datagridYemekTabela.Rows.Count > 0 && txtiaseAd.Text != "")
                {
                    int _selectedRow = Convert.ToInt32(datagridDepoUrunList.SelectedCells[0].RowIndex);
                    string _urunAdi = datagridDepoUrunList.Rows[_selectedRow].Cells["UrunAdi"].Value.ToString();
                    DateTime _urunkayitTarih = DateTime.Parse(datagridDepoUrunList.Rows[_selectedRow].Cells["UrunKayitTarihi"].Value.ToString());
                    int _urunKayitId = Convert.ToInt32(datagridDepoUrunList.Rows[_selectedRow].Cells["Id"].Value.ToString());
                    if (datagridCikisiase.Rows.Count <= 0)
                    {
                        OtomatikCikis(KisiSayisiToplamSabah(), KisiSayisiToplamOgle(), KisiSayisiToplamAksam());
                    }
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
                        IaseDusDto.Ogun = cmbOgun.Text;
                        IaseDusDto.UrunKayitId = _urunKayitId;
                        IaseDusDto.ToplamSabah = KisiSayisiToplamSabah();
                        IaseDusDto.ToplamOgle = KisiSayisiToplamOgle();
                        IaseDusDto.ToplamAksam = KisiSayisiToplamAksam();
                        frmiaseDus frm = new frmiaseDus();
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen iaşe çıkışı için gerekli alanları eksiksiz doldurunuz ve tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dateiaseTarih_onValueChanged(object sender, EventArgs e)
        {
            iaseTarih = DateTime.Parse(dateiaseTarih.Value.ToShortDateString());
            YemekTabelaListele();
        }

        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            var result = _urunKayitService.SearchByUrunKayitDetailsForIaseNotDeleted(ara, iaseTarih);
            if (result.IsSuccess)
            {
                datagridDepoUrunList.DataSource = null;
                datagridDepoUrunList.DataSource = result.Data;
                datagridDepoUrunList.Columns["Id"].Visible = false;

            }
        }
        private void datagridIaseIptalPlan_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridIaseIptalPlan.Rows.Count > 0)
            {
                txtAcikHT.Text = datagridIaseIptalPlan.CurrentRow.Cells["AcikHT"].Value.ToString();
                txtAclikGrevi.Text = datagridIaseIptalPlan.CurrentRow.Cells["AclikGrevi"].Value.ToString();
                txtAksamPer.Text = datagridIaseIptalPlan.CurrentRow.Cells["AksamPer"].Value.ToString();
                txtBebek.Text = datagridIaseIptalPlan.CurrentRow.Cells["Bebek"].Value.ToString();
                txtCocuk.Text = datagridIaseIptalPlan.CurrentRow.Cells["Cocuk"].Value.ToString();
                txtDiyet.Text = datagridIaseIptalPlan.CurrentRow.Cells["Diyet"].Value.ToString();
                txtHamileBayan.Text = datagridIaseIptalPlan.CurrentRow.Cells["HamileBayan"].Value.ToString();
                txtiaseAd.Text = datagridIaseIptalPlan.CurrentRow.Cells["iaseAd"].Value.ToString();
                txtKapaliHT.Text = datagridIaseIptalPlan.CurrentRow.Cells["KapaliHT"].Value.ToString();
                txtOglePer.Text = datagridIaseIptalPlan.CurrentRow.Cells["OglePer"].Value.ToString();
                txtSabahPer.Text = datagridIaseIptalPlan.CurrentRow.Cells["SabahPer"].Value.ToString();
                txtTAksam.Text = datagridIaseIptalPlan.CurrentRow.Cells["TAksam"].Value.ToString();
                txtTOgle.Text = datagridIaseIptalPlan.CurrentRow.Cells["TOgle"].Value.ToString();
                txtTSabah.Text = datagridIaseIptalPlan.CurrentRow.Cells["TSabah"].Value.ToString();
                int id = Convert.ToInt32(datagridIaseIptalPlan.CurrentRow.Cells["Id"].Value.ToString());
                datagridiaseicerik.DataSource = _cikisIaseTabelaService.GetCikisIaseTabelaDetails(id).Data;
                datagridiaseicerik.Columns["Id"].Visible = false;
                datagridiaseicerik.Columns["UrunKayitId"].Visible = false;
                datagridiaseicerik.AutoResizeColumns();
                ToplamIaseHesapla(datagridiaseicerik, "KisiBasiFiyat", "KisiBasiKalori");
            }
            else
            {
                datagridiaseicerik.DataSource = null;
            }
        }

        private void lblIaseIptal_Click(object sender, EventArgs e)
        {
            if (checkediaseiptal.Checked == true)
                checkediaseiptal.Checked = false;
            else
                checkediaseiptal.Checked = true;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    if (checkediaseiptal.Checked == false)
                    {
                        long cikisIaseId = CikisIaseAdd();
                        UrunKayit(cikisIaseId);
                    }
                    else
                    {
                        if (CikisIaseUpdate())
                        {
                            int cikisIaseId = Convert.ToInt32(datagridIaseIptalPlan.Rows[iasePlanRowIndex].Cells["Id"].Value.ToString());
                            if (CikisIaseTabelaDelete(cikisIaseId))
                                UrunKayit(cikisIaseId);
                        }
                    }
                    MessageBox.Show("İaşe tabelası başarıyla kaydedilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    transactionScope.Complete();
                    MdiFormsOn frm = (MdiFormsOn)Application.OpenForms["MdiFormsOn"];
                    frm.Reset();
                    this.Close();
                }
                catch
                {
                    transactionScope.Dispose();
                    MessageBox.Show("İaşe Tabelası kaydedilirken bir sorunla karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnileri_Click(object sender, EventArgs e)
        {
            if (datagridYemekTabela0.Rows.Count > 0)
            {
                KisiSayisiTxtDoldur();
                int kisiSayisiToplamSabah = KisiSayisiToplamSabah();
                int kisiSayisiToplamOgle = KisiSayisiToplamOgle();
                int kisiSayisiToplamAksam=KisiSayisiToplamAksam();
                txtTSabah.Text = kisiSayisiToplamSabah.ToString();
                txtTOgle.Text = kisiSayisiToplamOgle.ToString();
                txtTAksam.Text = kisiSayisiToplamAksam.ToString();
                int kisiSayisiToplam = kisiSayisiToplamSabah + kisiSayisiToplamAksam + kisiSayisiToplamOgle;
                lblKisiSayilari.Text = "Toplam Sabah " + txtTSabah.Text + " Toplam Öğle " + txtTOgle.Text + " Toplam Akşam " + txtTAksam.Text;
                if (txtiaseAd.Text != String.Empty && txtTSabah.Text != String.Empty && txtTOgle.Text != String.Empty
                    && txtTAksam.Text != String.Empty && kisiSayisiToplam > 0)
                {
                    if (DepoUrunListele() > 0)
                    {
                        IptalIaseAktar(kisiSayisiToplamSabah, kisiSayisiToplamOgle, kisiSayisiToplamAksam);
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show(iaseTarih.ToShortDateString() + " Tarihinden önce kaydedilmiş deponuzda en az bir bulunması gerekir. Lütfen Ürün kaydettikten sonra devam ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MdiFormsOn frm = (MdiFormsOn)Application.OpenForms["MdiFormsOn"];
                        frm.Reset();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Kişi sayılarını ve iaşe adını eksiksiz doldurup tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(iaseTarih.ToShortDateString() + " Tarihli bir yemek programı bulunamadı. Lütfen bir yemek programı ekleniyinz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtAra_MouseClick(object sender, MouseEventArgs e)
        {
            txtAra.Text = String.Empty;
        }
        #endregion
        #region Method
        private void IptalIaseAktar(int toplamSabah, int toplamOgle, int toplamAksam)
        {
            if (checkediaseiptal.Checked == true && datagridiaseicerik.Rows.Count > 0)
            {
                double kisiBasiIase = 0;
                double kisiBasiKalori = 0;
                for (int i = 0; i < datagridiaseicerik.Rows.Count; i++)
                {
                    datagridCikisiase.Rows.Add();
                    double miktar = Convert.ToDouble(datagridiaseicerik.Rows[i].Cells["Miktar"].Value.ToString());
                    double birimFiyat = Convert.ToDouble(datagridiaseicerik.Rows[i].Cells["BirimFiyat"].Value.ToString());
                    double kalori = Convert.ToDouble(datagridiaseicerik.Rows[i].Cells["Kalori"].Value.ToString());
                    double toplamTutar = miktar * birimFiyat;
                    datagridCikisiase.Rows[i].Cells["Id"].Value = datagridiaseicerik.Rows[i].Cells["UrunKayitId"].Value.ToString();
                    datagridCikisiase.Rows[i].Cells["ogun"].Value = datagridiaseicerik.Rows[i].Cells["Ogun"].Value.ToString();
                    datagridCikisiase.Rows[i].Cells["urunadi"].Value = datagridiaseicerik.Rows[i].Cells["UrunAdi"].Value.ToString();
                    datagridCikisiase.Rows[i].Cells["birim"].Value = datagridiaseicerik.Rows[i].Cells["Birim"].Value.ToString();
                    datagridCikisiase.Rows[i].Cells["kalori"].Value = kalori.ToString();
                    datagridCikisiase.Rows[i].Cells["birimfiyat"].Value = birimFiyat.ToString();
                    datagridCikisiase.Rows[i].Cells["miktar"].Value = miktar.ToString();
                    datagridCikisiase.Rows[i].Cells["ToplamTutar"].Value = toplamTutar.ToString();
                    if (datagridiaseicerik.Rows[i].Cells["Ogun"].Value.ToString() == "Sabah")
                    {
                        kisiBasiIase = Math.Round((miktar * birimFiyat) / toplamSabah, 5);
                        kisiBasiKalori = Math.Round((miktar * kalori) / toplamSabah, 5);
                    }
                    if (datagridiaseicerik.Rows[i].Cells["Ogun"].Value.ToString() == "Öğle")
                    {
                        kisiBasiIase = Math.Round((miktar * birimFiyat) / toplamOgle, 5);
                        kisiBasiKalori = Math.Round((miktar * kalori) / toplamOgle, 5);
                    }
                    if (datagridiaseicerik.Rows[i].Cells["Ogun"].Value.ToString() == "Akşam")
                    {
                        kisiBasiIase = Math.Round((miktar * birimFiyat) / toplamAksam, 5);
                        kisiBasiKalori = Math.Round((miktar * kalori) / toplamAksam, 5);
                    }
                    datagridCikisiase.Rows[i].Cells["kbasifiyat"].Value = kisiBasiIase.ToString();
                    datagridCikisiase.Rows[i].Cells["kbasikalori"].Value = kisiBasiKalori.ToString();
                }
                ToplamIaseHesapla(datagridCikisiase, "kbasifiyat", "kbasikalori");
                iasePlanRowIndex = datagridIaseIptalPlan.SelectedCells[0].RowIndex;
                MessageBox.Show("Kişi Başı iaşe fiyatı ve Kişi Başı kalori miktarı tekrar hesaplanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        internal void ToplamIaseHesapla(DataGridView dataGridView, string KBasiFiyatName, string KBasiKaloriName)
        {
            try
            {
                double iase = (from DataGridViewRow row in dataGridView.Rows
                               select Convert.ToDouble(row.Cells[KBasiFiyatName].Value)).Sum();
                string formatiase = MoneyConvert.ConvertMoneyFormat(iase);
                string kalori = (from DataGridViewRow row in dataGridView.Rows
                                 select Convert.ToDouble(row.Cells[KBasiKaloriName].Value)).Sum().ToString();
                if (dataGridView.Name == datagridCikisiase.Name)
                {
                    double toplamTutar = (from DataGridViewRow row in datagridCikisiase.Rows
                                          select Convert.ToDouble(row.Cells["ToplamTutar"].Value)).Sum();
                    string formatToplamTutar = MoneyConvert.ConvertMoneyFormat(toplamTutar);
                    lbliaseTutar.Text = "Toplam Tutar : " + formatToplamTutar +
                        "    Kalori Toplam Tutar : " + kalori +
                        "    İaşe Toplam Tutar : " + formatiase;
                    datagridCikisiase.FirstDisplayedScrollingRowIndex = datagridCikisiase.RowCount - 1;
                }
                else
                {
                    lblIaseIptalIaseToplamTutar.Text = "Kalori Toplam Tutar : " + kalori +
                        "    İaşe Toplam Tutar : " + formatiase;
                }
            }
            catch
            {
                MessageBox.Show("Toplam İaşe Miktarı hesaplanırken bir hata ile karşılaşıldı. Lütfen son eklediğiniz ürünü listeden kaldırıp tekrar eklemeyi deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OtomatikCikisDataGridViewValueInsert(int _rowcount, UrunKayitDtoSelectForIase entityUrunKayit, decimal dusulenMiktar)
        {
            datagridCikisiase.Rows[_rowcount].Cells["Id"].Value = entityUrunKayit.Id;
            datagridCikisiase.Rows[_rowcount].Cells["urunadi"].Value = entityUrunKayit.UrunAdi;
            datagridCikisiase.Rows[_rowcount].Cells["birim"].Value = entityUrunKayit.Birim;
            datagridCikisiase.Rows[_rowcount].Cells["kalori"].Value = entityUrunKayit.Kalori;
            datagridCikisiase.Rows[_rowcount].Cells["birimfiyat"].Value = entityUrunKayit.BirimFiyat;
            datagridCikisiase.Rows[_rowcount].Cells["ToplamTutar"].Value = entityUrunKayit.BirimFiyat * dusulenMiktar;
        }
        private void OtomatikCikis(int toplamsabah, int toplamogle, int toplamaksam)
        {
            try
            {
                var otomatikCikisKayitlari = _otomatikCikisService.GetOtomatikCikisDetailNotDeletedAndHerIase().Data;
                if (otomatikCikisKayitlari.Count > 0)
                {
                    foreach (var item in otomatikCikisKayitlari)
                    {
                        var entityUrunKayit = _urunKayitService.GetUrunKayitDetailsForOtomatikCikisUrunId(item.UrunId).Data;
                        decimal _miktarKalan = entityUrunKayit.KalanMiktar;
                        decimal _toplamMiktarSonuc = (item.sabahCikis * toplamsabah) + (item.aksamCikis * toplamogle) + (item.ogleCikis * toplamaksam);
                        if (_miktarKalan >= _toplamMiktarSonuc)
                        {
                            int _rowcount = 0;
                            if (item.sabahCikis > 0)
                            {
                                datagridCikisiase.Rows.Add();
                                _rowcount = datagridCikisiase.Rows.Count - 1;
                                datagridCikisiase.Rows[_rowcount].Cells["ogun"].Value = "Sabah";
                                decimal _dusulenMiktar = item.sabahCikis * toplamsabah;
                                OtomatikCikisDataGridViewValueInsert(_rowcount, entityUrunKayit, _dusulenMiktar);
                                datagridCikisiase.Rows[_rowcount].Cells["miktar"].Value = _dusulenMiktar;
                                datagridCikisiase.Rows[_rowcount].Cells["kbasifiyat"].Value = ((item.sabahCikis * entityUrunKayit.BirimFiyat));
                                datagridCikisiase.Rows[_rowcount].Cells["kbasikalori"].Value = ((item.sabahCikis * entityUrunKayit.Kalori));
                            }
                            if (item.ogleCikis > 0)
                            {
                                datagridCikisiase.Rows.Add();
                                _rowcount = datagridCikisiase.Rows.Count - 1;
                                datagridCikisiase.Rows[_rowcount].Cells["ogun"].Value = "Öğle";
                                decimal _dusulenMiktar = item.ogleCikis * toplamogle;
                                OtomatikCikisDataGridViewValueInsert(_rowcount, entityUrunKayit, _dusulenMiktar);
                                datagridCikisiase.Rows[_rowcount].Cells["miktar"].Value = _dusulenMiktar;
                                datagridCikisiase.Rows[_rowcount].Cells["kbasifiyat"].Value = ((item.ogleCikis * entityUrunKayit.BirimFiyat));
                                datagridCikisiase.Rows[_rowcount].Cells["kbasikalori"].Value = ((item.ogleCikis * entityUrunKayit.Kalori));
                            }
                            if (item.aksamCikis > 0)
                            {
                                datagridCikisiase.Rows.Add();
                                _rowcount = datagridCikisiase.Rows.Count - 1;
                                datagridCikisiase.Rows[_rowcount].Cells["ogun"].Value = "Akşam";
                                decimal _dusulenMiktar = item.aksamCikis * toplamaksam;
                                OtomatikCikisDataGridViewValueInsert(_rowcount, entityUrunKayit, _dusulenMiktar);
                                datagridCikisiase.Rows[_rowcount].Cells["miktar"].Value = _dusulenMiktar;
                                datagridCikisiase.Rows[_rowcount].Cells["kbasifiyat"].Value = ((item.aksamCikis * entityUrunKayit.BirimFiyat));
                                datagridCikisiase.Rows[_rowcount].Cells["kbasikalori"].Value = ((item.aksamCikis * entityUrunKayit.Kalori));
                            }
                            ToplamIaseHesapla(datagridCikisiase, "kbasifiyat", "kbasikalori");
                        }
                        else
                        {
                            MessageBox.Show(entityUrunKayit.UrunAdi + " Adlı ürününün otomatik çıkışı yeterli miktar sağlanamadığı için yapılamamıştır. Lütfen elle çıkış yapmayı veya yapılandırma ayarını değiştirmeyi deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void OgunComboboxDoldur()
        {
            foreach (var item in UrunGrubuCombobox.ogun)
            {
                cmbOgun.Items.Add(item);
            }
            cmbOgun.SelectedIndex = 0;
        }
        private void KisiSayilariTxtClear()
        {
            foreach (Control txt in cardsSayilar.Controls)
            {
                if (txt is BunifuMetroTextbox)
                {
                    txt.Text = String.Empty;
                }

            }
        }
        private void KisiSayisiTxtDoldur()
        {
            foreach (Control item in cardsSayilar.Controls)
            {
                if (item is BunifuMetroTextbox)
                {
                    if (item.Text == String.Empty && item.Name != "txtiaseAd")
                    {
                        item.Text = "0";
                    }
                }
            }
        }
        private int KisiSayisiToplamBase()
        {
            int kapalı = Convert.ToInt32(txtKapaliHT.Text);
            int acik = Convert.ToInt32(txtAcikHT.Text);
            int cocuk = Convert.ToInt32(txtCocuk.Text);
            int bebek = Convert.ToInt32(txtBebek.Text);
            int hamile = Convert.ToInt32(txtHamileBayan.Text);
            int aclikgrevi = Convert.ToInt32(txtAclikGrevi.Text);
            int diyet = Convert.ToInt32(txtDiyet.Text);
            int toplam = kapalı + acik + cocuk + bebek + hamile + aclikgrevi + diyet;
            return toplam;
        }
        private int KisiSayisiToplamSabah()
        {
            int sabahper = Convert.ToInt32(txtSabahPer.Text);
            int toplam = KisiSayisiToplamBase() + sabahper;
            return toplam;
        }
        private int KisiSayisiToplamOgle()
        {
            int ogleper = Convert.ToInt32(txtOglePer.Text);
            int toplam = KisiSayisiToplamBase() + ogleper;
            return toplam;
        }
        private int KisiSayisiToplamAksam()
        {
            int aksamper = Convert.ToInt32(txtAksamPer.Text);
            int toplam = KisiSayisiToplamBase() + aksamper;
            return toplam;
        }
        #endregion
        #region List
        private void GetIaseIcerikSayi(DateTime yemekTabelaTarih)
        {
            var iaseTabelaSayi = _cikisIaseService.GetCikisIaseDetailsDeleted(yemekTabelaTarih).Data;
            if (iaseTabelaSayi.Count > 0)
            {
                lblIaseIptal.Visible = true;
                checkediaseiptal.Visible = true;
                grpBoxIaseIptal.Visible = true;
                datagridIaseIptalPlan.DataSource = null;
                datagridIaseIptalPlan.DataSource = iaseTabelaSayi;
                foreach (DataGridViewColumn Columns in datagridIaseIptalPlan.Columns)
                {
                    if (Columns.Index == 0 || Columns.Index > 2 && Columns.Index < 13)
                    {
                        Columns.Visible = false;
                    }
                    switch (Columns.Index)
                    {
                        case 13:
                            Columns.HeaderText = "Toplam Sabah";
                            break;
                        case 14:
                            Columns.HeaderText = "Toplam Öğle";
                            break;
                        case 15:
                            Columns.HeaderText = "Toplam Akşam";
                            break;
                        case 1:
                            Columns.HeaderText = "İaşe Çıkış Tarihi";
                            break;
                        case 2:
                            Columns.HeaderText = "İaşe Adı";
                            break;
                    }
                }
                datagridIaseIptalPlan.AutoResizeColumns();
            }
            else
            {
                KisiSayilariTxtClear();
                lblIaseIptal.Visible = false;
                checkediaseiptal.Visible = false;
                grpBoxIaseIptal.Visible = false;
            }
        }
        internal int YemekTabelaListele()
        {
            var result = _tabelaService.GetTabelaDetailsTarihNotDeleted(iaseTarih);
            var result0 = _tabelaService.SelectTabelaDetailsNotDeleted();
            if (result.IsSuccess)
            {
                datagridYemekTabela.DataSource = null;
                datagridYemekTabela.DataSource = result.Data;
                datagridYemekTabela.Columns["Id"].Visible = false;
                datagridYemekTabela0.DataSource = null;
                datagridYemekTabela0.DataSource = result.Data;
                datagridYemekTabela0.Columns["Id"].Visible = false;
                GetIaseIcerikSayi(iaseTarih);
            }
            if (result.Data.Count > 0)
            {
                datagridYemekTabela0.Visible = true;
                lblYemekProgrami.Visible = true;
            }
            else
            {
                datagridYemekTabela0.Visible = false;
                lblYemekProgrami.Visible = false;
            }
            return result0.Data.Count;

        }
        internal int DepoUrunListele()
        {
            var result = _urunKayitService.GetUrunKayitSelectForIaseNotDeleted(iaseTarih);
            if (result.IsSuccess)
            {
                datagridDepoUrunList.DataSource = null;
                datagridDepoUrunList.DataSource = result.Data;
                datagridDepoUrunList.Columns["Id"].Visible = false;
            }
            return result.Data.Count;
        }
        #endregion
    }
}
