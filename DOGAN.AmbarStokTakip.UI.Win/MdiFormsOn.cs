using DOGAN.AmbarStokTakip.CommonTools.ColorFunctions;
using DOGAN.AmbarStokTakip.UI.Win.Forms;
using DOGAN.AmbarStokTakip.UI.Win.WaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win
{
    public partial class MdiFormsOn : Form // Check
    {
        private Button _currentButton;
        private Random _random;
        private int _tempIndex;
        private Form _activeForm;
        public MdiFormsOn()
        {
            InitializeComponent();
            _random = new Random();
            btnExit.Visible = false;
            ApplicationFirstRun();
        }

        WaitFormFunc waitForm = new WaitFormFunc();
        #region Method
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {            
            int index = _random.Next(ThemeColor.ColorList.Count);
            while (_tempIndex == index)
            {
                index = _random.Next(ThemeColor.ColorList.Count);
            }
            _tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                Color color = SelectThemeColor();
                pnlTopBar.BackColor = color;
                pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                btnExit.Visible = true;
                if (btnSender.GetType() == typeof(Button) && _currentButton != (Button)btnSender)
                {
                    DisableButton();
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = color;
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
                else
                {
                    DisableButton();
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previusBtn in pnlSideBar.Controls)
            {
                if (previusBtn.GetType() == typeof(Button))
                {
                    previusBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previusBtn.ForeColor = Color.White;
                    previusBtn.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
            foreach (Control previusBtn in pnlDesktop.Controls)
            {
                if (previusBtn.GetType() == typeof(Button))
                {
                    previusBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previusBtn.ForeColor = Color.White;
                    previusBtn.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }
        public void Reset()
        {
            DisableButton();
            lblPnlTopBar.Text = "Ana Sayfa";
            pnlTopBar.BackColor = Color.FromArgb(0, 150, 136);
            pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
            _currentButton = null;
            btnExit.Visible = false;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            ActiveButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblPnlTopBar.Text = childForm.Text;
        }
        private void ApplicationFirstRun()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string firstRun = config.AppSettings.Settings["FirstRun"].Value.ToString();
            if(firstRun=="0")
            {
                lblFirstRun.Visible = true;
                btnOkudum.Visible = true;
                pnlSideBar.Enabled = false;
                menuStrip1.Enabled = false;
            }
        }

        #endregion
        #region Event
        private void btnSarfCikis_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            frmCikisSarf frm = new frmCikisSarf();
            if (frm.ComboBoxDoldur() > 0||frm.DepoUrunListele()>0)
            {
                waitForm.Close();
                OpenChildForm(frm, sender);
            }
            else
            {
                waitForm.Close();
                MessageBox.Show("Sarf Malzeme Çıkışı yapabilmeniz için en az bir personel ve ürün eklenemeniz gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sarfMalzemeKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show();
            OpenChildForm(new frmDokumanSarfKayit(), sender);
            waitForm.Close();
        }
        private void ürünKayıtHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            OpenChildForm(new frmUrunKayitHareketleri(), sender);
            waitForm.Close();
        }
        private void veriYedeklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYedekle frm = new frmYedekle();
            frm.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            OpenChildForm(new frmAlimGirisi(), sender);
            waitForm.Close();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTarihSaat.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
        private void pictureLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHakkinda(), sender);
        }

        private void faturaVeÖdemeListeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            OpenChildForm(new frmFaturaVeOdemeKayitlari(), sender);
            waitForm.Close();
        }
        private void alımHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            OpenChildForm(new frmAlimHareketleri(), sender);
            waitForm.Close();
        }
        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHakkinda(), sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            Reset();
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimazeScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUrunKayit_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            frmUrunGirisi frm = new frmUrunGirisi();
            if (frm.AlimListele() > 0 && frm.DepoComboBoxDoldur() > 0)
            {
                waitForm.Close();
                OpenChildForm(frm, sender);
            }
            else
            {
                waitForm.Close();
                MessageBox.Show("Kayıtlı bir alım listesi veya depo bulunamadı. Lütfen bir alım girişi veya depo kaydı yaparak devam ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            OpenChildForm(new frmTabela(), sender);
            waitForm.Close();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            OpenChildForm(new frmFaturaGirisi(), sender);
            waitForm.Close();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            OpenChildForm(new frmOdeme(), sender);
            waitForm.Close();
        }

        private void btniase_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            frmCikisiase frm = new frmCikisiase();
            if (frm.YemekTabelaListele() > 0 && frm.DepoUrunListele() > 0)
            {
                waitForm.Close();
                OpenChildForm(new frmCikisiase(), sender);
            }
            else
            {
                waitForm.Close();
                MessageBox.Show("İaşe tabelası girişi yapmak istiyorsanız en az bir ürün kaydı ve yemek tabelasına ihtiyacınız var. Lütfen bir yemek tabelası veya ürün kaydı ekleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void birimTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            OpenChildForm(new frmBirim(), sender);
            waitForm.Close();
        }

        private void personelTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            frmPersonel frm = new frmPersonel();
            if (frm.ComboboxDoldur() > 0)
            {
                waitForm.Close();
                OpenChildForm(frm, sender);
            }
            else
            {
                waitForm.Close();
                MessageBox.Show("Personel tanımlayabilmeniz için birim tanımlamanız gerekmektedir. Lütfen ilk önce birim tanımlaması yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void depoTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            OpenChildForm(new frmDepo(), sender);
            waitForm.Close();
        }

        private void otomatikİaşeÇıkışTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            frmOtomatikiaseCikis frm = new frmOtomatikiaseCikis();
            if (frm.ComboboxDoldur() > 0)
            {
                waitForm.Close();
                OpenChildForm(frm, sender);
            }
            else
            {
                waitForm.Close();
                MessageBox.Show("Otomatik Çıkış tanımlayabilmeniz için ürün tanımlamanız gerekmektedir. Lütfen ilk önce alım girişi yaparak ürün tanımlayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iaşeTabelasıKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            frmDokumanIaseTabelaKayit frm = new frmDokumanIaseTabelaKayit();
            if (frm.GetYemekTabelasi() > 0)
            {
                waitForm.Close();
                OpenChildForm(frm, sender);
            }
            else
            {
                waitForm.Close();
                MessageBox.Show("İaşe tabelası kayıtlarına ulaşmak için bir yemek tabelasına ihtiyaç vardır. Lütfen en az bir yemek tabelası ekleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void yemekTabelasıKayıtlarıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            waitForm.Show(this);
            frmDokumanTabela frm = new frmDokumanTabela();
            OpenChildForm(frm, sender);
            waitForm.Close();
        }
        private void güncelDepoÜrünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            frmDepoUrunListe frm = new frmDepoUrunListe();
            if (frm.ComboboxDoldur() > 0)
            {
                waitForm.Close();
                OpenChildForm(frm, sender);
            }
            else
            {
                waitForm.Close();
                MessageBox.Show("Tanımlanmış Bir Depo Bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void güncelAlımListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            frmGuncelAlim frm = new frmGuncelAlim();
            if (frm.AlimListele() > 0)
            {
                waitForm.Close();
                OpenChildForm(new frmGuncelAlim(), sender);
            }
            else
            {
                waitForm.Close();
                MessageBox.Show("Alım Kaydınız Bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void telefonRehberiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show();
            OpenChildForm(new frmTelefonRehber(), sender);
            waitForm.Close();
        }
        private void btnOkudum_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["FirstRun"].Value = "1";
            config.Save(ConfigurationSaveMode.Modified);
            lblFirstRun.Visible = false;
            btnOkudum.Visible = false;
            pnlSideBar.Enabled = true;
            menuStrip1.Enabled = true;
        }

        private void depolarArasıÜrünTransferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            frmDepolarArasiUrunTransfer frm = new frmDepolarArasiUrunTransfer();
            if (frm.ComboBoxDoldur() > 1)
            {
                OpenChildForm(frm, sender);
            }
            else
            {
                waitForm.Close();
                MessageBox.Show("Depolar arası ürün transferi yapmak için en az 2 adet depoya ihtiyacınız vardır. Lütfen gereken miktarda depo ekleyeniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            waitForm.Close();
        }

        private void ürünÇıkışHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.Show();
            OpenChildForm(new frmUrunCikisHareketleri(), sender);
            waitForm.Close();
        }
        #endregion

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            frm.ShowDialog();
        }
    }
}