namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmDokumanSarfKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDokumanSarfKayit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSarfMalzemeIptal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblSarficerik = new System.Windows.Forms.Label();
            this.datagridSarficerik = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDokuman = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblToplam = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateSarfVerilisTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTumunuSec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSarficerik)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSarfMalzemeIptal
            // 
            this.btnSarfMalzemeIptal.ActiveBorderThickness = 1;
            this.btnSarfMalzemeIptal.ActiveCornerRadius = 20;
            this.btnSarfMalzemeIptal.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btnSarfMalzemeIptal.ActiveForecolor = System.Drawing.Color.White;
            this.btnSarfMalzemeIptal.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btnSarfMalzemeIptal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSarfMalzemeIptal.BackColor = System.Drawing.Color.White;
            this.btnSarfMalzemeIptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSarfMalzemeIptal.BackgroundImage")));
            this.btnSarfMalzemeIptal.ButtonText = "Sarf Malzeme İptal";
            this.btnSarfMalzemeIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSarfMalzemeIptal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSarfMalzemeIptal.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSarfMalzemeIptal.IdleBorderThickness = 1;
            this.btnSarfMalzemeIptal.IdleCornerRadius = 20;
            this.btnSarfMalzemeIptal.IdleFillColor = System.Drawing.Color.White;
            this.btnSarfMalzemeIptal.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSarfMalzemeIptal.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSarfMalzemeIptal.Location = new System.Drawing.Point(600, 589);
            this.btnSarfMalzemeIptal.Margin = new System.Windows.Forms.Padding(5);
            this.btnSarfMalzemeIptal.Name = "btnSarfMalzemeIptal";
            this.btnSarfMalzemeIptal.Size = new System.Drawing.Size(211, 41);
            this.btnSarfMalzemeIptal.TabIndex = 96;
            this.btnSarfMalzemeIptal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSarfMalzemeIptal.Click += new System.EventHandler(this.btnSarfMalzemeIptal_Click);
            // 
            // lblSarficerik
            // 
            this.lblSarficerik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSarficerik.AutoSize = true;
            this.lblSarficerik.Location = new System.Drawing.Point(1005, 136);
            this.lblSarficerik.Name = "lblSarficerik";
            this.lblSarficerik.Size = new System.Drawing.Size(134, 13);
            this.lblSarficerik.TabIndex = 95;
            this.lblSarficerik.Text = "Sarf Malzeme İçeriği Listesi";
            // 
            // datagridSarficerik
            // 
            this.datagridSarficerik.AllowUserToAddRows = false;
            this.datagridSarficerik.AllowUserToDeleteRows = false;
            this.datagridSarficerik.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridSarficerik.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridSarficerik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridSarficerik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridSarficerik.BackgroundColor = System.Drawing.Color.White;
            this.datagridSarficerik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridSarficerik.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridSarficerik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridSarficerik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSarficerik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sec});
            this.datagridSarficerik.DoubleBuffered = true;
            this.datagridSarficerik.EnableHeadersVisualStyles = false;
            this.datagridSarficerik.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridSarficerik.HeaderForeColor = System.Drawing.Color.White;
            this.datagridSarficerik.Location = new System.Drawing.Point(15, 158);
            this.datagridSarficerik.MultiSelect = false;
            this.datagridSarficerik.Name = "datagridSarficerik";
            this.datagridSarficerik.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridSarficerik.RowHeadersVisible = false;
            this.datagridSarficerik.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridSarficerik.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridSarficerik.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridSarficerik.RowTemplate.Height = 33;
            this.datagridSarficerik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridSarficerik.Size = new System.Drawing.Size(1124, 402);
            this.datagridSarficerik.TabIndex = 94;
            this.datagridSarficerik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridSarficerik_CellContentClick);
            // 
            // sec
            // 
            this.sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sec.HeaderText = "Seç";
            this.sec.Name = "sec";
            this.sec.Width = 75;
            // 
            // btnDokuman
            // 
            this.btnDokuman.ActiveBorderThickness = 1;
            this.btnDokuman.ActiveCornerRadius = 20;
            this.btnDokuman.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnDokuman.ActiveForecolor = System.Drawing.Color.White;
            this.btnDokuman.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnDokuman.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDokuman.BackColor = System.Drawing.Color.White;
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
            this.btnDokuman.Location = new System.Drawing.Point(353, 589);
            this.btnDokuman.Margin = new System.Windows.Forms.Padding(5);
            this.btnDokuman.Name = "btnDokuman";
            this.btnDokuman.Size = new System.Drawing.Size(211, 41);
            this.btnDokuman.TabIndex = 93;
            this.btnDokuman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDokuman.Click += new System.EventHandler(this.btnDokuman_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.White;
            this.lblToplam.Location = new System.Drawing.Point(12, 563);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(1127, 18);
            this.lblToplam.TabIndex = 98;
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateSarfVerilisTarih
            // 
            this.dateSarfVerilisTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateSarfVerilisTarih.BackColor = System.Drawing.Color.SeaGreen;
            this.dateSarfVerilisTarih.BorderRadius = 0;
            this.dateSarfVerilisTarih.ForeColor = System.Drawing.Color.White;
            this.dateSarfVerilisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateSarfVerilisTarih.FormatCustom = null;
            this.dateSarfVerilisTarih.Location = new System.Drawing.Point(472, 45);
            this.dateSarfVerilisTarih.Name = "dateSarfVerilisTarih";
            this.dateSarfVerilisTarih.Size = new System.Drawing.Size(303, 36);
            this.dateSarfVerilisTarih.TabIndex = 99;
            this.dateSarfVerilisTarih.Value = new System.DateTime(2022, 2, 1, 13, 53, 4, 194);
            this.dateSarfVerilisTarih.onValueChanged += new System.EventHandler(this.dateSarfVerilisTarih_onValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(469, 29);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(136, 13);
            this.bunifuCustomLabel3.TabIndex = 100;
            this.bunifuCustomLabel3.Text = "Sarf Malzeme Veriliş Tarihi :";
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.White;
            this.txtAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAra.ForeColor = System.Drawing.Color.Black;
            this.txtAra.HintForeColor = System.Drawing.Color.Black;
            this.txtAra.HintText = "Ara";
            this.txtAra.isPassword = false;
            this.txtAra.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtAra.LineIdleColor = System.Drawing.Color.Black;
            this.txtAra.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtAra.LineThickness = 3;
            this.txtAra.Location = new System.Drawing.Point(15, 93);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(303, 33);
            this.txtAra.TabIndex = 101;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
            this.txtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAra_KeyPress);
            // 
            // lblTumunuSec
            // 
            this.lblTumunuSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblTumunuSec.ForeColor = System.Drawing.Color.White;
            this.lblTumunuSec.Location = new System.Drawing.Point(12, 130);
            this.lblTumunuSec.Name = "lblTumunuSec";
            this.lblTumunuSec.Size = new System.Drawing.Size(76, 25);
            this.lblTumunuSec.TabIndex = 102;
            this.lblTumunuSec.Text = "Tümünü Seç";
            this.lblTumunuSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTumunuSec.Click += new System.EventHandler(this.lblTumunuSec_Click);
            // 
            // frmDokumanSarfKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.lblTumunuSec);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dateSarfVerilisTarih);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnSarfMalzemeIptal);
            this.Controls.Add(this.lblSarficerik);
            this.Controls.Add(this.datagridSarficerik);
            this.Controls.Add(this.btnDokuman);
            this.Name = "frmDokumanSarfKayit";
            this.Text = "Sarf Malzeme Çıkış Kayıtları";
            ((System.ComponentModel.ISupportInitialize)(this.datagridSarficerik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnSarfMalzemeIptal;
        private System.Windows.Forms.Label lblSarficerik;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridSarficerik;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDokuman;
        private Bunifu.Framework.UI.BunifuCustomLabel lblToplam;
        private Bunifu.Framework.UI.BunifuDatepicker dateSarfVerilisTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sec;
        private System.Windows.Forms.Label lblTumunuSec;
    }
}