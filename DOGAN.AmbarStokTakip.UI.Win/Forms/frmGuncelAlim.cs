using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmGuncelAlim : Form // Check 
    {
        private readonly IAlimService _alimService;
        private readonly IAlimUrunService _alimUrunService;
        public frmGuncelAlim()
        {
            InitializeComponent();
            _alimService = InstanceFactory.GetInstance<IAlimService>();
            _alimUrunService = InstanceFactory.GetInstance<IAlimUrunService>();
            AlimListele();

        }
        #region Method
        private void ProgressBarStyle(int yuzde)
        {
            progresAlinan.Value = yuzde;
            if (yuzde > 75)
            {
                progresAlinan.ProgressBackColor = Color.Crimson;
            }
            else
            {
                progresAlinan.ProgressBackColor = Color.SeaGreen;
            }
        }
        int YuzdeHesapla(decimal miktar, decimal kalanmiktar)
        {
            decimal carpim1 = 100 * kalanmiktar;
            int sonuc = Convert.ToInt32(carpim1 / miktar);
            return 100 - sonuc;
        }
        internal int AlimListele()
        {
            var result = _alimService.GetAlimDetailsNotDeleted();
            if (result.IsSuccess)
            {
                datagridHareketAlimListesi.DataSource = null;
                datagridHareketAlimListesi.DataSource = result.Data;
                datagridHareketAlimListesi.Columns["Id"].Visible = false;
                datagridHareketAlimListesi.AutoResizeColumns();
            }
            return result.Data.Count;
        }
        private void AlimIcerikListele(int _alimId)
        {
            var result = _alimUrunService.GetAlimUrunDetailsByIdNotDeleted(_alimId);
            if (result.IsSuccess)
            {
                datagridAlimicerik.DataSource = null;
                datagridAlimicerik.DataSource = result.Data;
                datagridAlimicerik.Columns["Id"].Visible = false;//AlimUrunId
                datagridAlimicerik.Columns["AlimId"].Visible = false;//AlimId
                datagridAlimicerik.AutoResizeColumns();
            }
        }
        #endregion
        #region Event
        private void btniptal_Click(object sender, EventArgs e)
        {
            int _selectedRow = datagridHareketAlimListesi.SelectedCells[0].RowIndex;
            string alimAdi = datagridHareketAlimListesi.Rows[_selectedRow].Cells["AlimAdi"].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show(alimAdi + " Adlı alımı iptal etmek istediğinize emin misiniz? alım iptal edilirse " + alimAdi
                + " adlı alımdan kalan tüm ürünler iptal edilecek, ürün kaydı yapılan ürünler ile işlem yapmaya devam edebileceksiniz.", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                long alimId = long.Parse(datagridHareketAlimListesi.Rows[_selectedRow].Cells["Id"].Value.ToString());
                if (UpdateAlim(alimId))
                {
                    MessageBox.Show(alimAdi + " Adlı alım iptal edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimListele();
                }
                else
                {
                    MessageBox.Show(alimAdi + " Adlı alım iptal edilirker bir sorunla karşılaşıldı.Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void datagridHareketAlimListesi_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridHareketAlimListesi.Rows.Count > 0)
            {
                progresAlinan.Visible = true;
                lblAlinanMiktar.Visible = true;
                int _alimId = Convert.ToInt32(datagridHareketAlimListesi.CurrentRow.Cells["Id"].Value.ToString());
                AlimIcerikListele(_alimId);
                decimal toplamAlinanMiktar = _alimUrunService.GetSumAlimUrunAlinanMiktar(_alimId);
                decimal toplamKalanMiktar = _alimUrunService.GetSumAlimUrunMiktarKalan(_alimId);
                int yuzde = YuzdeHesapla(toplamAlinanMiktar, toplamKalanMiktar);
                ProgressBarStyle(yuzde);
            }
            else
            {
                datagridAlimicerik.DataSource = null;
                progresAlinan.Visible = false;
                lblAlinanMiktar.Visible = false;
            }
        }
        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtAra.Text;
            var result = _alimService.SearchAlimDetailsNotDeleted(search);
            if (result.IsSuccess)
            {
                datagridHareketAlimListesi.DataSource = null;
                datagridHareketAlimListesi.DataSource = result.Data;
                datagridHareketAlimListesi.Columns["Id"].Visible = false;
                datagridHareketAlimListesi.AutoResizeColumns();
            }
        }
        #endregion
        #region InsertAndUpdate
        private bool UpdateAlim(long alimId)
        {
            return _alimService.UpdateDelete(alimId, false, true).IsSuccess;
        }
        #endregion
    }
}
