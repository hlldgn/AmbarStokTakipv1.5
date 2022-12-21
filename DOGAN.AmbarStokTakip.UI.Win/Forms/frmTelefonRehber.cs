using Bunifu.Framework.UI;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
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
    public partial class frmTelefonRehber : Form // Check
    {
        private readonly ITelefonRehberService _telefonRehberService;
        public frmTelefonRehber()
        {
            InitializeComponent();
            _telefonRehberService = InstanceFactory.GetInstance<ITelefonRehberService>();
            Listele();
        }
        #region Method
        private void DataGridKontrol()
        {
            if(datagridTelefonRehberListe.Rows.Count<=0)
            {
                datagridTelefonRehberListe.Visible = false;
                lblTelefonListesi.Visible = false;
            }
            else
            {
                datagridTelefonRehberListe.Visible = true;
                lblTelefonListesi.Visible = true;
            }
        }
        private bool RehberAdd()
        {
            var rehber = new TelefonRehberDtoAdd
            {
                Adres = txtAdres.Text,
                EPosta = txtEPosta.Text,
                Fax = txtFax.Text,
                IlgiliKisiAdSoyad = txtAdSoyad.Text,
                IsletmeAdi = txtIsletmeAdi.Text,
                TelefonNo = txtTelefonNo.Text,
                TelefonNo2=txtTelefonNo2.Text,
                VergiTCNo = txtVergiTC.Text,
            };
            return _telefonRehberService.AddOnDto(rehber).IsSuccess;
        }
        private void TxtClear()
        {
            foreach (Control item in this.Controls)
            {
                if (item is BunifuMetroTextbox)
                    item.Text = String.Empty;
            }
            txtAdres.Text = String.Empty;
        }
        private void TextBoxMaxLenght(Bunifu.Framework.UI.BunifuMetroTextbox sender, KeyPressEventArgs e, int maxLenght)
        {
            if (sender.Text.Length > maxLenght)
            {
                e.Handled = !char.IsControl(e.KeyChar);
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
            }
        }
        internal void Listele()
        {
            datagridTelefonRehberListe.DataSource = null;
            datagridTelefonRehberListe.DataSource = _telefonRehberService.GetTelefonRehberNotDeleted().Data;
            datagridTelefonRehberListe.Columns["Id"].Visible = false;
            datagridTelefonRehberListe.AutoResizeColumns();
            DataGridKontrol();
        }
        #endregion
        #region KeyPress
        private void txtTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMaxLenght(txtTelefonNo, e, 10);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMaxLenght(txtFax, e, 10);
        }

        private void txtEPosta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToLower().ToCharArray()[0];
        }

        private void txtVergiTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMaxLenght(txtVergiTC, e, 10);
        }
        private void txtTelefonNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMaxLenght(txtTelefonNo2, e, 10);
        }
        #endregion
        #region Event
        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            datagridTelefonRehberListe.DataSource = null;
            datagridTelefonRehberListe.DataSource = _telefonRehberService.SearchTelefonRehberNotDeleted(ara).Data;
            datagridTelefonRehberListe.Columns["Id"].Visible = false;
            datagridTelefonRehberListe.AutoResizeColumns();
        }
        private void datagridTelefonRehberListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _selectedRow = datagridTelefonRehberListe.SelectedCells[0].RowIndex;
            frmTelefonRehberDuzenle frm = new frmTelefonRehberDuzenle();
            frmTelefonRehberDuzenle.Id = long.Parse(datagridTelefonRehberListe.Rows[_selectedRow].Cells["Id"].Value.ToString());
            frmTelefonRehberDuzenle.fax = datagridTelefonRehberListe.Rows[_selectedRow].Cells["Fax"].Value.ToString();
            frmTelefonRehberDuzenle.isletmeAdi = datagridTelefonRehberListe.Rows[_selectedRow].Cells["IsletmeAdi"].Value.ToString();
            frmTelefonRehberDuzenle.adSoyad = datagridTelefonRehberListe.Rows[_selectedRow].Cells["IlgiliKisiAdSoyad"].Value.ToString();
            frmTelefonRehberDuzenle.telefon = datagridTelefonRehberListe.Rows[_selectedRow].Cells["TelefonNo"].Value.ToString();
            frmTelefonRehberDuzenle.telefonNo2 = datagridTelefonRehberListe.Rows[_selectedRow].Cells["TelefonNo2"].Value.ToString();
            frmTelefonRehberDuzenle.ePosta = datagridTelefonRehberListe.Rows[_selectedRow].Cells["EPosta"].Value.ToString();
            frmTelefonRehberDuzenle.vergiTC = datagridTelefonRehberListe.Rows[_selectedRow].Cells["VergiTCNo"].Value.ToString();
            frmTelefonRehberDuzenle.adres = datagridTelefonRehberListe.Rows[_selectedRow].Cells["Adres"].Value.ToString();
            frm.ShowDialog();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (RehberAdd()) { Listele(); TxtClear(); }
            else
            {
                MessageBox.Show("Rehber eklenirken bir sorunla karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
