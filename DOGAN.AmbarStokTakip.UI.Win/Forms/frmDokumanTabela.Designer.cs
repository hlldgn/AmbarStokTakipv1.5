namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmDokumanTabela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDokumanTabela));
            this.datagridTabelaDokuman = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTabelaKayitlari = new System.Windows.Forms.Label();
            this.btnDokuman = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btniptal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblTumunuSec = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUygula = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cardTarihlerArasiAlimKayitlari = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateSonTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateilkTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblTarihlerArasiUrunKayitlari = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMaxRows = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTabelaDokuman)).BeginInit();
            this.panel1.SuspendLayout();
            this.cardTarihlerArasiAlimKayitlari.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridTabelaDokuman
            // 
            this.datagridTabelaDokuman.AllowUserToAddRows = false;
            this.datagridTabelaDokuman.AllowUserToDeleteRows = false;
            this.datagridTabelaDokuman.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridTabelaDokuman.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridTabelaDokuman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridTabelaDokuman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridTabelaDokuman.BackgroundColor = System.Drawing.Color.White;
            this.datagridTabelaDokuman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridTabelaDokuman.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridTabelaDokuman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridTabelaDokuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTabelaDokuman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sec});
            this.datagridTabelaDokuman.DoubleBuffered = true;
            this.datagridTabelaDokuman.EnableHeadersVisualStyles = false;
            this.datagridTabelaDokuman.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridTabelaDokuman.HeaderForeColor = System.Drawing.Color.White;
            this.datagridTabelaDokuman.Location = new System.Drawing.Point(12, 77);
            this.datagridTabelaDokuman.MultiSelect = false;
            this.datagridTabelaDokuman.Name = "datagridTabelaDokuman";
            this.datagridTabelaDokuman.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridTabelaDokuman.RowHeadersVisible = false;
            this.datagridTabelaDokuman.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridTabelaDokuman.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridTabelaDokuman.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridTabelaDokuman.RowTemplate.Height = 33;
            this.datagridTabelaDokuman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTabelaDokuman.Size = new System.Drawing.Size(907, 541);
            this.datagridTabelaDokuman.TabIndex = 37;
            // 
            // sec
            // 
            this.sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sec.HeaderText = "Seç";
            this.sec.Name = "sec";
            this.sec.Width = 50;
            // 
            // lblTabelaKayitlari
            // 
            this.lblTabelaKayitlari.AutoSize = true;
            this.lblTabelaKayitlari.ForeColor = System.Drawing.Color.White;
            this.lblTabelaKayitlari.Location = new System.Drawing.Point(12, 22);
            this.lblTabelaKayitlari.Name = "lblTabelaKayitlari";
            this.lblTabelaKayitlari.Size = new System.Drawing.Size(85, 13);
            this.lblTabelaKayitlari.TabIndex = 38;
            this.lblTabelaKayitlari.Text = "Tabela Kayıtları :";
            // 
            // btnDokuman
            // 
            this.btnDokuman.ActiveBorderThickness = 1;
            this.btnDokuman.ActiveCornerRadius = 20;
            this.btnDokuman.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnDokuman.ActiveForecolor = System.Drawing.Color.White;
            this.btnDokuman.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnDokuman.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDokuman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDokuman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDokuman.BackgroundImage")));
            this.btnDokuman.ButtonText = "Döküman Oluştur";
            this.btnDokuman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDokuman.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDokuman.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDokuman.IdleBorderThickness = 1;
            this.btnDokuman.IdleCornerRadius = 20;
            this.btnDokuman.IdleFillColor = System.Drawing.Color.White;
            this.btnDokuman.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDokuman.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDokuman.Location = new System.Drawing.Point(28, 577);
            this.btnDokuman.Margin = new System.Windows.Forms.Padding(5);
            this.btnDokuman.Name = "btnDokuman";
            this.btnDokuman.Size = new System.Drawing.Size(183, 41);
            this.btnDokuman.TabIndex = 41;
            this.btnDokuman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDokuman.Click += new System.EventHandler(this.btnDokuman_Click);
            // 
            // btniptal
            // 
            this.btniptal.ActiveBorderThickness = 1;
            this.btniptal.ActiveCornerRadius = 20;
            this.btniptal.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btniptal.ActiveForecolor = System.Drawing.Color.White;
            this.btniptal.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btniptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btniptal.BackColor = System.Drawing.Color.White;
            this.btniptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btniptal.BackgroundImage")));
            this.btniptal.ButtonText = "İptal Et";
            this.btniptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniptal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniptal.ForeColor = System.Drawing.Color.SeaGreen;
            this.btniptal.IdleBorderThickness = 1;
            this.btniptal.IdleCornerRadius = 20;
            this.btniptal.IdleFillColor = System.Drawing.Color.White;
            this.btniptal.IdleForecolor = System.Drawing.Color.Red;
            this.btniptal.IdleLineColor = System.Drawing.Color.Red;
            this.btniptal.Location = new System.Drawing.Point(830, 22);
            this.btniptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(88, 31);
            this.btniptal.TabIndex = 70;
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // lblTumunuSec
            // 
            this.lblTumunuSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblTumunuSec.ForeColor = System.Drawing.Color.White;
            this.lblTumunuSec.Location = new System.Drawing.Point(12, 49);
            this.lblTumunuSec.Name = "lblTumunuSec";
            this.lblTumunuSec.Size = new System.Drawing.Size(76, 25);
            this.lblTumunuSec.TabIndex = 71;
            this.lblTumunuSec.Text = "Tümünü Seç";
            this.lblTumunuSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTumunuSec.Click += new System.EventHandler(this.lblTumunuSec_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnUygula);
            this.panel1.Controls.Add(this.cardTarihlerArasiAlimKayitlari);
            this.panel1.Controls.Add(this.lblTarihlerArasiUrunKayitlari);
            this.panel1.Controls.Add(this.btnDokuman);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(925, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 644);
            this.panel1.TabIndex = 72;
            // 
            // btnUygula
            // 
            this.btnUygula.ActiveBorderThickness = 1;
            this.btnUygula.ActiveCornerRadius = 20;
            this.btnUygula.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnUygula.ActiveForecolor = System.Drawing.Color.White;
            this.btnUygula.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnUygula.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUygula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUygula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUygula.BackgroundImage")));
            this.btnUygula.ButtonText = "Uygula";
            this.btnUygula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUygula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUygula.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUygula.IdleBorderThickness = 1;
            this.btnUygula.IdleCornerRadius = 20;
            this.btnUygula.IdleFillColor = System.Drawing.Color.White;
            this.btnUygula.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnUygula.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUygula.Location = new System.Drawing.Point(28, 526);
            this.btnUygula.Margin = new System.Windows.Forms.Padding(5);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(183, 41);
            this.btnUygula.TabIndex = 54;
            this.btnUygula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // cardTarihlerArasiAlimKayitlari
            // 
            this.cardTarihlerArasiAlimKayitlari.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardTarihlerArasiAlimKayitlari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cardTarihlerArasiAlimKayitlari.BorderRadius = 5;
            this.cardTarihlerArasiAlimKayitlari.BottomSahddow = true;
            this.cardTarihlerArasiAlimKayitlari.color = System.Drawing.Color.SpringGreen;
            this.cardTarihlerArasiAlimKayitlari.Controls.Add(this.bunifuCustomLabel6);
            this.cardTarihlerArasiAlimKayitlari.Controls.Add(this.dateSonTarih);
            this.cardTarihlerArasiAlimKayitlari.Controls.Add(this.bunifuCustomLabel5);
            this.cardTarihlerArasiAlimKayitlari.Controls.Add(this.dateilkTarih);
            this.cardTarihlerArasiAlimKayitlari.LeftSahddow = false;
            this.cardTarihlerArasiAlimKayitlari.Location = new System.Drawing.Point(0, 87);
            this.cardTarihlerArasiAlimKayitlari.Name = "cardTarihlerArasiAlimKayitlari";
            this.cardTarihlerArasiAlimKayitlari.RightSahddow = true;
            this.cardTarihlerArasiAlimKayitlari.ShadowDepth = 20;
            this.cardTarihlerArasiAlimKayitlari.Size = new System.Drawing.Size(226, 147);
            this.cardTarihlerArasiAlimKayitlari.TabIndex = 54;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(9, 76);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(61, 13);
            this.bunifuCustomLabel6.TabIndex = 56;
            this.bunifuCustomLabel6.Text = "Bitiş Tarihi :";
            // 
            // dateSonTarih
            // 
            this.dateSonTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateSonTarih.BackColor = System.Drawing.Color.SeaGreen;
            this.dateSonTarih.BorderRadius = 0;
            this.dateSonTarih.ForeColor = System.Drawing.Color.White;
            this.dateSonTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSonTarih.FormatCustom = null;
            this.dateSonTarih.Location = new System.Drawing.Point(12, 92);
            this.dateSonTarih.Name = "dateSonTarih";
            this.dateSonTarih.Size = new System.Drawing.Size(199, 36);
            this.dateSonTarih.TabIndex = 55;
            this.dateSonTarih.Value = new System.DateTime(2022, 2, 1, 13, 53, 4, 194);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(9, 20);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(88, 13);
            this.bunifuCustomLabel5.TabIndex = 54;
            this.bunifuCustomLabel5.Text = "Başlangıç Tarihi :";
            // 
            // dateilkTarih
            // 
            this.dateilkTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateilkTarih.BackColor = System.Drawing.Color.SeaGreen;
            this.dateilkTarih.BorderRadius = 0;
            this.dateilkTarih.ForeColor = System.Drawing.Color.White;
            this.dateilkTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateilkTarih.FormatCustom = null;
            this.dateilkTarih.Location = new System.Drawing.Point(12, 37);
            this.dateilkTarih.Name = "dateilkTarih";
            this.dateilkTarih.Size = new System.Drawing.Size(199, 36);
            this.dateilkTarih.TabIndex = 45;
            this.dateilkTarih.Value = new System.DateTime(2022, 2, 1, 13, 53, 4, 194);
            // 
            // lblTarihlerArasiUrunKayitlari
            // 
            this.lblTarihlerArasiUrunKayitlari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarihlerArasiUrunKayitlari.AutoSize = true;
            this.lblTarihlerArasiUrunKayitlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTarihlerArasiUrunKayitlari.ForeColor = System.Drawing.Color.White;
            this.lblTarihlerArasiUrunKayitlari.Location = new System.Drawing.Point(9, 61);
            this.lblTarihlerArasiUrunKayitlari.Name = "lblTarihlerArasiUrunKayitlari";
            this.lblTarihlerArasiUrunKayitlari.Size = new System.Drawing.Size(175, 13);
            this.lblTarihlerArasiUrunKayitlari.TabIndex = 55;
            this.lblTarihlerArasiUrunKayitlari.Text = "Tarihler Arası Yemek Listesi Kayıtları";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(95, 22);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(46, 13);
            this.bunifuCustomLabel3.TabIndex = 54;
            this.bunifuCustomLabel3.Text = "Filtreler :";
            // 
            // lblMaxRows
            // 
            this.lblMaxRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxRows.ForeColor = System.Drawing.Color.Crimson;
            this.lblMaxRows.Location = new System.Drawing.Point(742, 61);
            this.lblMaxRows.Name = "lblMaxRows";
            this.lblMaxRows.Size = new System.Drawing.Size(177, 13);
            this.lblMaxRows.TabIndex = 99;
            this.lblMaxRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmDokumanTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 644);
            this.Controls.Add(this.lblMaxRows);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTabelaKayitlari);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.lblTumunuSec);
            this.Controls.Add(this.datagridTabelaDokuman);
            this.Name = "frmDokumanTabela";
            this.Text = "Yemek Listesi Kayıtları";
            ((System.ComponentModel.ISupportInitialize)(this.datagridTabelaDokuman)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cardTarihlerArasiAlimKayitlari.ResumeLayout(false);
            this.cardTarihlerArasiAlimKayitlari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridTabelaDokuman;
        private System.Windows.Forms.Label lblTabelaKayitlari;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDokuman;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sec;
        private Bunifu.Framework.UI.BunifuThinButton2 btniptal;
        private System.Windows.Forms.Label lblTumunuSec;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUygula;
        private Bunifu.Framework.UI.BunifuCards cardTarihlerArasiAlimKayitlari;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker dateSonTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDatepicker dateilkTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTarihlerArasiUrunKayitlari;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMaxRows;
    }
}