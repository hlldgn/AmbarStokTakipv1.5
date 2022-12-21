﻿using System;
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
    public partial class frmWait : Form
    {
        public frmWait()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        public frmWait(Form parent)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        internal void CloseWaitForm()
        {
            this.DialogResult=DialogResult.OK;
            this.Close();
        }
    }
}
