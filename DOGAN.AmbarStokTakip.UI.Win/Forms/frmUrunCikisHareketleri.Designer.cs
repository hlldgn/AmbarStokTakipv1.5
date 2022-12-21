namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmUrunCikisHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunCikisHareketleri));
            this.lblToplamTutar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUrunler = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridUrunCikis = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBoxGoster = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.checkIase = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkSarf = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnUygula = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkKelime = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cadrsKelime = new Bunifu.Framework.UI.BunifuCards();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblUrunKayitlariKelime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cardTarihlerArasiAlimKayitlari = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateSonTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateilkTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.checkTarihlerArasiUrunKayitlari = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblTarihlerArasiUrunKayitlari = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMaxRows = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUrunCikis)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpBoxGoster.SuspendLayout();
            this.cadrsKelime.SuspendLayout();
            this.cardTarihlerArasiAlimKayitlari.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplamTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.White;
            this.lblToplamTutar.Location = new System.Drawing.Point(8, 600);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(893, 18);
            this.lblToplamTutar.TabIndex = 101;
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrunler
            // 
            this.lblUrunler.AutoSize = true;
            this.lblUrunler.Location = new System.Drawing.Point(5, 33);
            this.lblUrunler.Name = "lblUrunler";
            this.lblUrunler.Size = new System.Drawing.Size(47, 13);
            this.lblUrunler.TabIndex = 99;
            this.lblUrunler.Text = "Ürünler :";
            // 
            // datagridUrunCikis
            // 
            this.datagridUrunCikis.AllowUserToAddRows = false;
            this.datagridUrunCikis.AllowUserToDeleteRows = false;
            this.datagridUrunCikis.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridUrunCikis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridUrunCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridUrunCikis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridUrunCikis.BackgroundColor = System.Drawing.Color.White;
            this.datagridUrunCikis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridUrunCikis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridUrunCikis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridUrunCikis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridUrunCikis.DoubleBuffered = true;
            this.datagridUrunCikis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridUrunCikis.EnableHeadersVisualStyles = false;
            this.datagridUrunCikis.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridUrunCikis.HeaderForeColor = System.Drawing.Color.White;
            this.datagridUrunCikis.Location = new System.Drawing.Point(8, 49);
            this.datagridUrunCikis.MultiSelect = false;
            this.datagridUrunCikis.Name = "datagridUrunCikis";
            this.datagridUrunCikis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridUrunCikis.RowHeadersVisible = false;
            this.datagridUrunCikis.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridUrunCikis.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridUrunCikis.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridUrunCikis.RowTemplate.Height = 33;
            this.datagridUrunCikis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridUrunCikis.Size = new System.Drawing.Size(893, 548);
            this.datagridUrunCikis.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.grpBoxGoster);
            this.panel1.Controls.Add(this.btnUygula);
            this.panel1.Controls.Add(this.checkKelime);
            this.panel1.Controls.Add(this.cadrsKelime);
            this.panel1.Controls.Add(this.lblUrunKayitlariKelime);
            this.panel1.Controls.Add(this.cardTarihlerArasiAlimKayitlari);
            this.panel1.Controls.Add(this.checkTarihlerArasiUrunKayitlari);
            this.panel1.Controls.Add(this.lblTarihlerArasiUrunKayitlari);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(922, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 644);
            this.panel1.TabIndex = 98;
            // 
            // grpBoxGoster
            // 
            this.grpBoxGoster.Controls.Add(this.bunifuCustomLabel2);
            this.grpBoxGoster.Controls.Add(this.bunifuCustomLabel1);
            this.grpBoxGoster.Controls.Add(this.checkIase);
            this.grpBoxGoster.Controls.Add(this.checkSarf);
            this.grpBoxGoster.ForeColor = System.Drawing.Color.White;
            this.grpBoxGoster.Location = new System.Drawing.Point(0, 179);
            this.grpBoxGoster.Name = "grpBoxGoster";
            this.grpBoxGoster.Size = new System.Drawing.Size(236, 105);
            this.grpBoxGoster.TabIndex = 65;
            this.grpBoxGoster.TabStop = false;
            this.grpBoxGoster.Text = "Göster";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(34, 74);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(136, 13);
            this.bunifuCustomLabel2.TabIndex = 66;
            this.bunifuCustomLabel2.Text = "Sarf Malzemeleri Ait Ürünler";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 37);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(90, 13);
            this.bunifuCustomLabel1.TabIndex = 65;
            this.bunifuCustomLabel1.Text = "İaşeye Ait Ürünler";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // checkIase
            // 
            this.checkIase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkIase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkIase.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkIase.Checked = true;
            this.checkIase.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkIase.ForeColor = System.Drawing.Color.White;
            this.checkIase.Location = new System.Drawing.Point(11, 33);
            this.checkIase.Name = "checkIase";
            this.checkIase.Size = new System.Drawing.Size(20, 20);
            this.checkIase.TabIndex = 62;
            this.checkIase.OnChange += new System.EventHandler(this.checkIase_OnChange);
            // 
            // checkSarf
            // 
            this.checkSarf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkSarf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkSarf.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkSarf.Checked = false;
            this.checkSarf.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkSarf.ForeColor = System.Drawing.Color.White;
            this.checkSarf.Location = new System.Drawing.Point(12, 70);
            this.checkSarf.Name = "checkSarf";
            this.checkSarf.Size = new System.Drawing.Size(20, 20);
            this.checkSarf.TabIndex = 63;
            this.checkSarf.OnChange += new System.EventHandler(this.checkSarf_OnChange);
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
            this.btnUygula.Location = new System.Drawing.Point(21, 577);
            this.btnUygula.Margin = new System.Windows.Forms.Padding(5);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(183, 41);
            this.btnUygula.TabIndex = 54;
            this.btnUygula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // checkKelime
            // 
            this.checkKelime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkKelime.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkKelime.Checked = false;
            this.checkKelime.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkKelime.ForeColor = System.Drawing.Color.White;
            this.checkKelime.Location = new System.Drawing.Point(11, 120);
            this.checkKelime.Name = "checkKelime";
            this.checkKelime.Size = new System.Drawing.Size(20, 20);
            this.checkKelime.TabIndex = 56;
            this.checkKelime.OnChange += new System.EventHandler(this.checkKelime_OnChange);
            // 
            // cadrsKelime
            // 
            this.cadrsKelime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cadrsKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cadrsKelime.BorderRadius = 5;
            this.cadrsKelime.BottomSahddow = true;
            this.cadrsKelime.color = System.Drawing.Color.SpringGreen;
            this.cadrsKelime.Controls.Add(this.txtAra);
            this.cadrsKelime.LeftSahddow = false;
            this.cadrsKelime.Location = new System.Drawing.Point(0, 147);
            this.cadrsKelime.Name = "cadrsKelime";
            this.cadrsKelime.RightSahddow = true;
            this.cadrsKelime.ShadowDepth = 20;
            this.cadrsKelime.Size = new System.Drawing.Size(233, 10);
            this.cadrsKelime.TabIndex = 55;
            // 
            // txtAra
            // 
            this.txtAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAra.ForeColor = System.Drawing.Color.White;
            this.txtAra.HintForeColor = System.Drawing.Color.White;
            this.txtAra.HintText = "Ara";
            this.txtAra.isPassword = false;
            this.txtAra.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtAra.LineIdleColor = System.Drawing.Color.White;
            this.txtAra.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtAra.LineThickness = 3;
            this.txtAra.Location = new System.Drawing.Point(21, 19);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(182, 33);
            this.txtAra.TabIndex = 42;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAra_KeyPress);
            // 
            // lblUrunKayitlariKelime
            // 
            this.lblUrunKayitlariKelime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrunKayitlariKelime.AutoSize = true;
            this.lblUrunKayitlariKelime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUrunKayitlariKelime.ForeColor = System.Drawing.Color.White;
            this.lblUrunKayitlariKelime.Location = new System.Drawing.Point(35, 122);
            this.lblUrunKayitlariKelime.Name = "lblUrunKayitlariKelime";
            this.lblUrunKayitlariKelime.Size = new System.Drawing.Size(120, 13);
            this.lblUrunKayitlariKelime.TabIndex = 57;
            this.lblUrunKayitlariKelime.Text = "Ürün Kayıtları İçinde Ara";
            this.lblUrunKayitlariKelime.Click += new System.EventHandler(this.lblUrunKayitlariKelime_Click);
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
            this.cardTarihlerArasiAlimKayitlari.Size = new System.Drawing.Size(229, 10);
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
            this.dateSonTarih.Location = new System.Drawing.Point(23, 92);
            this.dateSonTarih.Name = "dateSonTarih";
            this.dateSonTarih.Size = new System.Drawing.Size(183, 36);
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
            this.dateilkTarih.Location = new System.Drawing.Point(23, 37);
            this.dateilkTarih.Name = "dateilkTarih";
            this.dateilkTarih.Size = new System.Drawing.Size(183, 36);
            this.dateilkTarih.TabIndex = 45;
            this.dateilkTarih.Value = new System.DateTime(2022, 2, 1, 13, 53, 4, 194);
            // 
            // checkTarihlerArasiUrunKayitlari
            // 
            this.checkTarihlerArasiUrunKayitlari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTarihlerArasiUrunKayitlari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkTarihlerArasiUrunKayitlari.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkTarihlerArasiUrunKayitlari.Checked = false;
            this.checkTarihlerArasiUrunKayitlari.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkTarihlerArasiUrunKayitlari.ForeColor = System.Drawing.Color.White;
            this.checkTarihlerArasiUrunKayitlari.Location = new System.Drawing.Point(11, 61);
            this.checkTarihlerArasiUrunKayitlari.Name = "checkTarihlerArasiUrunKayitlari";
            this.checkTarihlerArasiUrunKayitlari.Size = new System.Drawing.Size(20, 20);
            this.checkTarihlerArasiUrunKayitlari.TabIndex = 55;
            this.checkTarihlerArasiUrunKayitlari.OnChange += new System.EventHandler(this.checkTarihlerArasiUrunKayitlari_OnChange);
            // 
            // lblTarihlerArasiUrunKayitlari
            // 
            this.lblTarihlerArasiUrunKayitlari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarihlerArasiUrunKayitlari.AutoSize = true;
            this.lblTarihlerArasiUrunKayitlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTarihlerArasiUrunKayitlari.ForeColor = System.Drawing.Color.White;
            this.lblTarihlerArasiUrunKayitlari.Location = new System.Drawing.Point(35, 63);
            this.lblTarihlerArasiUrunKayitlari.Name = "lblTarihlerArasiUrunKayitlari";
            this.lblTarihlerArasiUrunKayitlari.Size = new System.Drawing.Size(158, 13);
            this.lblTarihlerArasiUrunKayitlari.TabIndex = 55;
            this.lblTarihlerArasiUrunKayitlari.Text = "Tarihler Arası Ürün Çıkış Kayıtları";
            this.lblTarihlerArasiUrunKayitlari.Click += new System.EventHandler(this.lblTarihlerArasiUrunKayitlari_Click);
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
            this.lblMaxRows.Location = new System.Drawing.Point(724, 33);
            this.lblMaxRows.Name = "lblMaxRows";
            this.lblMaxRows.Size = new System.Drawing.Size(177, 13);
            this.lblMaxRows.TabIndex = 102;
            this.lblMaxRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmUrunCikisHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.lblMaxRows);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblUrunler);
            this.Controls.Add(this.datagridUrunCikis);
            this.Controls.Add(this.panel1);
            this.Name = "frmUrunCikisHareketleri";
            this.Text = "Ürün Çıkış Hareketleri";
            this.Load += new System.EventHandler(this.frmUrunCikisHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridUrunCikis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBoxGoster.ResumeLayout(false);
            this.grpBoxGoster.PerformLayout();
            this.cadrsKelime.ResumeLayout(false);
            this.cardTarihlerArasiAlimKayitlari.ResumeLayout(false);
            this.cardTarihlerArasiAlimKayitlari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblToplamTutar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUrunler;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridUrunCikis;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUygula;
        private Bunifu.Framework.UI.BunifuCheckbox checkKelime;
        private Bunifu.Framework.UI.BunifuCards cadrsKelime;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUrunKayitlariKelime;
        private Bunifu.Framework.UI.BunifuCards cardTarihlerArasiAlimKayitlari;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker dateSonTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDatepicker dateilkTarih;
        private Bunifu.Framework.UI.BunifuCheckbox checkTarihlerArasiUrunKayitlari;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTarihlerArasiUrunKayitlari;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.GroupBox grpBoxGoster;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox checkIase;
        private Bunifu.Framework.UI.BunifuCheckbox checkSarf;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMaxRows;
    }
}