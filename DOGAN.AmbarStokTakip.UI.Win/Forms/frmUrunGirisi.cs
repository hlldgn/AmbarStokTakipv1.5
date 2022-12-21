using Bunifu.Framework.UI;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.CommonTools.Converts;
using DOGAN.AmbarStokTakip.CommonTools.Document.Excel.MuayeneKabul;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.UI.Win.WaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmUrunGirisi : Form // Check
    {
        DateTime _alimTarih;
        private readonly IAlimService _alimService;
        private readonly IAlimUrunService _alimUrunService;
        private readonly IUrunKayitService _UrunKayitService;
        private readonly IDepoService _depoService;
        bool tumunuSecFlag = true;
        WaitFormFunc waitForm = new WaitFormFunc();
        public frmUrunGirisi()
        {
            InitializeComponent();
            _alimService = InstanceFactory.GetInstance<IAlimService>();
            _alimUrunService = InstanceFactory.GetInstance<IAlimUrunService>();
            _UrunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            _depoService = InstanceFactory.GetInstance<IDepoService>();
            AlimListele();
            dateUrunKayitTarih.Value = DateTime.Now;
        }
        #region Method
        internal int DepoComboBoxDoldur()
        {
            var result = _depoService.GetDepoDetailsNotDeleted();
            if (result.IsSuccess)
            {
                cmbDepo.DataSource = result.Data;
                cmbDepo.DisplayMember = "DepoAdi";
                cmbDepo.ValueMember = "Id";
            }
            return result.Data.Count;
        }
        private void SumToplamTutar()
        {
            double toplamTutar = (from DataGridViewRow row in datagridUrunKayit.Rows
                                  where (row.Cells["ToplamTutar"].Value != null)
                                  select Convert.ToDouble(row.Cells["ToplamTutar"].Value)).Sum();
            string formatted = MoneyConvert.ConvertMoneyFormat(toplamTutar);
            lblToplamUrun.Text = "Genel Toplam= " + formatted;
        }
        private void AlimIcerikDatagridviewReadOnly()
        {
            foreach (DataGridViewColumn item in datagridAlimicerik.Columns)
            {
                if (item.Name != "sec")
                {
                    item.ReadOnly = true;
                }
            }
        }
        private void TumunuSecOptions(bool value)
        {
            datagridAlimicerik.CurrentCell = null;
            foreach (DataGridViewRow row in datagridAlimicerik.Rows)
            {
                row.Cells["sec"].Value = value;
            }
        }
        private void MuayeneKabulDocument()
        {
            if(checkMuayeneKabul.Checked)
            {
                try
                {
                    var filePath = new FileInfo(fileName: Application.StartupPath + @"\Documents\MuayeneKabul\MuayeneKabulDefault.xlsx");
                    var muayeneKabulDocument = GetMuayeneKabulSetup();
                    MuayeneKabulDocumentCreate.MuayeneKabulDocumentInsert(muayeneKabulDocument, filePath);
                }
                catch (Exception ex)
                {
                    waitForm.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private List<DtoMuayeneKabulListeDocument> GetMuayeneKabulSetup()
        {
            datagridUrunKayit.CurrentCell = null;
            List<DtoMuayeneKabulListeDocument> document = new List<DtoMuayeneKabulListeDocument>();
            foreach (DataGridViewRow row in datagridUrunKayit.Rows)
            {
                long id = long.Parse(row.Cells["Id"].Value.ToString());
                var alimUrun = _alimUrunService.GetAlimUrunMuayeneKabul(id).Data;
                DtoMuayeneKabulListeDocument muayeneKabul = new DtoMuayeneKabulListeDocument
                {
                    Birim=alimUrun.Birim,
                    BirimFiyat=alimUrun.BirimFiyat,
                    BirimFiyatKdvHaric=alimUrun.BirimFiyatKdvHaric,
                    Kdv=alimUrun.Kdv,
                    TedarikciFirma=alimUrun.TedarikciFirma,
                    UrunAdi=alimUrun.UrunAdi,
                    UrunKayitTarihi = DateTime.Parse(dateUrunKayitTarih.Value.ToShortDateString()),
                    Miktar =Convert.ToDecimal(row.Cells["AlinanMiktar"].Value.ToString()),                    
                };
                document.Add(muayeneKabul);
            }
            return document;
        }
        #endregion
        #region List
        internal int AlimListele()
        {
            var result = _alimService.GetAlimDetailsNotDeleted();
            if (result.IsSuccess)
            {
                datagridAlimListesi.DataSource = null;
                datagridAlimListesi.DataSource = result.Data;
                datagridAlimListesi.Columns["Id"].Visible = false;
                datagridAlimListesi.AutoResizeColumns();
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
                AlimIcerikDatagridviewReadOnly();
            }
        }
        #endregion
        #region InsertAndUpdate
        private bool AddUrunKayit(int _id, decimal _alinanMiktar, decimal _toplamTutar)
        {
            var urunKayit = new UrunKayitDtoAdd
            {
                AlimUrunId = _id,
                DepoId = Convert.ToInt32(cmbDepo.SelectedValue.ToString()),
                Miktar = _alinanMiktar,
                MiktarKalan = _alinanMiktar,
                ToplamTutar = _toplamTutar,
                UrunKayitTarihi = DateTime.Parse(dateUrunKayitTarih.Value.ToShortDateString()),
            };
            var result = _UrunKayitService.AddonDto(urunKayit);
            return result.IsSuccess;
        }
        private bool UpdateAlimUrun(int _id, decimal _miktar)
        {
            var entityresult = _alimUrunService.UpdateDeleteForProgram(_id, _miktar);
            return entityresult.IsSuccess;
        }
        private void UpdateAlim(int alimId)
        {
            decimal resultForAlimUrun = _alimUrunService.GetSumAlimUrunMiktarKalan(alimId);
            if (resultForAlimUrun<=0)
            {
                _alimService.UpdateDelete(alimId, true, false);
            }
        }
        #endregion
        #region KeyPress
        private void Miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Event
        private void btnİlerle_Click(object sender, EventArgs e)
        {
            try
            {
                datagridAlimicerik.CurrentCell = null;
                int _row = -1;
                bool urunSecimiKontrol = false;
                for (int i = 0; i < datagridAlimicerik.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(datagridAlimicerik.Rows[i].Cells["sec"].Value) == true)
                    {
                        urunSecimiKontrol = true;
                        datagridUrunKayit.Rows.Add();
                        _row++;
                        datagridUrunKayit.Rows[_row].Cells["Id"].Value = datagridAlimicerik.Rows[i].Cells["Id"].Value;
                        datagridUrunKayit.Rows[_row].Cells["AlimId"].Value = datagridAlimicerik.Rows[i].Cells["AlimId"].Value;
                        datagridUrunKayit.Rows[_row].Cells["UrunAdi"].Value = datagridAlimicerik.Rows[i].Cells["UrunAdi"].Value;
                        datagridUrunKayit.Rows[_row].Cells["Birim"].Value = datagridAlimicerik.Rows[i].Cells["Birim"].Value;
                        datagridUrunKayit.Rows[_row].Cells["BirimFiyat"].Value = datagridAlimicerik.Rows[i].Cells["BirimFiyat"].Value;
                        datagridUrunKayit.Rows[_row].Cells["KalanMiktar"].Value = datagridAlimicerik.Rows[i].Cells["KalanMiktar"].Value;
                    }
                }
                if (urunSecimiKontrol == true)
                {
                    datagridUrunKayit.Columns["Id"].Visible = false;//AlimUrunId
                    datagridUrunKayit.Columns["AlimId"].Visible = false;//AlimId
                    datagridUrunKayit.AutoResizeColumns();
                    int _alimSelectedRow = datagridAlimListesi.SelectedCells[0].RowIndex;
                    _alimTarih = DateTime.Parse(datagridAlimListesi.Rows[_alimSelectedRow].Cells["AlimTarihi"].Value.ToString());
                    tabControl1.SelectedTab = tabPage2;
                }
                else
                {
                    MessageBox.Show("En az bir ürün seçilmesi gerekmektedir.Lütfen en az bir ürün seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
        }
        private void datagridAlimListesi_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridAlimListesi.Rows.Count > 0)
            {
                int _alimId = Convert.ToInt32(datagridAlimListesi.CurrentRow.Cells["Id"].Value.ToString());
                AlimIcerikListele(_alimId);
            }
            else
            {
                datagridAlimicerik.DataSource = null;
            }
        }

        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtAra.Text;
            var result = _alimService.SearchAlimDetailsNotDeleted(search);
            if (result.IsSuccess)
            {
                datagridAlimListesi.DataSource = null;
                datagridAlimListesi.DataSource = result.Data;
                datagridAlimListesi.Columns["Id"].Visible = false;
                datagridAlimListesi.AutoResizeColumns();
            }
        }

        private void datagridUrunKayit_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Miktar_KeyPress);
            if (datagridUrunKayit.CurrentCell.ColumnIndex == 6)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Miktar_KeyPress);
                }
            }
        }

        private void datagridUrunKayit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int _selectedRow = datagridUrunKayit.SelectedCells[0].RowIndex;
            try
            {
                if (datagridUrunKayit.Rows[_selectedRow].Cells["AlinanMiktar"].Value != null)
                {
                    double Miktar = 0;
                    double KalanMiktar = Convert.ToDouble(datagridUrunKayit.Rows[_selectedRow].Cells["KalanMiktar"].Value);
                    double BirimFiyat = Convert.ToDouble(datagridUrunKayit.Rows[_selectedRow].Cells["BirimFiyat"].Value);
                    Miktar = Convert.ToDouble(datagridUrunKayit.Rows[_selectedRow].Cells["AlinanMiktar"].Value.ToString());
                    if (Miktar <= KalanMiktar)
                    {
                        datagridUrunKayit.Rows[_selectedRow].Cells["ToplamTutar"].Value = Miktar * BirimFiyat;
                    }
                    else
                    {
                        datagridUrunKayit.Rows[_selectedRow].Cells["AlinanMiktar"].Value = "";
                        datagridUrunKayit.Rows[_selectedRow].Cells["ToplamTutar"].Value = "";
                        MessageBox.Show("Girilen miktar kalan miktardan büyük olamaz.Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                datagridUrunKayit.Rows[_selectedRow].Cells["AlinanMiktar"].Value = "";
                datagridUrunKayit.Rows[_selectedRow].Cells["ToplamTutar"].Value = "";
                MessageBox.Show("Sütunların hesaplanması sırasında bir hata oluştu. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SumToplamTutar();
        }
        private void btnSonKaydet_Click(object sender, EventArgs e)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    DateTime _urunKayitTarihi = DateTime.Parse(dateUrunKayitTarih.Value.ToString());
                    if (_alimTarih <= _urunKayitTarihi)
                    {
                        bool toplamTutarKontrol = true;
                        for (int i = 0; i < datagridUrunKayit.Rows.Count; i++)
                        {
                            if (datagridUrunKayit.Rows[i].Cells["ToplamTutar"].Value == null)
                            {
                                toplamTutarKontrol = false;
                            }
                        }
                        if (toplamTutarKontrol == true)
                        {
                            int alimId = 0;
                            for (int i = 0; i < datagridUrunKayit.Rows.Count; i++)
                            {
                                int alimUrunId = Convert.ToInt32(datagridUrunKayit.Rows[i].Cells["Id"].Value.ToString());//AlimUrunId
                                alimId = Convert.ToInt32(datagridUrunKayit.Rows[i].Cells["AlimId"].Value.ToString());//AlimId
                                decimal alinanMiktar = Convert.ToDecimal(datagridUrunKayit.Rows[i].Cells["AlinanMiktar"].Value.ToString());
                                decimal toplamtutar = Convert.ToDecimal(datagridUrunKayit.Rows[i].Cells["ToplamTutar"].Value.ToString());
                                UpdateAlimUrun(alimUrunId, alinanMiktar);
                                AddUrunKayit(alimUrunId, alinanMiktar, toplamtutar);
                            }
                            UpdateAlim(alimId);
                            MuayeneKabulDocument();
                            transactionScope.Complete();
                            MessageBox.Show("Alımdan gelen ürünler depoya kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MdiFormsOn frm = (MdiFormsOn)Application.OpenForms["MdiFormsOn"];
                            frm.Reset();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Ürün kayit için gerekli bilgileri eksiksiz doldurup tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ürün kayıt tarihi alım tarihinden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ürün kaydı yapılırken bir sorunla kaşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transactionScope.Dispose();
                }
            }
        }
        private void lblTumunuSec_Click(object sender, EventArgs e)
        {
            if (datagridAlimicerik.Rows.Count > 0)
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
        private void lblMuyaneKabul_Click(object sender, EventArgs e)
        {
            if (checkMuayeneKabul.Checked)
                checkMuayeneKabul.Checked = false;
            else
                checkMuayeneKabul.Checked = true;
        }
        #endregion
    }
}
