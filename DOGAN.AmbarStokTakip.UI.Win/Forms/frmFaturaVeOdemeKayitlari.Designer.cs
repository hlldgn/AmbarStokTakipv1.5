namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmFaturaVeOdemeKayitlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturaVeOdemeKayitlari));
            this.lblKayitlariListesi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridFaturaVeOdemeKayitlari = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.checkOdeme = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkFatura = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblOdemeKayitlari = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFaturaKayitlari = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btniptal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBoxGoster = new System.Windows.Forms.GroupBox();
            this.btnUygula = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkKelime = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cadrsKelime = new Bunifu.Framework.UI.BunifuCards();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblKayitlarKelime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cardTarihlerArasiKayitlar = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateSonTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateilkTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.checkTarihlerArasiKayitlar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblTarihlerArasiKayitlar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMaxRows = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFaturaVeOdemeKayitlari)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpBoxGoster.SuspendLayout();
            this.cadrsKelime.SuspendLayout();
            this.cardTarihlerArasiKayitlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKayitlariListesi
            // 
            this.lblKayitlariListesi.AutoSize = true;
            this.lblKayitlariListesi.Location = new System.Drawing.Point(9, 52);
            this.lblKayitlariListesi.Name = "lblKayitlariListesi";
            this.lblKayitlariListesi.Size = new System.Drawing.Size(84, 13);
            this.lblKayitlariListesi.TabIndex = 56;
            this.lblKayitlariListesi.Text = "...Kayıtları Listesi";
            // 
            // datagridFaturaVeOdemeKayitlari
            // 
            this.datagridFaturaVeOdemeKayitlari.AllowUserToAddRows = false;
            this.datagridFaturaVeOdemeKayitlari.AllowUserToDeleteRows = false;
            this.datagridFaturaVeOdemeKayitlari.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridFaturaVeOdemeKayitlari.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridFaturaVeOdemeKayitlari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridFaturaVeOdemeKayitlari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridFaturaVeOdemeKayitlari.BackgroundColor = System.Drawing.Color.White;
            this.datagridFaturaVeOdemeKayitlari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridFaturaVeOdemeKayitlari.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridFaturaVeOdemeKayitlari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridFaturaVeOdemeKayitlari.DoubleBuffered = true;
            this.datagridFaturaVeOdemeKayitlari.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridFaturaVeOdemeKayitlari.EnableHeadersVisualStyles = false;
            this.datagridFaturaVeOdemeKayitlari.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridFaturaVeOdemeKayitlari.HeaderForeColor = System.Drawing.Color.White;
            this.datagridFaturaVeOdemeKayitlari.Location = new System.Drawing.Point(12, 71);
            this.datagridFaturaVeOdemeKayitlari.MultiSelect = false;
            this.datagridFaturaVeOdemeKayitlari.Name = "datagridFaturaVeOdemeKayitlari";
            this.datagridFaturaVeOdemeKayitlari.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridFaturaVeOdemeKayitlari.RowHeadersVisible = false;
            this.datagridFaturaVeOdemeKayitlari.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridFaturaVeOdemeKayitlari.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridFaturaVeOdemeKayitlari.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridFaturaVeOdemeKayitlari.RowTemplate.Height = 33;
            this.datagridFaturaVeOdemeKayitlari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridFaturaVeOdemeKayitlari.Size = new System.Drawing.Size(907, 559);
            this.datagridFaturaVeOdemeKayitlari.TabIndex = 57;
            // 
            // checkOdeme
            // 
            this.checkOdeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkOdeme.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkOdeme.Checked = false;
            this.checkOdeme.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkOdeme.ForeColor = System.Drawing.Color.White;
            this.checkOdeme.Location = new System.Drawing.Point(10, 60);
            this.checkOdeme.Name = "checkOdeme";
            this.checkOdeme.Size = new System.Drawing.Size(20, 20);
            this.checkOdeme.TabIndex = 64;
            this.checkOdeme.OnChange += new System.EventHandler(this.checkOdeme_OnChange);
            // 
            // checkFatura
            // 
            this.checkFatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkFatura.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkFatura.Checked = false;
            this.checkFatura.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkFatura.ForeColor = System.Drawing.Color.White;
            this.checkFatura.Location = new System.Drawing.Point(12, 28);
            this.checkFatura.Name = "checkFatura";
            this.checkFatura.Size = new System.Drawing.Size(20, 20);
            this.checkFatura.TabIndex = 62;
            this.checkFatura.OnChange += new System.EventHandler(this.checkFatura_OnChange);
            // 
            // lblOdemeKayitlari
            // 
            this.lblOdemeKayitlari.AutoSize = true;
            this.lblOdemeKayitlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOdemeKayitlari.ForeColor = System.Drawing.Color.White;
            this.lblOdemeKayitlari.Location = new System.Drawing.Point(35, 63);
            this.lblOdemeKayitlari.Name = "lblOdemeKayitlari";
            this.lblOdemeKayitlari.Size = new System.Drawing.Size(144, 13);
            this.lblOdemeKayitlari.TabIndex = 65;
            this.lblOdemeKayitlari.Text = "Ödeme Girişi Yapılmış Kayıtlar";
            this.lblOdemeKayitlari.Click += new System.EventHandler(this.lblOdemeKayitlari_Click);
            // 
            // lblFaturaKayitlari
            // 
            this.lblFaturaKayitlari.AutoSize = true;
            this.lblFaturaKayitlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFaturaKayitlari.ForeColor = System.Drawing.Color.White;
            this.lblFaturaKayitlari.Location = new System.Drawing.Point(35, 31);
            this.lblFaturaKayitlari.Name = "lblFaturaKayitlari";
            this.lblFaturaKayitlari.Size = new System.Drawing.Size(140, 13);
            this.lblFaturaKayitlari.TabIndex = 63;
            this.lblFaturaKayitlari.Text = "Fatura Girişi Yapılmış Kayıtlar";
            this.lblFaturaKayitlari.Click += new System.EventHandler(this.lblFaturaKayitlari_Click);
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
            this.btniptal.Location = new System.Drawing.Point(831, 13);
            this.btniptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(88, 31);
            this.btniptal.TabIndex = 69;
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.grpBoxGoster);
            this.panel1.Controls.Add(this.btnUygula);
            this.panel1.Controls.Add(this.checkKelime);
            this.panel1.Controls.Add(this.cadrsKelime);
            this.panel1.Controls.Add(this.lblKayitlarKelime);
            this.panel1.Controls.Add(this.cardTarihlerArasiKayitlar);
            this.panel1.Controls.Add(this.checkTarihlerArasiKayitlar);
            this.panel1.Controls.Add(this.lblTarihlerArasiKayitlar);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(925, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 644);
            this.panel1.TabIndex = 70;
            // 
            // grpBoxGoster
            // 
            this.grpBoxGoster.Controls.Add(this.checkFatura);
            this.grpBoxGoster.Controls.Add(this.checkOdeme);
            this.grpBoxGoster.Controls.Add(this.lblOdemeKayitlari);
            this.grpBoxGoster.Controls.Add(this.lblFaturaKayitlari);
            this.grpBoxGoster.ForeColor = System.Drawing.Color.White;
            this.grpBoxGoster.Location = new System.Drawing.Point(0, 179);
            this.grpBoxGoster.Name = "grpBoxGoster";
            this.grpBoxGoster.Size = new System.Drawing.Size(233, 94);
            this.grpBoxGoster.TabIndex = 64;
            this.grpBoxGoster.TabStop = false;
            this.grpBoxGoster.Text = "Göster";
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
            this.btnUygula.Location = new System.Drawing.Point(31, 589);
            this.btnUygula.Margin = new System.Windows.Forms.Padding(5);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(183, 41);
            this.btnUygula.TabIndex = 54;
            this.btnUygula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click_1);
            // 
            // checkKelime
            // 
            this.checkKelime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkKelime.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkKelime.Checked = false;
            this.checkKelime.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkKelime.ForeColor = System.Drawing.Color.White;
            this.checkKelime.Location = new System.Drawing.Point(11, 123);
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
            this.cadrsKelime.Location = new System.Drawing.Point(0, 150);
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
            // lblKayitlarKelime
            // 
            this.lblKayitlarKelime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKayitlarKelime.AutoSize = true;
            this.lblKayitlarKelime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKayitlarKelime.ForeColor = System.Drawing.Color.White;
            this.lblKayitlarKelime.Location = new System.Drawing.Point(35, 125);
            this.lblKayitlarKelime.Name = "lblKayitlarKelime";
            this.lblKayitlarKelime.Size = new System.Drawing.Size(92, 13);
            this.lblKayitlarKelime.TabIndex = 57;
            this.lblKayitlarKelime.Text = "Kayıtlar İçinde Ara";
            this.lblKayitlarKelime.Click += new System.EventHandler(this.lblKayitlarKelime_Click);
            // 
            // cardTarihlerArasiKayitlar
            // 
            this.cardTarihlerArasiKayitlar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardTarihlerArasiKayitlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cardTarihlerArasiKayitlar.BorderRadius = 5;
            this.cardTarihlerArasiKayitlar.BottomSahddow = true;
            this.cardTarihlerArasiKayitlar.color = System.Drawing.Color.SpringGreen;
            this.cardTarihlerArasiKayitlar.Controls.Add(this.bunifuCustomLabel6);
            this.cardTarihlerArasiKayitlar.Controls.Add(this.dateSonTarih);
            this.cardTarihlerArasiKayitlar.Controls.Add(this.bunifuCustomLabel5);
            this.cardTarihlerArasiKayitlar.Controls.Add(this.dateilkTarih);
            this.cardTarihlerArasiKayitlar.LeftSahddow = false;
            this.cardTarihlerArasiKayitlar.Location = new System.Drawing.Point(0, 87);
            this.cardTarihlerArasiKayitlar.Name = "cardTarihlerArasiKayitlar";
            this.cardTarihlerArasiKayitlar.RightSahddow = true;
            this.cardTarihlerArasiKayitlar.ShadowDepth = 20;
            this.cardTarihlerArasiKayitlar.Size = new System.Drawing.Size(226, 10);
            this.cardTarihlerArasiKayitlar.TabIndex = 54;
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
            this.dateSonTarih.Location = new System.Drawing.Point(22, 92);
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
            this.dateilkTarih.Location = new System.Drawing.Point(22, 37);
            this.dateilkTarih.Name = "dateilkTarih";
            this.dateilkTarih.Size = new System.Drawing.Size(183, 36);
            this.dateilkTarih.TabIndex = 45;
            this.dateilkTarih.Value = new System.DateTime(2022, 2, 1, 13, 53, 4, 194);
            // 
            // checkTarihlerArasiKayitlar
            // 
            this.checkTarihlerArasiKayitlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTarihlerArasiKayitlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkTarihlerArasiKayitlar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkTarihlerArasiKayitlar.Checked = false;
            this.checkTarihlerArasiKayitlar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkTarihlerArasiKayitlar.ForeColor = System.Drawing.Color.White;
            this.checkTarihlerArasiKayitlar.Location = new System.Drawing.Point(11, 61);
            this.checkTarihlerArasiKayitlar.Name = "checkTarihlerArasiKayitlar";
            this.checkTarihlerArasiKayitlar.Size = new System.Drawing.Size(20, 20);
            this.checkTarihlerArasiKayitlar.TabIndex = 55;
            this.checkTarihlerArasiKayitlar.OnChange += new System.EventHandler(this.checkTarihlerArasiKayitlar_OnChange);
            // 
            // lblTarihlerArasiKayitlar
            // 
            this.lblTarihlerArasiKayitlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarihlerArasiKayitlar.AutoSize = true;
            this.lblTarihlerArasiKayitlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTarihlerArasiKayitlar.ForeColor = System.Drawing.Color.White;
            this.lblTarihlerArasiKayitlar.Location = new System.Drawing.Point(35, 63);
            this.lblTarihlerArasiKayitlar.Name = "lblTarihlerArasiKayitlar";
            this.lblTarihlerArasiKayitlar.Size = new System.Drawing.Size(105, 13);
            this.lblTarihlerArasiKayitlar.TabIndex = 55;
            this.lblTarihlerArasiKayitlar.Text = "Tarihler Arası Kayıtlar";
            this.lblTarihlerArasiKayitlar.Click += new System.EventHandler(this.lblTarihlerArasiKayitlar_Click);
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
            this.lblMaxRows.Location = new System.Drawing.Point(742, 52);
            this.lblMaxRows.Name = "lblMaxRows";
            this.lblMaxRows.Size = new System.Drawing.Size(177, 13);
            this.lblMaxRows.TabIndex = 99;
            this.lblMaxRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmFaturaVeOdemeKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 644);
            this.Controls.Add(this.lblMaxRows);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagridFaturaVeOdemeKayitlari);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.lblKayitlariListesi);
            this.Name = "frmFaturaVeOdemeKayitlari";
            this.Text = "Fatura Ve Ödeme Kayıtları";
            ((System.ComponentModel.ISupportInitialize)(this.datagridFaturaVeOdemeKayitlari)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBoxGoster.ResumeLayout(false);
            this.grpBoxGoster.PerformLayout();
            this.cadrsKelime.ResumeLayout(false);
            this.cardTarihlerArasiKayitlar.ResumeLayout(false);
            this.cardTarihlerArasiKayitlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblKayitlariListesi;
        private Bunifu.Framework.UI.BunifuCheckbox checkOdeme;
        private Bunifu.Framework.UI.BunifuCheckbox checkFatura;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOdemeKayitlari;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFaturaKayitlari;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridFaturaVeOdemeKayitlari;
        private Bunifu.Framework.UI.BunifuThinButton2 btniptal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxGoster;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUygula;
        private Bunifu.Framework.UI.BunifuCheckbox checkKelime;
        private Bunifu.Framework.UI.BunifuCards cadrsKelime;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private Bunifu.Framework.UI.BunifuCustomLabel lblKayitlarKelime;
        private Bunifu.Framework.UI.BunifuCards cardTarihlerArasiKayitlar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker dateSonTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDatepicker dateilkTarih;
        private Bunifu.Framework.UI.BunifuCheckbox checkTarihlerArasiKayitlar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTarihlerArasiKayitlar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMaxRows;
    }
}