using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.CommonTools.Converts;
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
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmUrunCikisHareketleri : Form
    {
        private readonly ICikisIaseTabelaService _cikisIaseTabelaService;
        private readonly ICikisSarfService _cikisSarfService;
        WaitFormFunc waitForm = new WaitFormFunc();
        IDataResult<List<CikisIaseTabelaDtoSelectForCikisHareket>> _filtersIase;
        IDataResult<List<CikisSarfDtoSelect>> _filtersSarf;
        int maxRow = 50;
        public frmUrunCikisHareketleri()
        {
            InitializeComponent();
            _cikisIaseTabelaService = InstanceFactory.GetInstance<ICikisIaseTabelaService>();
            _cikisSarfService = InstanceFactory.GetInstance<ICikisSarfService>();
            maxRow = Properties.Settings.Default.SatirSayisi;
            lblMaxRows.Text = "En Fazla " + maxRow.ToString() + " Satır Gösteriliyor.";
            FiltreUygula();
            dateilkTarih.Value = DateTime.Now;
            dateSonTarih.Value = DateTime.Now;
        }
        #region Method
        private void FiltreControlLocationAndSize()
        {
            if (checkTarihlerArasiUrunKayitlari.Checked == true)
            {
                cardTarihlerArasiAlimKayitlari.Size = new Size(cardTarihlerArasiAlimKayitlari.Size.Width, 145);
            }
            else
            {
                cardTarihlerArasiAlimKayitlari.Size = new Size(cardTarihlerArasiAlimKayitlari.Size.Width, 10);
            }
            if (checkKelime.Checked == true)
            {
                cadrsKelime.Size = new Size(cadrsKelime.Size.Width, 61);
            }
            else
            {
                cadrsKelime.Size = new Size(cadrsKelime.Size.Width, 10);
            }
            Point tarih = cardTarihlerArasiAlimKayitlari.Location + cardTarihlerArasiAlimKayitlari.Size;
            checkKelime.Location = new Point(12, tarih.Y + 30);
            lblUrunKayitlariKelime.Location = new Point(36, tarih.Y + 32);
            cadrsKelime.Location = new Point(0, tarih.Y + 60);
            Point kelime = cadrsKelime.Location + cadrsKelime.Size;
            grpBoxGoster.Location = new Point(0, kelime.Y + 30);
        }
        private void FiltreUygula()
        {
            if (checkIase.Checked==true)
            {
                iaseUrunleriListele();
            }
            else
            {
                SarfUrunleriListele();
            }
        }
        private void iaseUrunleriListele()
        {
            _filtersIase = _cikisIaseTabelaService.GetCikisIaseTabelaDetailsForCikisHareket();
            var alimDtoFilterSelects = FilterSettingForIase();
            foreach (var item in alimDtoFilterSelects)
            {
                try
                {
                    _filtersIase.Data.Remove(item);
                }
                catch
                {
                }
            }
            DataGridViewStyleAndDataSource(true);
            ToplamTutar();
        }
        private void ControlVisible(bool deger)
        {
            lblUrunler.Visible = deger;
            datagridUrunCikis.Visible = deger;
        }
        private void ToplamTutar()
        {
            double toplamTutar = (from DataGridViewRow row in datagridUrunCikis.Rows
                               select Convert.ToDouble(row.Cells["ToplamTutar"].Value.ToString())).Sum();
            string formatted = MoneyConvert.ConvertMoneyFormat(toplamTutar);
            lblToplamTutar.Text = "Toplam Tutar= " + formatted;
        }
        private void SarfUrunleriListele()
        {
            _filtersSarf = _cikisSarfService.GetCikisSarfDetails();
            var alimDtoFilterSelects = FilterSettingForSarf();
            foreach (var item in alimDtoFilterSelects)
            {
                try
                {
                    _filtersSarf.Data.Remove(item);
                }
                catch
                {
                }
            }
            DataGridViewStyleAndDataSource(false);
            ToplamTutar();
        }
        private List<CikisIaseTabelaDtoSelectForCikisHareket> FilterSettingForIase()
        {
            List<CikisIaseTabelaDtoSelectForCikisHareket> CikisKayitHareket = new List<CikisIaseTabelaDtoSelectForCikisHareket>();
            DateTime ilkTarih = DateTime.Parse(dateilkTarih.Value.ToShortDateString());
            DateTime sonTarih = DateTime.Parse(dateSonTarih.Value.ToShortDateString());
            string ara = txtAra.Text;
            if (checkTarihlerArasiUrunKayitlari.Checked == true)
            {
                foreach (var data in _filtersIase.Data)
                {
                    DateTime _tarih = DateTime.Parse(data.CikisTarihi.ToShortDateString());
                    if (ilkTarih > _tarih || _tarih > sonTarih)
                    {
                        CikisKayitHareket.Add(data);
                    }
                }

            }
            if (checkKelime.Checked == true)
            {
                foreach (var data in _filtersIase.Data)
                {
                    if (!data.UrunAdi.ToUpper().Contains(ara))
                    {
                        CikisKayitHareket.Add(data);
                    }
                }
            }
            return CikisKayitHareket;
        }
        private List<CikisSarfDtoSelect> FilterSettingForSarf()
        {
            List<CikisSarfDtoSelect> CikisKayitHareket = new List<CikisSarfDtoSelect>();
            DateTime ilkTarih = DateTime.Parse(dateilkTarih.Value.ToShortDateString());
            DateTime sonTarih = DateTime.Parse(dateSonTarih.Value.ToShortDateString());
            string ara = txtAra.Text;
            if (checkTarihlerArasiUrunKayitlari.Checked == true)
            {
                foreach (var data in _filtersSarf.Data)
                {
                    DateTime _tarih = DateTime.Parse(data.CikisTarihi.ToShortDateString());
                    if (ilkTarih > _tarih || _tarih > sonTarih)
                    {
                        CikisKayitHareket.Add(data);
                    }
                }

            }
            if (checkKelime.Checked == true)
            {
                foreach (var data in _filtersSarf.Data)
                {
                    if (!data.UrunAdi.ToUpper().Contains(ara))
                    {
                        CikisKayitHareket.Add(data);
                    }
                }
            }
            return CikisKayitHareket;
        }
        private void DataGridViewStyleAndDataSource(bool iaseOrSarf)
        {
            datagridUrunCikis.DataSource = null;
            if (iaseOrSarf)
            {
                datagridUrunCikis.DataSource = _filtersIase.Data.Take(maxRow).ToList();
            }
            else
            {
                datagridUrunCikis.DataSource = _filtersSarf.Data.Take(maxRow).ToList();
            }
            datagridUrunCikis.Columns["Id"].Visible = false;
            datagridUrunCikis.Columns["UrunKayitId"].Visible = false;
            if (datagridUrunCikis.Rows.Count > 0)
            {
                ControlVisible(true);
            }
            else
            {
                ControlVisible(false);
            }
        }
        #endregion
        #region KeyPress
        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
        #endregion
        #region Event
        private void checkTarihlerArasiUrunKayitlari_OnChange(object sender, EventArgs e)
        {
            FiltreControlLocationAndSize();
        }

        private void checkKelime_OnChange(object sender, EventArgs e)
        {
            FiltreControlLocationAndSize();
        }

        private void lblTarihlerArasiUrunKayitlari_Click(object sender, EventArgs e)
        {
            if (checkTarihlerArasiUrunKayitlari.Checked == true)
                checkTarihlerArasiUrunKayitlari.Checked = false;
            else
                checkTarihlerArasiUrunKayitlari.Checked = true;
            FiltreControlLocationAndSize();
        }

        private void lblUrunKayitlariKelime_Click(object sender, EventArgs e)
        {
            if (checkKelime.Checked == true)
                checkKelime.Checked = false;
            else
                checkKelime.Checked = true;
            FiltreControlLocationAndSize();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            FiltreUygula();
        }

        private void frmUrunCikisHareketleri_Load(object sender, EventArgs e)
        {
            FiltreUygula();
        }
        #endregion

        private void checkIase_OnChange(object sender, EventArgs e)
        {
            if (checkIase.Checked == true)
                checkSarf.Checked = false;
            else
                checkSarf.Checked = true;
        }

        private void checkSarf_OnChange(object sender, EventArgs e)
        {
            if (checkSarf.Checked == true)
                checkIase.Checked = false;
            else
                checkIase.Checked = true;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            if (checkIase.Checked == true)
            {
                checkSarf.Checked = true;
                checkIase.Checked = false;
            }
            else
            {
                checkSarf.Checked = false;
                checkIase.Checked = true;
            }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            if (checkSarf.Checked == true)
            {
                checkSarf.Checked = false;
                checkIase.Checked = true;
            }
            else
            {
                checkSarf.Checked = true;
                checkIase.Checked = false;
            }
        }
    }
}
