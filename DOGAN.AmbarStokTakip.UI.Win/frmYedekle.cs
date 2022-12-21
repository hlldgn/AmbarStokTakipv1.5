using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DOGAN.AmbarStokTakip.Business;

namespace DOGAN.AmbarStokTakip.UI.Win
{
    public partial class frmYedekle : Form
    {
        public frmYedekle()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                yedekle();
            }
            else
            {
                yedektenAl();
            }
        }
        private void yedekle()
        {
            try
            {
                if (txtPathYedekle.Text != String.Empty)
                {
                    string path = txtPathYedekle.Text;
                    YedekleManager yedekleManager = new YedekleManager();
                    yedekleManager.Yedekle(path);
                    MessageBox.Show("Yedekleme İşlemi Başarı İle Gerçekleşmiştir.");
                }
                else
                {
                    MessageBox.Show("Lütfen yedekleme yolunu giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void yedektenAl()
        {
            try
            {
                if (txtPathAl.Text != String.Empty)
                {
                    string path = txtPathAl.Text;
                    YedekleManager yedekleManager = new YedekleManager();
                    yedekleManager.yedektenAl(path);
                    MessageBox.Show("Yedekten Alma İşlemi Başarı İle Gerçekleşmiştir. Program Yeniden başlatılacaktır.");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Lütfen yedekten alma yolunu giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGozatYedekle_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPathYedekle.Text = dialog.SelectedPath;
            }
        }

        private void btnGozatAl_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter= "SQL SERVER database backup files |*.BAK;*.bak";
            dialog.Title = "Database Restore";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPathAl.Text = dialog.FileName;
            }
        }
    }
}
