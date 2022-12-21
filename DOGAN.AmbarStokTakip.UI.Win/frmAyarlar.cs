using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
            cmbSatir.Text = Properties.Settings.Default.SatirSayisi.ToString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SatirSayisi = Convert.ToInt32(cmbSatir.Text.ToString());
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
