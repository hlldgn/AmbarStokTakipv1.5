using Bunifu.Framework.UI;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms // Check
{
    public partial class frmPersonel : Form
    {
        private readonly IBirimService _birimService;
        private readonly IPersonelService _personelService;
        public frmPersonel()
        {
            InitializeComponent();
            _birimService = InstanceFactory.GetInstance<IBirimService>();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            ComboboxDoldur();
            Listele();
        }
        #region Method
        private void TxtClear()
        {
            foreach (Control item in this.Controls)
            {
                if (item is BunifuMetroTextbox)
                    item.Text = "";
            }
        }
        internal int ComboboxDoldur()
        {
            var result = _birimService.GetBirimDetailsNotDeleted();
            if (result.IsSuccess)
            {
                cmbBirimler.DataSource = result.Data;
                cmbBirimler.DisplayMember = "BirimAdi";
                cmbBirimler.ValueMember = "Id";
            }
            return result.Data.Count;
        }
        private void ControlVisible(bool deger)
        {
            datagridPersonelListe.Visible= deger;
            lblPersonelListesi.Visible= deger;
            picDelete.Visible= deger;
        }
        #endregion
        #region InsertAndUpdate
        private void DeletePersonel(int _id, string personelAdSoyad)
        {
            DialogResult result = MessageBox.Show(personelAdSoyad + " adlı personeli silmek istediğinize eminmisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var entityresult = _personelService.UpdateDeleteForUser(_id);
                if (!entityresult.IsSuccess)
                {
                    MessageBox.Show(entityresult.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool AddPersonel()
        {
            var personel = new PersonelDtoAdd
            {
                PersonelAdi = txtPersonelAdi.Text,
                PersonelSoyadi = txtPersonelSoyadi.Text,
                PersonelUnvani = txtPersonelUnvan.Text,
                PersonelSicili = txtPersonelSicil.Text,
                BirimId = Convert.ToInt32(cmbBirimler.SelectedValue.ToString()),
            };
            var result = _personelService.AddonDto(personel);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result.IsSuccess;
        }
        #endregion
        #region List
        private void Listele()
        {
            var result = _personelService.GetPersonelDetailsNotDeleted();
            if (result.IsSuccess)
            {
                datagridPersonelListe.DataSource = null;
                datagridPersonelListe.DataSource = result.Data;
                datagridPersonelListe.Columns["Id"].Visible = false;
                datagridPersonelListe.Columns["PersonelAdPersonelSoyad"].Visible=false;
                datagridPersonelListe.AutoResizeColumns();
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
        #region Event
        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            AddPersonel();
            Listele();
            TxtClear();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            int _selectedRow = datagridPersonelListe.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(datagridPersonelListe.Rows[_selectedRow].Cells["Id"].Value.ToString());
            string personelAdSoyad = datagridPersonelListe.Rows[_selectedRow].Cells["PersonelAdi"].Value.ToString()
                + " " + datagridPersonelListe.Rows[_selectedRow].Cells["PersonelSoyadi"].Value.ToString();
            DeletePersonel(id, personelAdSoyad);
            Listele();
        }
        #endregion
        #region KeyPress
        private void txtPersonelSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
        #endregion
    }
}
