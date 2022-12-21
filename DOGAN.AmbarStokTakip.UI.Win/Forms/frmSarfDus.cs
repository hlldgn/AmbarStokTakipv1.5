using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
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
    public partial class frmSarfDus : Form
    {
        private readonly IUrunKayitService _urunKayitService;
        private long _urunKayitId = 0;
        public frmSarfDus()
        {
            InitializeComponent();
            _urunKayitService=InstanceFactory.GetInstance<IUrunKayitService>();
            Yukle();
        }
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
                txtCikis.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Method
        private UrunKayitDtoSelectForIaseDus GetUrunKayitDetails()
        {
            _urunKayitId = SarfDusDto.UrunKayitId;
            var urunKayitEntity = _urunKayitService.GetUrunKayitDetailsForIaseDus(_urunKayitId);
            return urunKayitEntity.Data;
        }
        private void TabelayaUrunEkle()
        {
            try
            {
                if (txtCikis.Text != "0")
                {
                    frmCikisSarf frm = (frmCikisSarf)Application.OpenForms["frmCikisSarf"];
                    double _toplammiktar = 0;
                    for (int i = 0; i < frm.datagridCikisSarf.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(frm.datagridCikisSarf.Rows[i].Cells["Id"].Value.ToString()) == _urunKayitId)
                        {
                            _toplammiktar += Convert.ToDouble(frm.datagridCikisSarf.Rows[i].Cells["Miktar"].Value);
                        }
                    }
                    double _toplammiktarsonuc = _toplammiktar + Convert.ToDouble(txtCikis.Text);
                    if (Convert.ToDouble(txtDepoMiktar.Text) >= _toplammiktarsonuc)
                    {
                        frm.datagridCikisSarf.Rows.Add();
                        int _rowcount = frm.datagridCikisSarf.Rows.Count - 1;
                        frm.datagridCikisSarf.Rows[_rowcount].Cells["Id"].Value = _urunKayitId;
                        frm.datagridCikisSarf.Rows[_rowcount].Cells["UrunAdi"].Value = txtUrunAdi.Text;
                        frm.datagridCikisSarf.Rows[_rowcount].Cells["Birim"].Value = txtBirim.Text;
                        frm.datagridCikisSarf.Rows[_rowcount].Cells["BirimFiyat"].Value = txtBirimFiyat.Text;
                        frm.datagridCikisSarf.Rows[_rowcount].Cells["Miktar"].Value = txtCikis.Text;
                        frm.datagridCikisSarf.Rows[_rowcount].Cells["ToplamTutar"].Value = txtToplamTutar.Text;
                        frm.ToplamTutarHesapla();
                    }
                    else
                    {
                        MessageBox.Show("Bu üründen yeterli miktarda kalmamıştır. Lütfen çıkış yapılan ürünleri gözden geçiriniz ve tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Çikiş yapılan miktar alanı uygun doldurulmamış. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ToplamTutarHesapla()
        {
            try
            {
                double _birimfiyat = double.Parse(txtBirimFiyat.Text);
                double _depomiktar = double.Parse(txtDepoMiktar.Text);
                if (txtCikis.Text.Length > 0)
                {
                    double _dusulenMiktar = Convert.ToDouble(txtCikis.Text);
                    if (_depomiktar >= _dusulenMiktar)
                    {
                        txtToplamTutar.Text = (_birimfiyat * _dusulenMiktar).ToString();
                        txtKalanMiktar.Text = (_depomiktar - _dusulenMiktar).ToString();
                    }
                    else
                    {
                        txtToplamTutar.Text = "";
                        txtKalanMiktar.Text = "";
                        txtCikis.Text = "";
                        MessageBox.Show("Girilen miktar depoda kalan ürün miktarından büyük olamaz.Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtToplamTutar.Text = "";
                    txtKalanMiktar.Text = "";
                    txtCikis.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("İaşe hesaplanırken bir sorunla karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKalanMiktar.Text = "";
                txtToplamTutar.Text = "";
                txtCikis.Text = "";
            }
        }
        #endregion
        #region Event
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCikis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEkle_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void frmSarfDus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TabelayaUrunEkle();
            this.Close();
        }

        private void txtCikis_OnValueChanged(object sender, EventArgs e)
        {
            ToplamTutarHesapla();
        }
        private void txtCikis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
        #endregion
    }
}
