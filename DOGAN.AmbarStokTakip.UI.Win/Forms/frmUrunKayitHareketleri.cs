using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.CommonTools.Converts;
using DOGAN.AmbarStokTakip.CommonTools.Document.Excel.depoUrunListe;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using DOGAN.AmbarStokTakip.UI.Win.WaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmUrunKayitHareketleri : Form
    {
        private readonly IUrunKayitService _urunKayitService;
        private readonly IDepoService _depoService;
        IDataResult<List<UrunKayitDtoSelectForDepo>> _filters;
        WaitFormFunc waitForm = new WaitFormFunc();
        int maxRow = 50;
        public frmUrunKayitHareketleri()
        {
            InitializeComponent();
            _urunKayitService=InstanceFactory.GetInstance<IUrunKayitService>();
            _depoService = InstanceFactory.GetInstance<IDepoService>();
            maxRow = Properties.Settings.Default.SatirSayisi;
            lblMaxRows.Text = "En Fazla " + maxRow.ToString() + " Satir Gösteriliyor.";
            UrunleriListele();
            DepoListele();
            dateilkTarih.Value = DateTime.Now;
            dateSonTarih.Value = DateTime.Now;
        }
        #region Method
        private void DepoListele()
        {
            var result = _depoService.GetDepoDetailsNotDeleted();
            cmbDepo.DataSource = result.Data;
            cmbDepo.ValueMember = "Id";
            cmbDepo.DisplayMember = "DepoAdi";
        }
        private void FiltreControlLocationAndSize()
        {
            if(checkTarihlerArasiUrunKayitlari.Checked==true)
            {
                cardTarihlerArasiAlimKayitlari.Size = new Size(cardTarihlerArasiAlimKayitlari.Size.Width, 145);
            }
            else
            {
                cardTarihlerArasiAlimKayitlari.Size = new Size(cardTarihlerArasiAlimKayitlari.Size.Width, 10);
            }
            if(checkKelime.Checked==true)
            {
                cadrsKelime.Size = new Size(cadrsKelime.Size.Width, 61);
            }
            else
            {
                cadrsKelime.Size = new Size(cadrsKelime.Size.Width, 10);
            }
            if(checkDepo.Checked==true)
            {
                cardDepo.Size = new Size(cardDepo.Size.Width, 65);
            }
            else
            {
                cardDepo.Size = new Size(cardDepo.Size.Width, 10);
            }
            Point tarih = cardTarihlerArasiAlimKayitlari.Location+cardTarihlerArasiAlimKayitlari.Size;            
            checkKelime.Location=new Point(12, tarih.Y+30);
            lblUrunKayitlariKelime.Location = new Point(36, tarih.Y + 32);
            cadrsKelime.Location = new Point(0, tarih.Y + 60);
            Point kelime = cadrsKelime.Location + cadrsKelime.Size;
            grpBoxGoster.Location = new Point(0, kelime.Y + 30);
            Point goster=grpBoxGoster.Location+ grpBoxGoster.Size;
            cardDepo.Location = new Point(0, goster.Y + 60);
            checkDepo.Location=new Point(12, goster.Y+30);
            lblDepo.Location = new Point(36, goster.Y + 32);
        }
        private void AlimDataGridViewStyleAndDataSource()
        {
            datagridUrunKayit.DataSource = null;
            datagridUrunKayit.DataSource = _filters.Data.Take(maxRow).ToList();
            datagridUrunKayit.Columns["Id"].Visible = false;
            datagridUrunKayit.Columns["AlimId"].Visible = false;
            datagridUrunKayit.Columns["AlimUrunId"].Visible = false;
            datagridUrunKayit.Columns["DepoId"].Visible = false;
            datagridUrunKayit.Columns["ProgramDeleted"].Visible = false;
            datagridUrunKayit.Columns["UserDeleted"].Visible = false;
            datagridUrunKayit.Columns["IaseOrSarf"].Visible = false;
            if (datagridUrunKayit.Rows.Count > 0)
            {
                ControlVisible(true);
            }
            else
            {
                ControlVisible(false);
            }
        }
        private void ControlVisible(bool deger)
        {
            lblUrunler.Visible = deger;
            datagridUrunKayit.Visible = deger;
        }
        private List<UrunKayitDtoSelectForDepo> FilterSetting()
        {
            List<UrunKayitDtoSelectForDepo> urunKayitDtoSelectForDepos = new List<UrunKayitDtoSelectForDepo>();
            DateTime ilkTarih = DateTime.Parse(dateilkTarih.Value.ToShortDateString());
            DateTime sonTarih = DateTime.Parse(dateSonTarih.Value.ToShortDateString());
            string ara = txtAra.Text;
            if (checkTarihlerArasiUrunKayitlari.Checked == true)
            {
                foreach (var data in _filters.Data)
                {
                    DateTime _tarih = DateTime.Parse(data.UrunKayitTarihi.ToShortDateString());
                    if (ilkTarih > _tarih || _tarih > sonTarih)
                    {
                        urunKayitDtoSelectForDepos.Add(data);
                    }
                }

            }
            if (checkProgramDeleted.Checked == false)
            {
                foreach (var data in _filters.Data)
                {
                    if (data.ProgramDeleted == true)
                    {
                        urunKayitDtoSelectForDepos.Add(data);
                    }
                }
            }
            if (checkUserDeleted.Checked == false)
            {
                foreach (var data in _filters.Data)
                {
                    if (data.UserDeleted == true)
                    {
                        urunKayitDtoSelectForDepos.Add(data);
                    }
                }
            }
            if (checkKelime.Checked == true)
            {
                foreach (var data in _filters.Data)
                {
                    if (!data.UrunAdi.ToUpper().Contains(ara))
                    {
                        urunKayitDtoSelectForDepos.Add(data);
                    }
                }
            }
            if(checkIase.Checked==false)
            {
                foreach (var data in _filters.Data)
                {
                    if (data.IaseOrSarf==true)
                    {
                        urunKayitDtoSelectForDepos.Add(data);
                    }
                }
            }
            if (checkSarf.Checked == false)
            {
                foreach (var data in _filters.Data)
                {
                    if (data.IaseOrSarf == false)
                    {
                        urunKayitDtoSelectForDepos.Add(data);
                    }
                }
            }
            if(checkDepo.Checked==true)
            {
                foreach (var data in _filters.Data)
                {
                    if(data.DepoId!=Convert.ToInt32(cmbDepo.SelectedValue))
                    {
                        urunKayitDtoSelectForDepos.Add(data);
                    }
                }
            }
            return urunKayitDtoSelectForDepos;
        }
        private void UrunleriListele()
        {
            _filters = _urunKayitService.GetUrunKayitDetailsAll();
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
            ToplamTutarAndFaturaOdemeDurum();
        }
        private void ToplamTutarAndFaturaOdemeDurum()
        {
            double toplamTutar = (from DataGridViewRow row in datagridUrunKayit.Rows
                               select Convert.ToDouble(row.Cells["ToplamTutar"].Value.ToString())).Sum();
            string formatted = MoneyConvert.ConvertMoneyFormat(toplamTutar);
            foreach (DataGridViewRow item in datagridUrunKayit.Rows)
            {
                if (item.Cells["Fatura"].Value.ToString() == "Fatura Kesilmiş")
                {
                    item.Cells["Fatura"].Style.SelectionForeColor = Color.Red;
                    item.Cells["Fatura"].Style.ForeColor = Color.IndianRed;
                }
                if (item.Cells["Odeme"].Value.ToString() == "Odeme Yapılmış")
                {
                    item.Cells["Odeme"].Style.SelectionForeColor = Color.Red;
                    item.Cells["Odeme"].Style.ForeColor = Color.IndianRed;
                }
            }
            lblToplamTutar.Text = "Toplam Tutar= "+formatted;
        }
        private List<DtoDepoUrunListeDocument> GetDepoUrunListeSetup()
        {
            datagridUrunKayit.CurrentCell = null;
            List<DtoDepoUrunListeDocument> document = new List<DtoDepoUrunListeDocument>();
            foreach (DataGridViewRow row in datagridUrunKayit.Rows)
            {
                DtoDepoUrunListeDocument depoUrunListe = new DtoDepoUrunListeDocument
                {
                    UrunAdi = row.Cells["UrunAdi"].Value.ToString(),
                    Birim = row.Cells["Birim"].Value.ToString(),
                    BirimFiyat = Convert.ToDouble(row.Cells["BirimFiyat"].Value.ToString()),
                    AlinanMiktar = Convert.ToDouble(row.Cells["AlinanMiktar"].Value.ToString()),
                    KalanMiktar = Convert.ToDouble(row.Cells["KalanMiktar"].Value.ToString()),
                    UrunKayitTarihi = DateTime.Parse(row.Cells["UrunKayitTarihi"].Value.ToString()),
                    TedarikciFirma = row.Cells["TedarikciFirma"].Value.ToString(),
                    Fatura = row.Cells["Fatura"].Value.ToString(),
                    Odeme = row.Cells["Odeme"].Value.ToString(),
                    ToplamTutar = Convert.ToDouble(row.Cells["ToplamTutar"].Value.ToString()),
                };
                document.Add(depoUrunListe);
            }
            return document;
        }
        #endregion
        #region Event
        private void btnUygula_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            UrunleriListele();
            waitForm.Close();
        }
        private void btnDokuman_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            try
            {
                var filePath = new FileInfo(fileName: Application.StartupPath + @"\Documents\DepoUrunListe\DepoUrunListe.xlsx");
                var depoUrunListeDocuments = GetDepoUrunListeSetup();

                DepoUrunListeDocumentCreate.DepoUrunListeDocumentInsert(depoUrunListeDocuments, "A5", "Ürün Kayıt Hareketleri", filePath);
            }
            catch (Exception ex)
            {
                waitForm.Close();
                MessageBox.Show(ex.Message);
            }
            waitForm.Close();
        }

        private void checkTarihlerArasiUrunKayitlari_OnChange(object sender, EventArgs e)
        {
            FiltreControlLocationAndSize();
        }

        private void checkKelime_OnChange(object sender, EventArgs e)
        {
            FiltreControlLocationAndSize();
        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
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

        private void lbliptaledilmisUrun_Click(object sender, EventArgs e)
        {
            if (checkUserDeleted.Checked == true)
                checkUserDeleted.Checked = false;
            else
                checkUserDeleted.Checked = true;
        }
        private void frmUrunKayitHareketleri_Load(object sender, EventArgs e)
        {
            ToplamTutarAndFaturaOdemeDurum();
        }

        private void checkDepo_OnChange(object sender, EventArgs e)
        {
            FiltreControlLocationAndSize();
        }

        private void lblDepo_Click(object sender, EventArgs e)
        {
            if (checkDepo.Checked == true)
                checkDepo.Checked = false;
            else
                checkDepo.Checked = true;
            FiltreControlLocationAndSize();
        }

        private void lblmiktarbitmisUrun_Click(object sender, EventArgs e)
        {
            if (checkProgramDeleted.Checked == true)
                checkProgramDeleted.Checked = false;
            else
                checkProgramDeleted.Checked = true;
        }
        #endregion
    }
}
