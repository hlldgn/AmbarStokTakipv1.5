using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmiaseDus : Form // Check
    {
        private readonly IUrunKayitService _urunKayitService;
        private readonly IOtomatikCikisService _otomatikCikisService;
        private long _urunKayitId = 0;
        public frmiaseDus()
        {
            InitializeComponent();
            _otomatikCikisService=InstanceFactory.GetInstance<IOtomatikCikisService>();
            _urunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            Yukle();
        }
        #region Method
        private UrunKayitDtoSelectForIaseDus GetUrunKayitDetails()
        {
            txtToplamSabah.Text = IaseDusDto.ToplamSabah.ToString();
            txtToplamOgle.Text = IaseDusDto.ToplamOgle.ToString();
            txtToplamAksam.Text = IaseDusDto.ToplamAksam.ToString();
            _urunKayitId = IaseDusDto.UrunKayitId;
            txtOgun.Text = IaseDusDto.Ogun;
            var urunKayitEntity = _urunKayitService.GetUrunKayitDetailsForIaseDus(_urunKayitId);
            return urunKayitEntity.Data;
        }
        private void OtomatikCikis(long _urunid)
        {
            var otomatikCikisEntity = _otomatikCikisService.GetByOtomatikCikisDetailsUrunIdSecimiBanaBirak(_urunid);
            if (otomatikCikisEntity.Data != null)
            {
                if (txtOgun.Text == "Sabah")
                {
                    txtCikis.Text = (IaseDusDto.ToplamSabah * otomatikCikisEntity.Data.sabahCikis).ToString().Replace(",00000", "");
                }
                if (txtOgun.Text == "Öğle")
                {
                    txtCikis.Text = (IaseDusDto.ToplamOgle * otomatikCikisEntity.Data.ogleCikis).ToString().Replace(",00000", ""); ;
                }
                if (txtOgun.Text == "Akşam")
                {
                    txtCikis.Text = (IaseDusDto.ToplamAksam * otomatikCikisEntity.Data.aksamCikis).ToString().Replace(",00000", ""); ;
                }
            }
        }
        private void IaseHesapla()
        {
            try
            {
                double _birimfiyat = double.Parse(txtBirimFiyat.Text);
                double _kalori = double.Parse(txtKalori.Text);
                double _tsabah = double.Parse(txtToplamSabah.Text);
                double _togle = double.Parse(txtToplamOgle.Text);
                double _taksam = double.Parse(txtToplamAksam.Text);
                double _depomiktar = double.Parse(txtDepoMiktar.Text);
                if (txtKFiyat.Text.Length > 0 && bunifuCheckbox1.Checked == true)
                {
                    double _kisibasifiyat = double.Parse(txtKFiyat.Text);
                    if (txtOgun.Text == "Sabah")
                    {
                        txtCikis.Text = Math.Round(((_kisibasifiyat * _tsabah) / _birimfiyat), 5).ToString();
                    }
                    if (txtOgun.Text == "Öğle")
                    {
                        txtCikis.Text = Math.Round(((_kisibasifiyat * _togle) / _birimfiyat), 5).ToString();
                    }
                    if (txtOgun.Text == "Akşam")
                    {
                        txtCikis.Text = Math.Round(((_kisibasifiyat * _taksam) / _birimfiyat), 5).ToString();
                    }
                }
                else if (txtKFiyat.Text.Length <= 0 && bunifuCheckbox1.Checked == true)
                {
                    txtCikis.Text = String.Empty;
                }
                if (txtCikis.Text.Length > 0)
                {
                    double _cikismiktar = double.Parse(txtCikis.Text);
                    if (_depomiktar >= _cikismiktar)
                    {
                        txtKalanMiktar.Text = (_depomiktar - _cikismiktar).ToString();
                        double _carpimfiyat = _cikismiktar * _birimfiyat;
                        double _carpimkalori = _cikismiktar * _kalori;
                        if (txtOgun.Text == "Sabah")
                        {
                            if (bunifuCheckbox1.Checked == false)
                            {
                                txtKFiyat.Text = Math.Round((_carpimfiyat / _tsabah), 5).ToString();
                            }
                            txtKKalori.Text = Math.Round((_carpimkalori / _tsabah), 5).ToString();
                        }
                        if (txtOgun.Text == "Öğle")
                        {
                            if (bunifuCheckbox1.Checked == false)
                            {
                                txtKFiyat.Text = Math.Round((_carpimfiyat / _togle), 5).ToString();
                            }
                            txtKKalori.Text = Math.Round((_carpimkalori / _togle), 5).ToString();
                        }
                        if (txtOgun.Text == "Akşam")
                        {
                            if (bunifuCheckbox1.Checked == false)
                            {
                                txtKFiyat.Text = Math.Round((_carpimfiyat / _taksam), 5).ToString();
                            }
                            txtKKalori.Text = Math.Round((_carpimkalori / _taksam), 5).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girilen miktar depoda kalan ürün miktarından büyük olamaz.Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtKalanMiktar.Text = String.Empty;
                        txtKFiyat.Text = String.Empty;
                        txtKKalori.Text = String.Empty;
                    }
                }
                else
                {
                    txtKalanMiktar.Text = String.Empty;
                    txtKFiyat.Text = String.Empty;
                    txtKKalori.Text = String.Empty;
                }
            }
            catch
            {
                MessageBox.Show("İaşe hesaplanırken bir sorunla karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKalanMiktar.Text = String.Empty;
                txtKFiyat.Text = String.Empty;
                txtKKalori.Text = String.Empty;
                txtCikis.Text = String.Empty;
            }
        }
        #endregion
        #region List
        private void Yukle()
        {
            try
            {
                var urunKayitEntity = GetUrunKayitDetails();
                long _urunId = urunKayitEntity.UrunId;
                txtUrunAdi.Text = urunKayitEntity.UrunAdi;
                txtBirim.Text = urunKayitEntity.Birim;
                txtBirimFiyat.Text = urunKayitEntity.BirimFiyat.ToString();
                txtDepoMiktar.Text = urunKayitEntity.MiktarKalan.ToString();
                txtKalori.Text = urunKayitEntity.Kalori.ToString();

                if (txtBirim.Text == "Adet")
                {
                    bunifuCheckbox1.Visible = false;
                    lblcheck.Visible = false;
                }
                else
                {
                    bunifuCheckbox1.Visible = true;
                    lblcheck.Visible = true;
                }
                txtCikis.Select();
                OtomatikCikis(_urunId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Event

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                txtCikis.Enabled = false;
                txtKFiyat.Enabled = true;
            }
            else
            {
                txtKFiyat.Enabled = false;
                txtCikis.Enabled = true;
            }
        }
        private void lblcheck_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
                bunifuCheckbox1.Checked = false;
            else
                bunifuCheckbox1.Checked = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCikis_OnValueChanged(object sender, EventArgs e)
        {
            IaseHesapla();
        }

        private void txtKFiyat_OnValueChanged(object sender, EventArgs e)
        {
            IaseHesapla();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            TabelayaUrunEkle();
            this.Close();
        }
        #endregion
        #region KeyPress
        private void txtCikis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEkle_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txtKFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEkle_Click(sender, e);
            }
        }


        private void txtKFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txtCikis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
        #endregion
        #region InsertAndUpdate
        private void TabelayaUrunEkle()
        {
            try
            {
                if (txtKKalori.Text != "" && txtKFiyat.Text != "" && txtCikis.Text != "0")
                {
                    frmCikisiase frm = (frmCikisiase)Application.OpenForms["frmCikisiase"];
                    double _toplammiktar = 0;
                    for (int i = 0; i < frm.datagridCikisiase.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(frm.datagridCikisiase.Rows[i].Cells["Id"].Value.ToString()) == _urunKayitId)
                        {
                            _toplammiktar += Convert.ToDouble(frm.datagridCikisiase.Rows[i].Cells["miktar"].Value);
                        }
                    }
                    double _toplammiktarsonuc = _toplammiktar + Convert.ToDouble(txtCikis.Text);
                    if (Convert.ToDouble(txtDepoMiktar.Text) >= _toplammiktarsonuc)
                    {
                        frm.datagridCikisiase.Rows.Add();
                        int _rowcount = frm.datagridCikisiase.Rows.Count - 1;
                        frm.datagridCikisiase.Rows[_rowcount].Cells["Id"].Value = _urunKayitId;
                        frm.datagridCikisiase.Rows[_rowcount].Cells["ogun"].Value = txtOgun.Text;
                        frm.datagridCikisiase.Rows[_rowcount].Cells["urunadi"].Value = txtUrunAdi.Text;
                        frm.datagridCikisiase.Rows[_rowcount].Cells["birim"].Value = txtBirim.Text;
                        frm.datagridCikisiase.Rows[_rowcount].Cells["kalori"].Value = txtKalori.Text;
                        frm.datagridCikisiase.Rows[_rowcount].Cells["birimfiyat"].Value = txtBirimFiyat.Text;
                        frm.datagridCikisiase.Rows[_rowcount].Cells["miktar"].Value = txtCikis.Text;
                        frm.datagridCikisiase.Rows[_rowcount].Cells["kbasifiyat"].Value = txtKFiyat.Text;
                        frm.datagridCikisiase.Rows[_rowcount].Cells["kbasikalori"].Value = txtKKalori.Text;
                        frm.datagridCikisiase.Rows[_rowcount].Cells["ToplamTutar"].Value = Convert.ToDouble(txtBirimFiyat.Text) * Convert.ToDouble(txtCikis.Text);
                        frm.ToplamIaseHesapla(frm.datagridCikisiase, "kbasifiyat", "kbasikalori");
                    }
                    else
                    {
                        MessageBox.Show("Bu üründen yeterli miktarda kalmamıştır. Lütfen çıkış yapılan ürünleri gözden geçiriniz ve tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ürüne ait kişi başı iaşe fiyatı ve kişi başı kalori alanları hesaplanamadı ve ya alanlar uygun doldurulmamıştır. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }

}
