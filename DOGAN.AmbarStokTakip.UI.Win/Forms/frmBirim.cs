using Bunifu.Framework.UI;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmBirim : Form // Check
    {
        private readonly IBirimService _birimService;
        public frmBirim()
        {
            InitializeComponent();
            _birimService = InstanceFactory.GetInstance<IBirimService>();
            BirimListele();
        }
        #region Insert
        private bool AddBirim()
        {
            var birim = new BirimDtoAdd
            {
                BirimAdi = txtBirimAdi.Text,
            };
            var result = _birimService.AddonDto(birim);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result.IsSuccess;
        }
        private void UpdateBirim(int _id, string birimAdi)
        {
            DialogResult result = MessageBox.Show(birimAdi + " adlı birimi silmek istediğinize eminmisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var entityresult = _birimService.UpdateDeleteForUser(_id);
                if (!entityresult.IsSuccess)
                {
                    MessageBox.Show(entityresult.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region KeyPress
        private void txtBirimAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
        private void txtBirimAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBirimKaydet_Click(sender, e);
            }
        }
        #endregion
        #region List
        private void BirimListele()
        {
            var result = _birimService.GetBirimDetailsNotDeleted();
            if (result.IsSuccess)
            {
                if (result.Data.Count > 0)
                {
                    datagridBirimListe.DataSource = null;
                    datagridBirimListe.DataSource = result.Data;
                    datagridBirimListe.Columns["Id"].Visible = false;
                    datagridBirimListe.AutoResizeColumns();
                    lblBirimListesi.Visible = true;
                    datagridBirimListe.Visible = true;
                    picDelete.Visible = true;
                }
                else
                {
                    lblBirimListesi.Visible = false;
                    datagridBirimListe.Visible = false;
                    picDelete.Visible = false;
                }
            }
        }
        #endregion
        #region Event
        private void btnBirimKaydet_Click(object sender, EventArgs e)
        {
            AddBirim();
            BirimListele();
            TxtClear();
        }

        private void picDelete_Click_1(object sender, EventArgs e)
        {
            int _selectedRow = datagridBirimListe.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(datagridBirimListe.Rows[_selectedRow].Cells["Id"].Value.ToString());
            string birimAdi = datagridBirimListe.Rows[_selectedRow].Cells["BirimAdi"].Value.ToString();
            UpdateBirim(id, birimAdi);
            BirimListele();
        }
        #endregion
        #region Method
        private void TxtClear()
        {
            foreach (Control item in this.Controls)
            {
                if (item is BunifuMetroTextbox)
                    item.Text = String.Empty;
            }
        }
        #endregion
    }
}

