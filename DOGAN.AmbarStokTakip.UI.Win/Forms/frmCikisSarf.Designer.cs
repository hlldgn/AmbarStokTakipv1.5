namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmCikisSarf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCikisSarf));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateSarfTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtBirim = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbTeslimEdilenKisi = new System.Windows.Forms.ComboBox();
            this.btnileri = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTasinir = new System.Windows.Forms.Label();
            this.checkTasinir = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblToplam = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridCikisSarf = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridDepoUrunList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCikisSarf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDepoUrunList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-11, -29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dateSarfTarih);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage1.Controls.Add(this.txtBirim);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage1.Controls.Add(this.cmbTeslimEdilenKisi);
            this.tabPage1.Controls.Add(this.btnileri);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // dateSarfTarih
            // 
            this.dateSarfTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateSarfTarih.BackColor = System.Drawing.Color.SeaGreen;
            this.dateSarfTarih.BorderRadius = 0;
            this.dateSarfTarih.ForeColor = System.Drawing.Color.White;
            this.dateSarfTarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateSarfTarih.FormatCustom = null;
            this.dateSarfTarih.Location = new System.Drawing.Point(485, 116);
            this.dateSarfTarih.Name = "dateSarfTarih";
            this.dateSarfTarih.Size = new System.Drawing.Size(303, 36);
            this.dateSarfTarih.TabIndex = 32;
            this.dateSarfTarih.Value = new System.DateTime(2022, 2, 1, 13, 53, 4, 194);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(482, 233);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(37, 13);
            this.bunifuCustomLabel2.TabIndex = 86;
            this.bunifuCustomLabel2.Text = "Birimi :";
            // 
            // txtBirim
            // 
            this.txtBirim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBirim.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBirim.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBirim.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBirim.BorderThickness = 3;
            this.txtBirim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirim.Enabled = false;
            this.txtBirim.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBirim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBirim.isPassword = false;
            this.txtBirim.Location = new System.Drawing.Point(485, 250);
            this.txtBirim.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(303, 30);
            this.txtBirim.TabIndex = 85;
            this.txtBirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(482, 169);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(106, 13);
            this.bunifuCustomLabel1.TabIndex = 84;
            this.bunifuCustomLabel1.Text = "Teslim Edilecek Kişi :";
            // 
            // cmbTeslimEdilenKisi
            // 
            this.cmbTeslimEdilenKisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTeslimEdilenKisi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbTeslimEdilenKisi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeslimEdilenKisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeslimEdilenKisi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbTeslimEdilenKisi.FormattingEnabled = true;
            this.cmbTeslimEdilenKisi.Location = new System.Drawing.Point(485, 185);
            this.cmbTeslimEdilenKisi.Name = "cmbTeslimEdilenKisi";
            this.cmbTeslimEdilenKisi.Size = new System.Drawing.Size(303, 25);
            this.cmbTeslimEdilenKisi.TabIndex = 83;
            this.cmbTeslimEdilenKisi.SelectionChangeCommitted += new System.EventHandler(this.cmbTeslimEdilenKisi_SelectionChangeCommitted);
            // 
            // btnileri
            // 
            this.btnileri.ActiveBorderThickness = 1;
            this.btnileri.ActiveCornerRadius = 20;
            this.btnileri.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnileri.ActiveForecolor = System.Drawing.Color.White;
            this.btnileri.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnileri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnileri.BackColor = System.Drawing.Color.White;
            this.btnileri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnileri.BackgroundImage")));
            this.btnileri.ButtonText = "İleri";
            this.btnileri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnileri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnileri.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnileri.IdleBorderThickness = 1;
            this.btnileri.IdleCornerRadius = 20;
            this.btnileri.IdleFillColor = System.Drawing.Color.White;
            this.btnileri.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnileri.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnileri.Location = new System.Drawing.Point(532, 311);
            this.btnileri.Margin = new System.Windows.Forms.Padding(5);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(211, 41);
            this.btnileri.TabIndex = 82;
            this.btnileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnileri.Click += new System.EventHandler(this.btnileri_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(482, 100);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(125, 13);
            this.bunifuCustomLabel3.TabIndex = 81;
            this.bunifuCustomLabel3.Text = "Sarf Malzeme Çıkış Tarihi";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTasinir);
            this.tabPage2.Controls.Add(this.checkTasinir);
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Controls.Add(this.lblToplam);
            this.tabPage2.Controls.Add(this.datagridCikisSarf);
            this.tabPage2.Controls.Add(this.txtAra);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel18);
            this.tabPage2.Controls.Add(this.datagridDepoUrunList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1161, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTasinir
            // 
            this.lblTasinir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTasinir.AutoSize = true;
            this.lblTasinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTasinir.Location = new System.Drawing.Point(555, 580);
            this.lblTasinir.Name = "lblTasinir";
            this.lblTasinir.Size = new System.Drawing.Size(122, 13);
            this.lblTasinir.TabIndex = 82;
            this.lblTasinir.Text = "Taşınır İşlem Fişi Oluştur.";
            this.lblTasinir.Click += new System.EventHandler(this.lblTasinir_Click);
            // 
            // checkTasinir
            // 
            this.checkTasinir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkTasinir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkTasinir.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkTasinir.Checked = true;
            this.checkTasinir.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkTasinir.ForeColor = System.Drawing.Color.White;
            this.checkTasinir.Location = new System.Drawing.Point(526, 577);
            this.checkTasinir.Name = "checkTasinir";
            this.checkTasinir.Size = new System.Drawing.Size(20, 20);
            this.checkTasinir.TabIndex = 81;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveBorderThickness = 1;
            this.btnKaydet.ActiveCornerRadius = 20;
            this.btnKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.ButtonText = "Kaydet";
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.IdleBorderThickness = 1;
            this.btnKaydet.IdleCornerRadius = 20;
            this.btnKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnKaydet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.Location = new System.Drawing.Point(492, 596);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(211, 41);
            this.btnKaydet.TabIndex = 80;
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.White;
            this.lblToplam.Location = new System.Drawing.Point(17, 554);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(1125, 18);
            this.lblToplam.TabIndex = 79;
            this.lblToplam.Text = "Toplam : 0";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // datagridCikisSarf
            // 
            this.datagridCikisSarf.AllowUserToAddRows = false;
            this.datagridCikisSarf.AllowUserToDeleteRows = false;
            this.datagridCikisSarf.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridCikisSarf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridCikisSarf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridCikisSarf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridCikisSarf.BackgroundColor = System.Drawing.Color.White;
            this.datagridCikisSarf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridCikisSarf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridCikisSarf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridCikisSarf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCikisSarf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UrunAdi,
            this.Birim,
            this.BirimFiyat,
            this.Miktar,
            this.ToplamTutar});
            this.datagridCikisSarf.DoubleBuffered = true;
            this.datagridCikisSarf.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridCikisSarf.EnableHeadersVisualStyles = false;
            this.datagridCikisSarf.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridCikisSarf.HeaderForeColor = System.Drawing.Color.White;
            this.datagridCikisSarf.Location = new System.Drawing.Point(17, 365);
            this.datagridCikisSarf.MultiSelect = false;
            this.datagridCikisSarf.Name = "datagridCikisSarf";
            this.datagridCikisSarf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridCikisSarf.RowHeadersVisible = false;
            this.datagridCikisSarf.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridCikisSarf.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridCikisSarf.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridCikisSarf.RowTemplate.Height = 33;
            this.datagridCikisSarf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCikisSarf.Size = new System.Drawing.Size(1125, 186);
            this.datagridCikisSarf.TabIndex = 77;
            this.datagridCikisSarf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datagridCikisSarf_KeyDown);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // Birim
            // 
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.HeaderText = "Birim Fiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Düşülen Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // ToplamTutar
            // 
            this.ToplamTutar.HeaderText = "Toplam Tutar";
            this.ToplamTutar.Name = "ToplamTutar";
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
            this.txtAra.Location = new System.Drawing.Point(20, 325);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(231, 33);
            this.txtAra.TabIndex = 74;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
            this.txtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAra_KeyPress);
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(16, 28);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(97, 13);
            this.bunifuCustomLabel18.TabIndex = 72;
            this.bunifuCustomLabel18.Text = "Depo Ürün Listesi :";
            // 
            // datagridDepoUrunList
            // 
            this.datagridDepoUrunList.AllowUserToAddRows = false;
            this.datagridDepoUrunList.AllowUserToDeleteRows = false;
            this.datagridDepoUrunList.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridDepoUrunList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridDepoUrunList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridDepoUrunList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridDepoUrunList.BackgroundColor = System.Drawing.Color.White;
            this.datagridDepoUrunList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridDepoUrunList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridDepoUrunList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridDepoUrunList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDepoUrunList.DoubleBuffered = true;
            this.datagridDepoUrunList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridDepoUrunList.EnableHeadersVisualStyles = false;
            this.datagridDepoUrunList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridDepoUrunList.HeaderForeColor = System.Drawing.Color.White;
            this.datagridDepoUrunList.Location = new System.Drawing.Point(19, 44);
            this.datagridDepoUrunList.MultiSelect = false;
            this.datagridDepoUrunList.Name = "datagridDepoUrunList";
            this.datagridDepoUrunList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridDepoUrunList.RowHeadersVisible = false;
            this.datagridDepoUrunList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridDepoUrunList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridDepoUrunList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridDepoUrunList.RowTemplate.Height = 33;
            this.datagridDepoUrunList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridDepoUrunList.Size = new System.Drawing.Size(1123, 274);
            this.datagridDepoUrunList.TabIndex = 71;
            this.datagridDepoUrunList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridDepoUrunList_CellDoubleClick);
            // 
            // frmCikisSarf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCikisSarf";
            this.Text = "Sarf Malzeme Çıkış";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCikisSarf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDepoUrunList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnileri;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cmbTeslimEdilenKisi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBirim;
        private Bunifu.Framework.UI.BunifuDatepicker dateSarfTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridDepoUrunList;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKaydet;
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridCikisSarf;
        private Bunifu.Framework.UI.BunifuCustomLabel lblToplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamTutar;
        private System.Windows.Forms.Label lblTasinir;
        private Bunifu.Framework.UI.BunifuCheckbox checkTasinir;
    }
}