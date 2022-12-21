using System;
using System.Windows.Forms;
using DOGAN.AmbarStokTakip.CommonTools.List;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using System.Transactions;
using System.Linq;
using System.Drawing;
using DOGAN.AmbarStokTakip.CommonTools.Converts;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmAlimGirisi : Form // Check
    {
        private bool _urunGrubu = true;
        private readonly IAlimService _alimService;
        private readonly IUrunService _urunService;
        private readonly IAlimUrunService _alimUrunService;
        int currentMouseOverRow = 0;
        public frmAlimGirisi()
        {
            InitializeComponent();
            _alimService = InstanceFactory.GetInstance<IAlimService>();
            _urunService = InstanceFactory.GetInstance<IUrunService>();
            _alimUrunService = InstanceFactory.GetInstance<IAlimUrunService>();
            TumComboboxDoldur();
            UrunleriListele();
            dateAlimTarih.Value = DateTime.Now;
        }
        #region Insert
        private bool AddUrun()
        {
            if (txtKalori.Text == String.Empty)
                txtKalori.Text = "0";
            var urun = new UrunDtoAdd
            {
                UrunAdi = txtUrunAdi.Text,
                Birim = cmbBirim.Text,
                Kalori = Convert.ToDecimal(txtKalori.Text),
                IaseOrSarf = _urunGrubu,
            };
            var result = _urunService.AddonDto(urun);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result.IsSuccess;
        }
        private long AddAlim()
        {
            var alim = new AlimDtoAdd
            {
                AlimAdi = txtAlimAdi.Text,
                AlimTarihi = DateTime.Parse(dateAlimTarih.Value.ToShortDateString()),
                AlimTuru = cmbAlimTuru.Text,
            };
            var result = _alimService.AddonDto(alim);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                return result.Id;
            }
        }
        #endregion
        #region Event
        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            dataGridUrunListe.DataSource = null;
            string ara = txtAra.Text;
            switch (cmbUrunGrubu.SelectedIndex)
            {
                case 0:
                    var urunAdiBirimKalori = _urunService.GetUrunDetailWithKaloriNotDeleted(ara);
                    dataGridUrunListe.DataSource = urunAdiBirimKalori.Data;                   
                    break;
                case 1:
                    var urunAdiBirim = _urunService.GetUrunDetailUrunAdiBirimNotDeleted(ara);
                    dataGridUrunListe.DataSource = urunAdiBirim.Data;
                    break;
            }
            UrunListeDataGridReadOnly();
        }
        private void dataGridUrunListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridUrunListe.Rows.Count > 0)
            {
                bool secimKontrol = false;
                int _selectedRow = Convert.ToInt32(dataGridUrunListe.SelectedCells[0].RowIndex);
                string _urunAdi = dataGridUrunListe.Rows[_selectedRow].Cells["UrunAdi"].Value.ToString();
                string _birim = dataGridUrunListe.Rows[_selectedRow].Cells["Birim"].Value.ToString();
                long _urunId = long.Parse(dataGridUrunListe.Rows[_selectedRow].Cells["Id"].Value.ToString());
                foreach (DataGridViewRow row in datagridSecilenUrunler.Rows)
                {
                    if (row.Cells["UrunId"].Value.ToString() == _urunId.ToString())
                    {
                        secimKontrol = true;
                    }
                }
                if (secimKontrol == false)
                {
                    datagridSecilenUrunler.Rows.Add();
                    int rowCount = datagridSecilenUrunler.Rows.Count - 1;
                    datagridSecilenUrunler.Rows[rowCount].Cells["UrunId"].Value = _urunId;
                    datagridSecilenUrunler.Rows[rowCount].Cells["UrunAdii"].Value = _urunAdi;
                    datagridSecilenUrunler.Rows[rowCount].Cells["Birimm"].Value = _birim;
                    if (datagridSecilenUrunler.Rows.Count > 0)
                    {
                        datagridSecilenUrunler.Visible = true;
                        lblSecilenUrunler.Visible = true;
                        datagridSecilenUrunler.Columns["UrunId"].Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Bu ürün listede zaten var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void datagridSecilenUrunler_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    int _selectedRow = datagridSecilenUrunler.SelectedCells[0].RowIndex;
                    datagridSecilenUrunler.Rows.RemoveAt(_selectedRow);
                    if (datagridSecilenUrunler.Rows.Count <= 0)
                    {
                        datagridSecilenUrunler.Visible = false;
                        lblSecilenUrunler.Visible = false;
                    }
                }
            }
            catch
            {
            }
        }
        private void btnilerle_Click(object sender, EventArgs e)
        {
            if (txtAlimAdi.Text != String.Empty)
            {
                tabControl1.SelectedTab = tabPage2;
                lblUrunKaydetAlım.Text = txtAlimAdi.Text;
            }
            else
            {
                MessageBox.Show("Alim Adinin girilmesi zorunludur. Lütfen ilgili alanı doldurup tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dataGridUrunListe_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = dataGridUrunListe.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    dataGridUrunListe.Rows[currentMouseOverRow].Selected = true;
                    ContextMenu cntxt = new ContextMenu();
                    cntxt.MenuItems.Add(new MenuItem("İptal Et", UruniptalEt));
                    cntxt.Show(dataGridUrunListe, new Point(e.X, e.Y));
                }
            }
        }
        private void cmbUrunGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrunGrubu.SelectedIndex == 0)
            {
                _urunGrubu = true;
                lblKalori.Visible = true;
                txtKalori.Visible = true;
                lblUrunListe.Text = "İaşeye ait ürünlerin listesi :";
            }
            else
            {
                _urunGrubu = false;
                lblKalori.Visible = false;
                txtKalori.Visible = false;
                lblUrunListe.Text = "Sarf malzemelere ait ürünlerin listesi :";
            }
            UrunleriListele();
        }
        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            AddUrun();
            UrunleriListele();
            txtUrunAdi.Text = String.Empty;
            txtKalori.Text = String.Empty;
            LocationAndSize(false);
        }
        private void btnUrunilerle_Click(object sender, EventArgs e)
        {
            int _row = -1;
            bool _urunSecimiFlag = false;
            for (int i = 0; i < datagridSecilenUrunler.Rows.Count; i++)
            {
                if (datagridSecilenUrunler.Rows.Count > 0)
                {
                    _urunSecimiFlag = true;
                    datagridUrunKayit.Rows.Add();
                    _row++;
                    datagridUrunKayit.Rows[_row].Cells["Id"].Value = datagridSecilenUrunler.Rows[i].Cells["UrunId"].Value;
                    datagridUrunKayit.Rows[_row].Cells["UrunAdi"].Value = datagridSecilenUrunler.Rows[i].Cells["UrunAdii"].Value;
                    datagridUrunKayit.Rows[_row].Cells["Birim"].Value = datagridSecilenUrunler.Rows[i].Cells["Birimm"].Value;
                }
            }
            if (_urunSecimiFlag == true)
            {
                datagridUrunKayit.Columns["Id"].Visible = false;
                datagridUrunKayit.AutoResizeColumns();
                tabControl1.SelectedTab = tabPage3;
                txtTedarikciFirma.AutoCompleteCustomSource = TedarikciFirma();
                txtTedarikciFirma.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTedarikciFirma.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            else
            {
                MessageBox.Show("Lütfen En az bir ürün listeye ekleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSonKaydet_Click(object sender, EventArgs e)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    if (ToplamTutarKontrol() == true && txtTedarikciFirma.Text != String.Empty)
                    {
                        long alimId = AddAlim();
                        for (int i = 0; i < datagridUrunKayit.Rows.Count; i++)
                        {
                            var alimurun = new AlimUrunDtoAdd
                            {
                                AlimId = alimId,
                                UrunId = long.Parse(datagridUrunKayit.Rows[i].Cells["Id"].Value.ToString()),
                                BirimFiyatKDVHaric = Convert.ToDecimal(datagridUrunKayit.Rows[i].Cells["BirimFiyatKdvHaric"].Value.ToString()),
                                Kdv = Convert.ToDecimal(datagridUrunKayit.Rows[i].Cells["Kdv"].Value.ToString()),
                                BirimFiyat = Convert.ToDecimal(datagridUrunKayit.Rows[i].Cells["BirimFiyat"].Value.ToString()),
                                Miktar = Convert.ToDecimal(datagridUrunKayit.Rows[i].Cells["Miktar"].Value.ToString()),
                                MiktarKalan = Convert.ToDecimal(datagridUrunKayit.Rows[i].Cells["Miktar"].Value.ToString()),
                                TedarikciFirma = txtTedarikciFirma.Text,
                                ToplamTutar = Convert.ToDecimal(datagridUrunKayit.Rows[i].Cells["ToplamTutar"].Value.ToString()),
                            };
                            var result = _alimUrunService.AddonDto(alimurun);
                        }
                        MessageBox.Show("Alım ve alıma ait ürünler başarı ile kaydedilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        transactionScope.Complete();
                        MdiFormsOn frm = (MdiFormsOn)Application.OpenForms["MdiFormsOn"];
                        frm.Reset();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen alanları eksiksiz doldurunuz ve tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void datagridUrunKayit_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Miktar_KeyPress);
            if (datagridUrunKayit.CurrentCell.ColumnIndex >2)
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
                if (datagridUrunKayit.Rows[_selectedRow].Cells["Miktar"].Value != null && datagridUrunKayit.Rows[_selectedRow].Cells["BirimFiyatKdvHaric"].Value != null
                    && datagridUrunKayit.Rows[_selectedRow].Cells["Kdv"].Value != null)
                {
                    double Miktar = 0;
                    double BirimFiyat = 0;
                    double BirimFiyatKdvHaric = 0;
                    double Kdv = 0;
                    BirimFiyatKdvHaric = Convert.ToDouble(datagridUrunKayit.Rows[_selectedRow].Cells["BirimFiyatKdvHaric"].Value.ToString());
                    Kdv = Convert.ToDouble(datagridUrunKayit.Rows[_selectedRow].Cells["Kdv"].Value.ToString());
                    double KdvDahil = BirimFiyatKdvHaric + (BirimFiyatKdvHaric * Kdv/100);
                    datagridUrunKayit.Rows[_selectedRow].Cells["BirimFiyat"].Value = KdvDahil.ToString();
                    Miktar = Convert.ToDouble(datagridUrunKayit.Rows[_selectedRow].Cells["Miktar"].Value.ToString());
                    BirimFiyat = Convert.ToDouble(datagridUrunKayit.Rows[_selectedRow].Cells["BirimFiyat"].Value.ToString());
                    datagridUrunKayit.Rows[_selectedRow].Cells["ToplamTutar"].Value = Miktar * BirimFiyat;
                }
                else
                {
                    datagridUrunKayit.Rows[_selectedRow].Cells["ToplamTutar"].Value = "0";
                }
            }
            catch
            {
                datagridUrunKayit.Rows[_selectedRow].Cells["Miktar"].Value = "0";
                datagridUrunKayit.Rows[_selectedRow].Cells["BirimFiyat"].Value = "0";
                datagridUrunKayit.Rows[_selectedRow].Cells["ToplamTutar"].Value = "0";
                datagridUrunKayit.Rows[_selectedRow].Cells["BirimFiyatKdvHaric"].Value = "0";
                datagridUrunKayit.Rows[_selectedRow].Cells["Kdv"].Value = 0;
                MessageBox.Show("Sütunların hesaplanması sırasında bir hata oluştu lütfen yeniden deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SumToplamTutar();
        }
        private void lblYeniUrunTanımlama_Click(object sender, EventArgs e)
        {
            LocationAndSize(true);
        }
        #endregion
        #region KeyPress
        private void txtUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void txtKalori_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
        private void Miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region List
        private void TumComboboxDoldur()
        {
            foreach (var item in AlimTurCombobox.alimTur)
            {
                cmbAlimTuru.Items.Add(item);
            }
            foreach (var item in UrunGrubuCombobox.urunGrubu)
            {
                cmbUrunGrubu.Items.Add(item);
            }
            foreach (var item in UrunGrubuCombobox.birim)
            {
                cmbBirim.Items.Add(item);
            }
            cmbUrunGrubu.SelectedIndex = 0;
            cmbBirim.SelectedIndex = 0;
            cmbAlimTuru.SelectedIndex = 0;
        }
        private void UrunListeDataGridReadOnly()
        {
            if (dataGridUrunListe.Rows.Count <= 0)
            {
                lblUrunListe.Visible = false;
                dataGridUrunListe.Visible = false;
            }
            else
            {
                dataGridUrunListe.Columns["Id"].Visible = false;
                dataGridUrunListe.AutoResizeColumns();
                dataGridUrunListe.Visible = true;
                lblUrunListe.Visible = true;
            }
        }
        private void UrunleriListele()
        {
            dataGridUrunListe.DataSource = null;
            switch (cmbUrunGrubu.SelectedIndex)
            {
                case 0:
                    var urunAdiBirimKalori = _urunService.GetUrunDetailWithKaloriNotDeleted();
                    dataGridUrunListe.DataSource = urunAdiBirimKalori.Data;
                    break;
                case 1:
                    var urunAdiBirim = _urunService.GetUrunDetailUrunAdiBirimNotDeleted();
                    dataGridUrunListe.DataSource = urunAdiBirim.Data;
                    break;
            }
            UrunListeDataGridReadOnly();
        }
        #endregion
        #region Method
        private void SumToplamTutar()
        {
            try
            {
                double toplamTutar = (from DataGridViewRow row in datagridUrunKayit.Rows
                                      where (row.Cells["ToplamTutar"].Value != null)
                                      select Convert.ToDouble(row.Cells["ToplamTutar"].Value)).Sum();
                string formatToplamTutar = MoneyConvert.ConvertMoneyFormat(toplamTutar);
                lblToplamAlim.Text = "Genel Toplam= " + formatToplamTutar;
            }
            catch
            {
            }
        }
        private AutoCompleteStringCollection TedarikciFirma()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            var result = _alimUrunService.GetAlimUrunDetailsByTedarikciFirma();
            foreach (var item in result.Data)
            {
                collection.Add(item.TedarikciFirma.ToString());
            }
            return collection;
        }
        private bool ToplamTutarKontrol()
        {
            bool toplamtutarkontrol = true;
            foreach (DataGridViewRow row in datagridUrunKayit.Rows)
            {
                if (row.Cells["ToplamTutar"].Value == null || Convert.ToDouble(row.Cells["ToplamTutar"].Value.ToString()) <= 0)
                    toplamtutarkontrol = false;
            }
            return toplamtutarkontrol;
        }
        private void UruniptalEt(object sender, EventArgs e)
        {
            string urunAdi = dataGridUrunListe.Rows[currentMouseOverRow].Cells["UrunAdi"].Value.ToString();
            DialogResult cevap = MessageBox.Show(urunAdi + " Adlı ürüne ait bilgiler iptal edilecek onaylıyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                long Id = long.Parse(dataGridUrunListe.Rows[currentMouseOverRow].Cells["Id"].Value.ToString());
                var result = _urunService.UpdateDeleteForUser(Id);
                if (!result.IsSuccess)
                {
                    MessageBox.Show(result.Message);
                }
                UrunleriListele();
            }
        }
        private void LocationAndSize(bool durum)
        {
            if (durum == false)
            {
                pnlYeniUrun.Size = new Size(267, 10);
                lblYeniUrunTanımlama.Visible = true;

            }
            else
            {
                pnlYeniUrun.Size = new Size(267, 208);
                lblYeniUrunTanımlama.Visible = false;
            }
            Point yeniUrun = pnlYeniUrun.Location + pnlYeniUrun.Size;
            dataGridUrunListe.Location = new Point(18, yeniUrun.Y + 40);
            lblUrunListe.Location = new Point(18, yeniUrun.Y + 24);
            txtAra.Location = new Point(txtAra.Location.X, yeniUrun.Y + 4);
            Point urunListe = dataGridUrunListe.Location + dataGridUrunListe.Size;
            lblSecilenUrunler.Location = new Point(18, urunListe.Y + 20);
            datagridSecilenUrunler.Location = new Point(18, urunListe.Y + 36);
            datagridSecilenUrunler.Size = new Size(datagridSecilenUrunler.Size.Width, btnUrunilerle.Location.Y - 15 - datagridSecilenUrunler.Location.Y);
        }
        #endregion
    }
}

