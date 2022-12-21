using Bunifu.Framework.UI;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmOtomatikiaseCikis : Form // Check
    {
        private readonly IUrunService _urunService;
        private readonly IOtomatikCikisService _otomatikCikisService;
        public frmOtomatikiaseCikis()
        {
            InitializeComponent();
            _urunService = InstanceFactory.GetInstance<IUrunService>();
            _otomatikCikisService = InstanceFactory.GetInstance<IOtomatikCikisService>();
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
            var result = _urunService.GetUrunDetailWithKaloriNotDeleted();
            if (result.IsSuccess)
            {
                cmbUrunler.DataSource = result.Data;
                cmbUrunler.DisplayMember = "UrunAdi";
                cmbUrunler.ValueMember = "Id";
            }
            return result.Data.Count;
        }
        private void ControlVisible(bool deger)
        {
            picDelete.Visible = deger;
            datagridOtomatikCikisListe.Visible = deger;
            lbliaseYapilandirmaListesi.Visible = deger;
        }
        private void SetTextBoxText()
        {
            foreach (Control item in this.Controls)
            {
                if (item is BunifuMetroTextbox && item.Text.Length <= 0)
                {
                    item.Text = "0";
                }
            }
        }
        #endregion
        #region List
        private void Listele()
        {
            var result = _otomatikCikisService.GetSelectOtomatikCikisDetailsNotDeleted();
            if (result.IsSuccess)
            {
                datagridOtomatikCikisListe.DataSource = null;
                datagridOtomatikCikisListe.DataSource = result.Data;
                datagridOtomatikCikisListe.Columns["Id"].Visible = false;
                datagridOtomatikCikisListe.AutoResizeColumns();

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
        private void DeleteOtomatikCikis(int _id, string urunAdi)
        {
            DialogResult result = MessageBox.Show(urunAdi + " isimli ürüne ait otomatik çıkış bilgilerini silmek istediğinize eminmisiniz?", "Dikkat",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var entityresult = _otomatikCikisService.UpdateDeleteForUser(_id);
                if (!entityresult.IsSuccess)
                {
                    MessageBox.Show(entityresult.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool AddOtomatikCikis()
        {
            SetTextBoxText();
            if (cmbUrunler.Items.Count > 0)
            {
                int urunId = Convert.ToInt32(cmbUrunler.SelectedValue.ToString());
                var urunIdAyniKayitResult = _otomatikCikisService.GetAyniIsimliUrunKaydiKontrol(urunId);
                if (urunIdAyniKayitResult.IsSuccess)
                {
                    var otomatikCikis = new OtomatikCikisDtoAdd
                    {
                        UrunId = urunId,
                        sabahCikis = Convert.ToDecimal(txtSabah.Text),
                        ogleCikis = Convert.ToDecimal(txtogle.Text),
                        aksamCikis = Convert.ToDecimal(txtAksam.Text),
                        secim = checkBanaBirak.Checked == true ? false : true,
                    };
                    var result = _otomatikCikisService.AddonDTo(otomatikCikis);
                    return result.IsSuccess;
                }
                else
                {
                    MessageBox.Show(urunIdAyniKayitResult.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return urunIdAyniKayitResult.IsSuccess;
                }
            }
            else
            {
                MessageBox.Show("Otomatik çıkış kaydı oluşturmak için öncelikle bir ürün listesine sahip olmanız gerekir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
        #region KeyPress
        private void txtSabah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txtogle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txtAksam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
        #endregion
        #region Event
        private void checkHeriase_OnChange(object sender, EventArgs e)
        {
            if (checkHeriase.Checked == true)
            {
                checkBanaBirak.Checked = false;
            }
        }

        private void checkBanaBirak_OnChange(object sender, EventArgs e)
        {
            if (checkBanaBirak.Checked == true)
            {
                checkHeriase.Checked = false;
            }
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            if (checkHeriase.Checked == false)
            {
                checkBanaBirak.Checked = false;
                checkHeriase.Checked = true;
            }
        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {
            if (checkBanaBirak.Checked == false)
            {
                checkHeriase.Checked = false;
                checkBanaBirak.Checked = true;
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (AddOtomatikCikis() == true)
            {
                Listele();
                TxtClear();
            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            int _selectedRow = datagridOtomatikCikisListe.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(datagridOtomatikCikisListe.Rows[_selectedRow].Cells["Id"].Value.ToString());
            string urunAdi = datagridOtomatikCikisListe.Rows[_selectedRow].Cells["UrunAdi"].Value.ToString();
            DeleteOtomatikCikis(id, urunAdi);
            Listele();
        }
        #endregion
    }
}
