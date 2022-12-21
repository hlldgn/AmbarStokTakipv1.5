using Bunifu.Framework.UI;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using System;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmDepo : Form //Check
    {
        private readonly IDepoService _depoService;
        public frmDepo()
        {            
            InitializeComponent();
            _depoService=InstanceFactory.GetInstance<IDepoService>();
            Listele();
        }
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
        #region InsertAndUpdate
        private bool AddDepo()
        {
            var depo = new DepoDtoAdd
            {
                DepoAdi = txtDepoAdi.Text,
            };
            var result = _depoService.AddonDto(depo);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result.IsSuccess;
        }
        private void DeleteDepo(int _id, string depoAdi)
        {
            DialogResult result = MessageBox.Show(depoAdi + " adlı depoyu silmek istediğinize eminmisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var entityresult = _depoService.UpdateDeleteForUser(_id);
                if (!entityresult.IsSuccess)
                {
                    MessageBox.Show(entityresult.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region KeyPress
        private void txtDepoAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void txtDepoAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDepoKaydet_Click(sender, e);
            }
        }
        #endregion
        #region List
        private void Listele()
        {
            var result = _depoService.GetDepoDetailsNotDeleted();
            if (result.IsSuccess)
            {
                datagridDepoListe.DataSource = result.Data;
                datagridDepoListe.Columns["Id"].Visible = false;
                datagridDepoListe.AutoResizeColumns();
            }
            if (result.Data.Count > 0)
            {
                datagridDepoListe.Visible = true;
                lblDepoListesi.Visible = true;
                picDelete.Visible = true;
            }
            else
            {
                datagridDepoListe.Visible = false;
                lblDepoListesi.Visible = false;
                picDelete.Visible = false;
            }
        }
        #endregion
        #region Event
        private void btnDepoKaydet_Click(object sender, EventArgs e)
        {
            AddDepo();
            Listele();
            TxtClear();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            int _selectedRow = datagridDepoListe.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(datagridDepoListe.Rows[_selectedRow].Cells["Id"].Value.ToString());
            string depoAdi = datagridDepoListe.Rows[_selectedRow].Cells["DepoAdi"].Value.ToString();
            DeleteDepo(id, depoAdi);
            Listele();
        }
        #endregion
    }
}
