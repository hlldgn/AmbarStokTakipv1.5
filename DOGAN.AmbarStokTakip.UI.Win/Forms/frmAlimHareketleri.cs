using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using DOGAN.AmbarStokTakip.UI.Win.WaitForm;
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
    public partial class frmAlimHareketleri : Form
    {
        private readonly IAlimService _alimService;
        private readonly IAlimUrunService _alimUrunService;
        IDataResult<List<AlimDtoFilterSelect>> _filters;
        WaitFormFunc waitForm = new WaitFormFunc();
        int maxRow=50;
        public frmAlimHareketleri()
        {
            InitializeComponent();
            _alimService = InstanceFactory.GetInstance<IAlimService>();
            _alimUrunService = InstanceFactory.GetInstance<IAlimUrunService>();
            AlimlariListele();
            dateilkTarih.Value = DateTime.Now;
            dateSonTarih.Value = DateTime.Now;
            maxRow = Properties.Settings.Default.SatirSayisi;
            lblMaxRows.Text = "En Fazla "+maxRow.ToString() + " Satır Gösteriliyor.";
        }
        #region Method
        private void AlimlariListele()
        {
            _filters = _alimService.GetAlimDetailsAllAlim();
            var alimDtoFilterSelects = FilterSetting();
            foreach (var item in alimDtoFilterSelects)
            {
                try
                {
                    _filters.Data.Remove(item);
                }
                catch
                {
                }
            }
            AlimDataGridViewStyleAndDataSource();
        }
        private void AlimIcerikListele(long _alimId)
        {
            var result = _alimUrunService.GetAlimUrunDetails(_alimId);
            if (result.IsSuccess)
            {
                datagridAlimicerik.DataSource = null;
                datagridAlimicerik.DataSource = result.Data;
                datagridAlimicerik.Columns["Id"].Visible = false;
                datagridAlimicerik.Columns["AlimId"].Visible = false;
                datagridAlimicerik.AutoResizeColumns();
            }
        }
        private void ControlVisible(bool deger)
        {
            lblAlimicerigi.Visible = deger;
            lblAlimlar.Visible = deger;
            datagridAlimicerik.Visible = deger;
            datagridHareketAlimListesi.Visible = deger;
        }
        private void AlimDataGridViewStyleAndDataSource()
        {
            datagridHareketAlimListesi.DataSource = null;
            datagridHareketAlimListesi.DataSource = _filters.Data.Take(maxRow).ToList();
            datagridHareketAlimListesi.Columns["Id"].Visible = false;
            datagridHareketAlimListesi.Columns["ProgramDeleted"].Visible = false;
            datagridHareketAlimListesi.Columns["UserDeleted"].Visible = false;
            if (datagridHareketAlimListesi.Rows.Count>0)
            {
                ControlVisible(true);
            }
            else
            {
                ControlVisible(false);
            }
        }
        private void FiltreControlLocationAndSize()
        {
            if (checkTarihlerArasiAlimKayitlari.Checked == true)
            {
                cardTarihlerArasiAlimKayitlari.Size = new System.Drawing.Size(215, 145);
            }
            else
            {
                cardTarihlerArasiAlimKayitlari.Size = new System.Drawing.Size(215, 10);
            }
            if (checkKelime.Checked == true)
            {
                cadrsKelime.Size = new System.Drawing.Size(215, 61);
            }
            else
            {
                cadrsKelime.Size = new System.Drawing.Size(215, 10);
            }
            Point tarih = cardTarihlerArasiAlimKayitlari.Location + cardTarihlerArasiAlimKayitlari.Size;
            checkKelime.Location = new Point(12, tarih.Y + 30);
            lblAlimKayitlariKelime.Location = new Point(36, tarih.Y + 32);
            cadrsKelime.Location = new Point(0, tarih.Y + 60);
            Point kelime = cadrsKelime.Location + cadrsKelime.Size;
            checkUserDeleted.Location = new Point(12, kelime.Y + 30);
            lbliptaledilmisalim.Location = new Point(36, kelime.Y + 32);
            checkProgramDeleted.Location = new Point(12, kelime.Y + 60);
            lblmiktarbitmisalim.Location = new Point(36, kelime.Y + 62);
        }
        private List<AlimDtoFilterSelect> FilterSetting()
        {
            List<AlimDtoFilterSelect> alimDtoFilterSelects = new List<AlimDtoFilterSelect>();
            DateTime ilkTarih = DateTime.Parse(dateilkTarih.Value.ToShortDateString());
            DateTime sonTarih = DateTime.Parse(dateSonTarih.Value.ToShortDateString());
            string ara = txtAra.Text;
            if (checkTarihlerArasiAlimKayitlari.Checked == true)
            {
                foreach (var data in _filters.Data)
                {
                    DateTime _tarih = DateTime.Parse(data.AlimTarihi.ToShortDateString());
                    if (ilkTarih > _tarih || _tarih > sonTarih)
                    {
                        alimDtoFilterSelects.Add(data);
                    }
                }

            }
            if (checkProgramDeleted.Checked == true)
            {
                foreach (var data in _filters.Data)
                {
                    if (data.ProgramDeleted == false)
                    {
                        alimDtoFilterSelects.Add(data);
                    }
                }
            }
            if (checkUserDeleted.Checked == true)
            {
                foreach (var data in _filters.Data)
                {
                    if (data.UserDeleted == false)
                    {
                        alimDtoFilterSelects.Add(data);
                    }
                }
            }
            if (checkKelime.Checked == true)
            {
                foreach (var data in _filters.Data)
                {
                    if (!data.AlimAdi.ToUpper().Contains(ara))
                    {
                        alimDtoFilterSelects.Add(data);
                    }
                }
            }
            return alimDtoFilterSelects;
        }
        #endregion
        #region Event
        private void datagridHareketAlimListesi_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridHareketAlimListesi.Rows.Count > 0)
            {
                long _alimId = long.Parse(datagridHareketAlimListesi.CurrentRow.Cells["Id"].Value.ToString());
                AlimIcerikListele(_alimId);
            }
            else
            {
                datagridAlimicerik.DataSource = null;
            }
        }
        private void checkTarihlerArasiAlimKayitlari_OnChange(object sender, EventArgs e)
        {
            FiltreControlLocationAndSize();
        }
        private void checkKelime_OnChange(object sender, EventArgs e)
        {
            FiltreControlLocationAndSize();
        }
        private void lblTarihlerArasiAlimKayitlari_Click(object sender, EventArgs e)
        {
            if (checkTarihlerArasiAlimKayitlari.Checked == true)
                checkTarihlerArasiAlimKayitlari.Checked = false;
            else
                checkTarihlerArasiAlimKayitlari.Checked = true;
            FiltreControlLocationAndSize();
        }
        private void lblAlimKayitlariKelime_Click(object sender, EventArgs e)
        {
            if (checkKelime.Checked == true)
                checkKelime.Checked = false;
            else
                checkKelime.Checked = true;
            FiltreControlLocationAndSize();
        }
        private void lbliptaledilmisalim_Click(object sender, EventArgs e)
        {
            if (checkUserDeleted.Checked == true)
                checkUserDeleted.Checked = false;
            else
                checkUserDeleted.Checked = true;
        }
        private void lblmiktarbitmisalim_Click(object sender, EventArgs e)
        {
            if (checkProgramDeleted.Checked == true)
                checkProgramDeleted.Checked = false;
            else
                checkProgramDeleted.Checked = true;
        }
        private void btnUygula_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            AlimlariListele();
            waitForm.Close();
        }
        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
        #endregion
    }
}
