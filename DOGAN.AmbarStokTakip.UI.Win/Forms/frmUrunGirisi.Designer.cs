
namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmUrunGirisi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunGirisi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridAlimicerik = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datagridAlimListesi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnİlerle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTumunuSec = new System.Windows.Forms.Label();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMuyaneKabul = new System.Windows.Forms.Label();
            this.checkMuayeneKabul = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblToplamUrun = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbDepo = new System.Windows.Forms.ComboBox();
            this.btnSonKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateUrunKayitTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridUrunKayit = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalanMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlinanMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAlimicerik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAlimListesi)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUrunKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 323);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(60, 13);
            this.bunifuCustomLabel1.TabIndex = 37;
            this.bunifuCustomLabel1.Text = "Alım İçeriği:";
            // 
            // datagridAlimicerik
            // 
            this.datagridAlimicerik.AllowUserToAddRows = false;
            this.datagridAlimicerik.AllowUserToDeleteRows = false;
            this.datagridAlimicerik.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridAlimicerik.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridAlimicerik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridAlimicerik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridAlimicerik.BackgroundColor = System.Drawing.Color.White;
            this.datagridAlimicerik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridAlimicerik.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAlimicerik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridAlimicerik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAlimicerik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sec});
            this.datagridAlimicerik.DoubleBuffered = true;
            this.datagridAlimicerik.EnableHeadersVisualStyles = false;
            this.datagridAlimicerik.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridAlimicerik.HeaderForeColor = System.Drawing.Color.White;
            this.datagridAlimicerik.Location = new System.Drawing.Point(15, 369);
            this.datagridAlimicerik.MultiSelect = false;
            this.datagridAlimicerik.Name = "datagridAlimicerik";
            this.datagridAlimicerik.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridAlimicerik.RowHeadersVisible = false;
            this.datagridAlimicerik.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridAlimicerik.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridAlimicerik.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridAlimicerik.RowTemplate.Height = 33;
            this.datagridAlimicerik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridAlimicerik.Size = new System.Drawing.Size(1126, 216);
            this.datagridAlimicerik.TabIndex = 36;
            // 
            // sec
            // 
            this.sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sec.HeaderText = "Seç";
            this.sec.Name = "sec";
            this.sec.Width = 150;
            // 
            // datagridAlimListesi
            // 
            this.datagridAlimListesi.AllowUserToAddRows = false;
            this.datagridAlimListesi.AllowUserToDeleteRows = false;
            this.datagridAlimListesi.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridAlimListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridAlimListesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridAlimListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridAlimListesi.BackgroundColor = System.Drawing.Color.White;
            this.datagridAlimListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridAlimListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAlimListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridAlimListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAlimListesi.DoubleBuffered = true;
            this.datagridAlimListesi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridAlimListesi.EnableHeadersVisualStyles = false;
            this.datagridAlimListesi.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridAlimListesi.HeaderForeColor = System.Drawing.Color.White;
            this.datagridAlimListesi.Location = new System.Drawing.Point(15, 44);
            this.datagridAlimListesi.MultiSelect = false;
            this.datagridAlimListesi.Name = "datagridAlimListesi";
            this.datagridAlimListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridAlimListesi.RowHeadersVisible = false;
            this.datagridAlimListesi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridAlimListesi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridAlimListesi.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridAlimListesi.RowTemplate.Height = 33;
            this.datagridAlimListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridAlimListesi.Size = new System.Drawing.Size(1126, 216);
            this.datagridAlimListesi.TabIndex = 38;
            this.datagridAlimListesi.SelectionChanged += new System.EventHandler(this.datagridAlimListesi_SelectionChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(19, 28);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(64, 13);
            this.bunifuCustomLabel2.TabIndex = 39;
            this.bunifuCustomLabel2.Text = "Alım Listesi :";
            // 
            // btnİlerle
            // 
            this.btnİlerle.ActiveBorderThickness = 1;
            this.btnİlerle.ActiveCornerRadius = 20;
            this.btnİlerle.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnİlerle.ActiveForecolor = System.Drawing.Color.White;
            this.btnİlerle.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnİlerle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnİlerle.BackColor = System.Drawing.Color.White;
            this.btnİlerle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnİlerle.BackgroundImage")));
            this.btnİlerle.ButtonText = "İlerle";
            this.btnİlerle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnİlerle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİlerle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnİlerle.IdleBorderThickness = 1;
            this.btnİlerle.IdleCornerRadius = 20;
            this.btnİlerle.IdleFillColor = System.Drawing.Color.White;
            this.btnİlerle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnİlerle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnİlerle.Location = new System.Drawing.Point(470, 596);
            this.btnİlerle.Margin = new System.Windows.Forms.Padding(5);
            this.btnİlerle.Name = "btnİlerle";
            this.btnİlerle.Size = new System.Drawing.Size(211, 41);
            this.btnİlerle.TabIndex = 40;
            this.btnİlerle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnİlerle.Click += new System.EventHandler(this.btnİlerle_Click);
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
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblTumunuSec);
            this.tabPage1.Controls.Add(this.txtAra);
            this.tabPage1.Controls.Add(this.btnİlerle);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage1.Controls.Add(this.datagridAlimListesi);
            this.tabPage1.Controls.Add(this.datagridAlimicerik);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // lblTumunuSec
            // 
            this.lblTumunuSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblTumunuSec.ForeColor = System.Drawing.Color.White;
            this.lblTumunuSec.Location = new System.Drawing.Point(16, 341);
            this.lblTumunuSec.Name = "lblTumunuSec";
            this.lblTumunuSec.Size = new System.Drawing.Size(76, 25);
            this.lblTumunuSec.TabIndex = 42;
            this.lblTumunuSec.Text = "Tümünü Seç";
            this.lblTumunuSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTumunuSec.Click += new System.EventHandler(this.lblTumunuSec_Click);
            // 
            // txtAra
            // 
            this.txtAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAra.HintForeColor = System.Drawing.Color.Empty;
            this.txtAra.HintText = "Ara";
            this.txtAra.isPassword = false;
            this.txtAra.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAra.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAra.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAra.LineThickness = 3;
            this.txtAra.Location = new System.Drawing.Point(15, 267);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(379, 33);
            this.txtAra.TabIndex = 41;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMuyaneKabul);
            this.tabPage2.Controls.Add(this.checkMuayeneKabul);
            this.tabPage2.Controls.Add(this.lblToplamUrun);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel7);
            this.tabPage2.Controls.Add(this.cmbDepo);
            this.tabPage2.Controls.Add(this.btnSonKaydet);
            this.tabPage2.Controls.Add(this.dateUrunKayitTarih);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage2.Controls.Add(this.datagridUrunKayit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1161, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblMuyaneKabul
            // 
            this.lblMuyaneKabul.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMuyaneKabul.AutoSize = true;
            this.lblMuyaneKabul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuyaneKabul.Location = new System.Drawing.Point(523, 578);
            this.lblMuyaneKabul.Name = "lblMuyaneKabul";
            this.lblMuyaneKabul.Size = new System.Drawing.Size(153, 13);
            this.lblMuyaneKabul.TabIndex = 35;
            this.lblMuyaneKabul.Text = "Muayene Kabul Evrağı Oluştur.";
            this.lblMuyaneKabul.Click += new System.EventHandler(this.lblMuyaneKabul_Click);
            // 
            // checkMuayeneKabul
            // 
            this.checkMuayeneKabul.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkMuayeneKabul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkMuayeneKabul.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkMuayeneKabul.Checked = true;
            this.checkMuayeneKabul.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkMuayeneKabul.ForeColor = System.Drawing.Color.White;
            this.checkMuayeneKabul.Location = new System.Drawing.Point(493, 576);
            this.checkMuayeneKabul.Name = "checkMuayeneKabul";
            this.checkMuayeneKabul.Size = new System.Drawing.Size(20, 20);
            this.checkMuayeneKabul.TabIndex = 34;
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplamUrun.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblToplamUrun.ForeColor = System.Drawing.Color.DarkRed;
            this.lblToplamUrun.Location = new System.Drawing.Point(939, 215);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(206, 23);
            this.lblToplamUrun.TabIndex = 33;
            this.lblToplamUrun.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(438, 133);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(76, 13);
            this.bunifuCustomLabel7.TabIndex = 31;
            this.bunifuCustomLabel7.Text = "Depo Seçiniz :";
            // 
            // cmbDepo
            // 
            this.cmbDepo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepo.FormattingEnabled = true;
            this.cmbDepo.Location = new System.Drawing.Point(441, 149);
            this.cmbDepo.Name = "cmbDepo";
            this.cmbDepo.Size = new System.Drawing.Size(303, 25);
            this.cmbDepo.TabIndex = 32;
            // 
            // btnSonKaydet
            // 
            this.btnSonKaydet.ActiveBorderThickness = 1;
            this.btnSonKaydet.ActiveCornerRadius = 20;
            this.btnSonKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSonKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnSonKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSonKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSonKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnSonKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSonKaydet.BackgroundImage")));
            this.btnSonKaydet.ButtonText = "Kaydet";
            this.btnSonKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSonKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSonKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSonKaydet.IdleBorderThickness = 1;
            this.btnSonKaydet.IdleCornerRadius = 20;
            this.btnSonKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnSonKaydet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSonKaydet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSonKaydet.Location = new System.Drawing.Point(476, 596);
            this.btnSonKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnSonKaydet.Name = "btnSonKaydet";
            this.btnSonKaydet.Size = new System.Drawing.Size(211, 41);
            this.btnSonKaydet.TabIndex = 30;
            this.btnSonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSonKaydet.Click += new System.EventHandler(this.btnSonKaydet_Click);
            // 
            // dateUrunKayitTarih
            // 
            this.dateUrunKayitTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateUrunKayitTarih.BackColor = System.Drawing.Color.SeaGreen;
            this.dateUrunKayitTarih.BorderRadius = 0;
            this.dateUrunKayitTarih.ForeColor = System.Drawing.Color.White;
            this.dateUrunKayitTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateUrunKayitTarih.FormatCustom = null;
            this.dateUrunKayitTarih.Location = new System.Drawing.Point(441, 74);
            this.dateUrunKayitTarih.Name = "dateUrunKayitTarih";
            this.dateUrunKayitTarih.Size = new System.Drawing.Size(303, 36);
            this.dateUrunKayitTarih.TabIndex = 28;
            this.dateUrunKayitTarih.Value = new System.DateTime(2022, 2, 2, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(438, 58);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(65, 13);
            this.bunifuCustomLabel3.TabIndex = 29;
            this.bunifuCustomLabel3.Text = "Kayıt Tarihi :";
            // 
            // datagridUrunKayit
            // 
            this.datagridUrunKayit.AllowUserToAddRows = false;
            this.datagridUrunKayit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridUrunKayit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridUrunKayit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridUrunKayit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridUrunKayit.BackgroundColor = System.Drawing.Color.White;
            this.datagridUrunKayit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridUrunKayit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridUrunKayit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridUrunKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridUrunKayit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AlimId,
            this.UrunAdi,
            this.Birim,
            this.BirimFiyat,
            this.KalanMiktar,
            this.AlinanMiktar,
            this.ToplamTutar});
            this.datagridUrunKayit.DoubleBuffered = true;
            this.datagridUrunKayit.EnableHeadersVisualStyles = false;
            this.datagridUrunKayit.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridUrunKayit.HeaderForeColor = System.Drawing.Color.White;
            this.datagridUrunKayit.Location = new System.Drawing.Point(19, 241);
            this.datagridUrunKayit.MultiSelect = false;
            this.datagridUrunKayit.Name = "datagridUrunKayit";
            this.datagridUrunKayit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridUrunKayit.RowHeadersVisible = false;
            this.datagridUrunKayit.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridUrunKayit.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridUrunKayit.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridUrunKayit.RowTemplate.Height = 33;
            this.datagridUrunKayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridUrunKayit.Size = new System.Drawing.Size(1126, 312);
            this.datagridUrunKayit.TabIndex = 14;
            this.datagridUrunKayit.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridUrunKayit_CellEndEdit);
            this.datagridUrunKayit.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.datagridUrunKayit_EditingControlShowing);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // AlimId
            // 
            this.AlimId.HeaderText = "AlimId";
            this.AlimId.Name = "AlimId";
            this.AlimId.ReadOnly = true;
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            // 
            // Birim
            // 
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            this.Birim.ReadOnly = true;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.HeaderText = "Birim Fiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.ReadOnly = true;
            // 
            // KalanMiktar
            // 
            this.KalanMiktar.HeaderText = "Kalan Miktar";
            this.KalanMiktar.Name = "KalanMiktar";
            this.KalanMiktar.ReadOnly = true;
            // 
            // AlinanMiktar
            // 
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.AlinanMiktar.DefaultCellStyle = dataGridViewCellStyle7;
            this.AlinanMiktar.HeaderText = "Alınan Miktar";
            this.AlinanMiktar.Name = "AlinanMiktar";
            // 
            // ToplamTutar
            // 
            dataGridViewCellStyle8.Format = "N5";
            dataGridViewCellStyle8.NullValue = null;
            this.ToplamTutar.DefaultCellStyle = dataGridViewCellStyle8;
            this.ToplamTutar.HeaderText = "Toplam Tutar";
            this.ToplamTutar.Name = "ToplamTutar";
            this.ToplamTutar.ReadOnly = true;
            // 
            // frmUrunGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUrunGirisi";
            this.Text = "Ürün Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.datagridAlimicerik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAlimListesi)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUrunKayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridAlimicerik;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridAlimListesi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnİlerle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridUrunKayit;
        private Bunifu.Framework.UI.BunifuDatepicker dateUrunKayitTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSonKaydet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sec;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.ComboBox cmbDepo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlimId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalanMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlinanMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamTutar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblToplamUrun;
        private System.Windows.Forms.Label lblTumunuSec;
        private System.Windows.Forms.Label lblMuyaneKabul;
        private Bunifu.Framework.UI.BunifuCheckbox checkMuayeneKabul;
    }
}