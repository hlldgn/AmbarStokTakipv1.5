using Bunifu.Framework.UI;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmFaturaVeOdemeKayitlari : Form // Check
    {
        private readonly IFaturaService _faturaService;
        private readonly IOdemeService _odemeService;
        private readonly IUrunKayitService _urunKayitService;
        IDataResult<List<OdemeDtoSelect>> _filtersOdeme;
        IDataResult<List<FaturaDtoSelect>> _filtersFatura;
        int maxRow = 50;
        public frmFaturaVeOdemeKayitlari()
        {
            InitializeComponent();
            _faturaService = InstanceFactory.GetInstance<IFaturaService>();
            _odemeService = InstanceFactory.GetInstance<IOdemeService>();
            _urunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            maxRow = Properties.Settings.Default.SatirSayisi;
            lblMaxRows.Text = "En Fazla " + maxRow.ToString() + " Satır Gösteriliyor.";
            checkFatura.Checked = true;
            dateilkTarih.Value = DateTime.Now;
            dateSonTarih.Value = DateTime.Now;
            FaturaListele();
        }
        #region Method
        private void FaturaListele()
        {
            _filtersFatura = _faturaService.GetFaturaNotDeletedDetails();
            var faturaDtoSelectFilters = FilterSettingFatura();
            foreach (var item in faturaDtoSelectFilters)
            {
                try
                {
                    _filtersFatura.Data.Remove(item);
                }
                catch
                {
                }
            }
            datagridFaturaVeOdemeKayitlari.DataSource = null;
            datagridFaturaVeOdemeKayitlari.DataSource = _filtersFatura.Data.Take(maxRow).ToList();
            datagridFaturaVeOdemeKayitlari.Columns["Id"].Visible = false;
            datagridFaturaVeOdemeKayitlari.Columns["UrunKayitId"].Visible = false;
            lblKayitlariListesi.Text = "Fatura Girişi Yapılmış Kayıtlar";
        }
        private void OdemeListele()
        {
            _filtersOdeme = _odemeService.GetOdemeNotDeletedDetails();
            var odemeDtoSelectFilters = FilterSettingOdeme();
            foreach (var item in odemeDtoSelectFilters)
            {
                try
                {
                    _filtersOdeme.Data.Remove(item);
                }
                catch
                {
                }
            }
            datagridFaturaVeOdemeKayitlari.DataSource = null;
            datagridFaturaVeOdemeKayitlari.DataSource = _filtersOdeme.Data.Take(maxRow).ToList();
            datagridFaturaVeOdemeKayitlari.Columns["Id"].Visible = false;
            datagridFaturaVeOdemeKayitlari.Columns["UrunKayitId"].Visible = false;
            lblKayitlariListesi.Text = "Ödeme Girişi Yapılmış Kayıtlar";
        }
        private void UpdateFatura(long Id)
        {
            _faturaService.UpdateForUser(Id);
        }
        private void UpdateOdeme(long Id)
        {
            _odemeService.UpdateForUser(Id);
        }
        private void UpdateUrunKayitFatura(long urunKayitId, bool fatura)
        {
            _urunKayitService.UpdateForFatura(urunKayitId, fatura);
        }
        private void UpdateUrunKayitOdeme(long urunKayitId, bool odeme)
        {
            _urunKayitService.UpdateForOdeme(urunKayitId, odeme);
        }
        private List<OdemeDtoSelect> FilterSettingOdeme()
        {
            List<OdemeDtoSelect> odemeDtoSelect = new List<OdemeDtoSelect>();
            DateTime ilkTarih = DateTime.Parse(dateilkTarih.Value.ToShortDateString());
            DateTime sonTarih = DateTime.Parse(dateSonTarih.Value.ToShortDateString());
            string ara = txtAra.Text;
            if (checkTarihlerArasiKayitlar.Checked == true)
            {
                foreach (var data in _filtersOdeme.Data)
                {
                    DateTime _tarih = DateTime.Parse(data.OdemeTarihi.ToShortDateString());
                    if (ilkTarih > _tarih || _tarih > sonTarih)
                    {
                        odemeDtoSelect.Add(data);
                    }
                }

            }
            if (checkKelime.Checked == true)
            {
                foreach (var data in _filtersOdeme.Data)
                {
                    if (!data.TedarikciFirma.ToUpper().Contains(ara))
                    {
                        odemeDtoSelect.Add(data);
                    }
                }
            }
            return odemeDtoSelect;
        }
        private List<FaturaDtoSelect> FilterSettingFatura()
        {
            List<FaturaDtoSelect> faturaDtoSelect = new List<FaturaDtoSelect>();
            DateTime ilkTarih = DateTime.Parse(dateilkTarih.Value.ToShortDateString());
            DateTime sonTarih = DateTime.Parse(dateSonTarih.Value.ToShortDateString());
            string ara = txtAra.Text;
            if (checkTarihlerArasiKayitlar.Checked == true)
            {
                foreach (var data in _filtersFatura.Data)
                {
                    DateTime _tarih = DateTime.Parse(data.FaturaTarihi.ToShortDateString());
                    if (ilkTarih > _tarih || _tarih > sonTarih)
                    {
                        faturaDtoSelect.Add(data);
                    }
                }

            }
            if (checkKelime.Checked == true)
            {
                foreach (var data in _filtersFatura.Data)
                {
                    if (!data.TedarikciFirma.ToUpper().Contains(ara))
                    {
                        faturaDtoSelect.Add(data);
                    }
                }
            }
            return faturaDtoSelect;
        }
        private void FiltreControlLocationAndSize()
        {
            if (checkTarihlerArasiKayitlar.Checked == true)
            {
                cardTarihlerArasiKayitlar.Size = new Size(cardTarihlerArasiKayitlar.Size.Width, 145);
            }
            else
            {
                cardTarihlerArasiKayitlar.Size = new Size(cardTarihlerArasiKayitlar.Size.Width, 10);
            }
            if (checkKelime.Checked == true)
            {
                cadrsKelime.Size = new Size(cadrsKelime.Size.Width, 61);
            }
            else
            {
                cadrsKelime.Size = new Size(cadrsKelime.Size.Width, 10);
            }
            Point tarih = cardTarihlerArasiKayitlar.Location + cardTarihlerArasiKayitlar.Size;
            checkKelime.Location = new Point(12, tarih.Y + 30);
            lblKayitlarKelime.Location = new Point(36, tarih.Y + 32);
            cadrsKelime.Location = new Point(0, tarih.Y + 60);
            Point kelime = cadrsKelime.Location + cadrsKelime.Size;
            grpBoxGoster.Location = new Point(0, kelime.Y + 30);
        }
        #endregion
        #region Event
        private void checkFatura_OnChange(object sender, EventArgs e)
        {
            if (checkFatura.Checked == true)
            {
                checkOdeme.Checked = false;
            }
        }
        private void checkOdeme_OnChange(object sender, EventArgs e)
        {
            if (checkOdeme.Checked == true)
            {
                checkFatura.Checked = false;
            }
        }
        private void lblFaturaKayitlari_Click(object sender, EventArgs e)
        {
            if (checkFatura.Checked == true)
            {
                checkFatura.Checked = false;
                checkOdeme.Checked = true;
            }
        }
        private void lblOdemeKayitlari_Click(object sender, EventArgs e)
        {
            if (checkOdeme.Checked == true)
            {
                checkFatura.Checked = true;
                checkOdeme.Checked = false;
            }
        }
        private void btniptal_Click(object sender, EventArgs e)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    string tarih;
                    int _selectedRow = datagridFaturaVeOdemeKayitlari.SelectedCells[0].RowIndex;
                    long id = long.Parse(datagridFaturaVeOdemeKayitlari.Rows[_selectedRow].Cells["Id"].Value.ToString());
                    long urunKayitId = long.Parse(datagridFaturaVeOdemeKayitlari.Rows[_selectedRow].Cells["UrunKayitId"].Value.ToString());
                    if (checkFatura.Checked == true)
                    {
                        tarih = datagridFaturaVeOdemeKayitlari.Rows[_selectedRow].Cells["FaturaTarihi"].Value.ToString();
                        if (DialogResult.Yes == MessageBox.Show(tarih + " tarihli fatura kaydını iptal etmek istiyormusunuz. İptal edildiği taktirde ilgili ürün kaydının fatura durumu Fatura Kesilmemiş olarak değiştirilecek.",
                            "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            UpdateFatura(id);
                            UpdateUrunKayitFatura(urunKayitId, false);
                            FaturaListele();
                        }
                    }
                    else
                    {
                        tarih = datagridFaturaVeOdemeKayitlari.Rows[_selectedRow].Cells["OdemeTarihi"].Value.ToString();
                        if (DialogResult.Yes == MessageBox.Show(tarih + " tarihli odeme kaydını iptal etmek istiyormusunuz. İptal edildiği taktirde ilgili ürün kaydının odeme durumu Ödemesi Yapılmamış olarak değiştirilecek.",
                            "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            UpdateOdeme(id);
                            UpdateUrunKayitOdeme(urunKayitId, false);
                            OdemeListele();
                        }
                    }
                    transactionScope.Complete();
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnUygula_Click_1(object sender, EventArgs e)
        {
            if (checkFatura.Checked == true)
            {
                FaturaListele();
            }
            else
            {
                OdemeListele();
            }
        }
        #endregion

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void checkTarihlerArasiKayitlar_OnChange(object sender, EventArgs e)
        {
            FiltreControlLocationAndSize();
        }

        private void lblTarihlerArasiKayitlar_Click(object sender, EventArgs e)
        {
            if (checkTarihlerArasiKayitlar.Checked == true)
                checkTarihlerArasiKayitlar.Checked = false;
            else
                checkTarihlerArasiKayitlar.Checked = true;
            FiltreControlLocationAndSize();
        }

        private void lblKayitlarKelime_Click(object sender, EventArgs e)
        {
            if (checkKelime.Checked == true)
                checkKelime.Checked = false;
            else
                checkKelime.Checked = true;
            FiltreControlLocationAndSize();
        }

        private void checkKelime_OnChange(object sender, EventArgs e)
        {
            FiltreControlLocationAndSize();
        }
    }
}
