using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmTabela : Form
    {
        private readonly ITabelaService _tabelaService;
        private readonly IYemekService _yemekService;
        public frmTabela()
        {
            InitializeComponent();
            _tabelaService = InstanceFactory.GetInstance<ITabelaService>();
            _yemekService = InstanceFactory.GetInstance<IYemekService>();
            dateTabelaTarih.Value = DateTime.Parse(DateTime.Now.ToShortDateString());
            Listele();
        }
        #region Method
        private void TxtClear()
        {
            datagridAksamYemekAdi.Rows.Clear();
            datagridOgleYemekAdi.Rows.Clear();
            datagridSabahYemekAdi.Rows.Clear();
        }
        private AutoCompleteStringCollection YemekList()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            var result = _yemekService.GetYemekDetails();
            foreach (var item in result.Data)
            {
                collection.Add(item.YemekAdi.ToString());
            }
            return collection;
        }
        private void ControlVisible(bool deger)
        {
            datagridTabelaListe.Visible = deger;
            lblTabelaListesi.Visible = deger;
        }
        private void OgunsDatagridview_Editing(DataGridView dataGridView, object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(YemekAdi_KeyPress);
            if (dataGridView.CurrentCell.ColumnIndex == 0)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.AutoCompleteCustomSource = YemekList();
                    tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tb.KeyPress += new KeyPressEventHandler(YemekAdi_KeyPress);
                }
            }
        }
        #endregion
        #region List
        private void Listele()
        {
            DateTime _tarih = DateTime.Parse(dateTabelaTarih.Value.ToShortDateString());
            var result = _tabelaService.GetTabelaDetailsTarihNotDeleted(_tarih);
            if (result.IsSuccess)
            {
                datagridTabelaListe.DataSource = null;
                datagridTabelaListe.DataSource = result.Data;
                datagridTabelaListe.Columns["Id"].Visible = false;
                datagridTabelaListe.AutoResizeColumns();

            }
            if (result.Data.Count > 0)
            {
                ControlVisible(true);
            }
            else
            {
                ControlVisible(false);
            }
        }
        #endregion
        #region InsertAndUpdate
        private bool AddTabela()
        {
            DateTime _tarih = DateTime.Parse(dateTabelaTarih.Value.ToShortDateString());
            var ayniTarihKayitKontrol = _tabelaService.AyniTarihTabelaKayitKontrol(_tarih);
            if (ayniTarihKayitKontrol.IsSuccess)
            {
                datagridSabahYemekAdi.ReadOnly = true;
                datagridOgleYemekAdi.ReadOnly = true;
                datagridAksamYemekAdi.ReadOnly = true;
                string _sabah = "";
                string _ogle = "";
                string _aksam = "";
                foreach (DataGridViewRow sabahYemekadi in datagridSabahYemekAdi.Rows)
                {
                    if (sabahYemekadi.Cells["SabahYemekAdi"].Value != null)
                    {
                        YemekEkle(sabahYemekadi.Cells["SabahYemekAdi"].Value.ToString());
                        _sabah += sabahYemekadi.Cells["SabahYemekAdi"].Value.ToString() + ",";
                    }
                }
                foreach (DataGridViewRow ogleYemekAdi in datagridOgleYemekAdi.Rows)
                {
                    if (ogleYemekAdi.Cells["OgleYemekAdi"].Value != null)
                    {
                        YemekEkle(ogleYemekAdi.Cells["OgleYemekAdi"].Value.ToString());
                        _ogle += ogleYemekAdi.Cells["OgleYemekAdi"].Value.ToString() + ",";
                    }
                }
                foreach (DataGridViewRow aksamYemekAdi in datagridAksamYemekAdi.Rows)
                {
                    if (aksamYemekAdi.Cells["AksamYemekAdi"].Value != null)
                    {
                        YemekEkle(aksamYemekAdi.Cells["AksamYemekAdi"].Value.ToString());
                        _aksam += aksamYemekAdi.Cells["AksamYemekAdi"].Value.ToString() + ",";
                    }
                }
                var tabela = new TabelaDtoAdd
                {
                    Sabah = _sabah.Remove(_sabah.Length - 1, 1) + "",
                    Ogle = _ogle.Remove(_ogle.Length - 1, 1) + "",
                    Aksam = _aksam.Remove(_aksam.Length - 1, 1) + "",
                    TabelaTarihi = _tarih,
                };
                var result = _tabelaService.AddonDto(tabela);
                datagridSabahYemekAdi.ReadOnly = false;
                datagridOgleYemekAdi.ReadOnly = false;
                datagridAksamYemekAdi.ReadOnly = false;
                if (!result.IsSuccess)
                {
                    MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return result.IsSuccess;
            }
            else
            {
                MessageBox.Show(ayniTarihKayitKontrol.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ayniTarihKayitKontrol.IsSuccess;
            }
        }
        private bool YemekEkle(string yemekAdi)
        {

            var yemek = new YemekDtoAdd
            {
                YemekAdi = yemekAdi,
            };
            var result = _yemekService.AddonDto(yemek);
            return result.IsSuccess;
        }
        #endregion
        #region Event
        private void dateTabelaTarih_onValueChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void datagridSabahYemekAdi_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            OgunsDatagridview_Editing(datagridSabahYemekAdi, sender, e);
        }

        private void datagridOgleYemekAdi_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            OgunsDatagridview_Editing(datagridOgleYemekAdi, sender, e);
        }
        private void datagridAksamYemekAdi_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            OgunsDatagridview_Editing(datagridAksamYemekAdi, sender, e);
        }
        private void btnTabelaKaydet_Click(object sender, EventArgs e)
        {
            AddTabela();
            Listele();
            TxtClear();
        }
        #endregion
        #region KeyPress
        private void richSabah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void richOgle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void richAksam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
        private void YemekAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
        #endregion
    }
}
