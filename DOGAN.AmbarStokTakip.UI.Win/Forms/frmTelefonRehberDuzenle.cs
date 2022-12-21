using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
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
    public partial class frmTelefonRehberDuzenle : Form // Check
    {
        private readonly ITelefonRehberService _telefonRehberService;
        internal static long Id;
        internal static string isletmeAdi;
        internal static string adSoyad;
        internal static string telefon;
        internal static string telefonNo2;
        internal static string fax;
        internal static string ePosta;
        internal static string vergiTC;
        internal static string adres;
        public frmTelefonRehberDuzenle()
        {
            InitializeComponent();
            _telefonRehberService = InstanceFactory.GetInstance<ITelefonRehberService>();
        }
        #region Insert
        private bool Duzenle()
        {
            if (DialogResult.Yes == MessageBox.Show(isletmeAdi + " Adlı rehber bilgisini değiştirmek istediğinize eminmisiniz?", "Uyarı",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                var rehber = new TelefonRehberDtoSelect
                {
                    Id = Id,
                    Adres = txtAdres.Text,
                    EPosta = txtEPosta.Text,
                    Fax = txtFax.Text,
                    IlgiliKisiAdSoyad = txtAdSoyad.Text,
                    IsletmeAdi = txtIsletmeAdi.Text,
                    TelefonNo = txtTelefon.Text,
                    TelefonNo2=txtTelefonNo2.Text,
                    VergiTCNo = txtVergiTC.Text,
                };
                return _telefonRehberService.UpdateForUser(rehber).IsSuccess;
            }
            else
            {
                return true;
            }
        }
        private bool Sil()
        {
            if (DialogResult.Yes == MessageBox.Show(isletmeAdi + " Adlı rehber bilgisini silmek istediğinize eminmisiniz?", "Uyarı",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                return _telefonRehberService.UpdateDeleteForUser(Id).IsSuccess;
            }
            else
            {
                return true;
            }

        }
        #endregion
        #region KeyPress
        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMaxLenght(txtTelefon, e, 10);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMaxLenght(txtFax, e, 10);
        }

        private void txtVergiTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMaxLenght(txtVergiTC, e, 10);
        }

        private void txtEPosta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToLower().ToCharArray()[0];
        }
        #endregion
        #region Method
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
        #endregion
        #region Event
        private void frmTelefonRehberDuzenle_Load(object sender, EventArgs e)
        {
            txtAdres.Text = adres;
            txtAdSoyad.Text = adSoyad;
            txtEPosta.Text = ePosta;
            txtFax.Text = fax;
            txtIsletmeAdi.Text = isletmeAdi;
            txtTelefon.Text = telefon;
            txtVergiTC.Text = vergiTC;
            txtTelefonNo2.Text = telefonNo2;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (!Duzenle())
            {
                MessageBox.Show("İlgili rehber kaydı düzenlenirken bir sorunla karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                frmTelefonRehber frm = (frmTelefonRehber)Application.OpenForms["frmTelefonRehber"];
                frm.Listele();
                this.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!Sil())
            {
                MessageBox.Show("İlgili rehber kaydı silinirken bir sorunla karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                frmTelefonRehber frm = (frmTelefonRehber)Application.OpenForms["frmTelefonRehber"];
                frm.Listele();
                this.Close();
            }
        }
        #endregion
    }
}
