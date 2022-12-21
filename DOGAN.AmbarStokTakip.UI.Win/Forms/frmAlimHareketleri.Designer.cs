namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmAlimHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlimHareketleri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkProgramDeleted = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkUserDeleted = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblmiktarbitmisalim = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbliptaledilmisalim = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUygula = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkKelime = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cadrsKelime = new Bunifu.Framework.UI.BunifuCards();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAlimKayitlariKelime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cardTarihlerArasiAlimKayitlari = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateSonTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateilkTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.checkTarihlerArasiAlimKayitlari = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblTarihlerArasiAlimKayitlari = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAlimicerigi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAlimlar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridHareketAlimListesi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.datagridAlimicerik = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblMaxRows = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.cadrsKelime.SuspendLayout();
            this.cardTarihlerArasiAlimKayitlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridHareketAlimListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAlimicerik)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.checkProgramDeleted);
            this.panel1.Controls.Add(this.checkUserDeleted);
            this.panel1.Controls.Add(this.lblmiktarbitmisalim);
            this.panel1.Controls.Add(this.lbliptaledilmisalim);
            this.panel1.Controls.Add(this.btnUygula);
            this.panel1.Controls.Add(this.checkKelime);
            this.panel1.Controls.Add(this.cadrsKelime);
            this.panel1.Controls.Add(this.lblAlimKayitlariKelime);
            this.panel1.Controls.Add(this.cardTarihlerArasiAlimKayitlari);
            this.panel1.Controls.Add(this.checkTarihlerArasiAlimKayitlari);
            this.panel1.Controls.Add(this.lblTarihlerArasiAlimKayitlari);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(943, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 644);
            this.panel1.TabIndex = 43;
            // 
            // checkProgramDeleted
            // 
            this.checkProgramDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkProgramDeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkProgramDeleted.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkProgramDeleted.Checked = false;
            this.checkProgramDeleted.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkProgramDeleted.ForeColor = System.Drawing.Color.White;
            this.checkProgramDeleted.Location = new System.Drawing.Point(12, 227);
            this.checkProgramDeleted.Name = "checkProgramDeleted";
            this.checkProgramDeleted.Size = new System.Drawing.Size(20, 20);
            this.checkProgramDeleted.TabIndex = 60;
            // 
            // checkUserDeleted
            // 
            this.checkUserDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkUserDeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkUserDeleted.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkUserDeleted.Checked = false;
            this.checkUserDeleted.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkUserDeleted.ForeColor = System.Drawing.Color.White;
            this.checkUserDeleted.Location = new System.Drawing.Point(12, 197);
            this.checkUserDeleted.Name = "checkUserDeleted";
            this.checkUserDeleted.Size = new System.Drawing.Size(20, 20);
            this.checkUserDeleted.TabIndex = 58;
            // 
            // lblmiktarbitmisalim
            // 
            this.lblmiktarbitmisalim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmiktarbitmisalim.AutoSize = true;
            this.lblmiktarbitmisalim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblmiktarbitmisalim.ForeColor = System.Drawing.Color.White;
            this.lblmiktarbitmisalim.Location = new System.Drawing.Point(36, 229);
            this.lblmiktarbitmisalim.Name = "lblmiktarbitmisalim";
            this.lblmiktarbitmisalim.Size = new System.Drawing.Size(137, 13);
            this.lblmiktarbitmisalim.TabIndex = 61;
            this.lblmiktarbitmisalim.Text = "Miktarı Bitmiş Alımları Göster";
            this.lblmiktarbitmisalim.Click += new System.EventHandler(this.lblmiktarbitmisalim_Click);
            // 
            // lbliptaledilmisalim
            // 
            this.lbliptaledilmisalim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbliptaledilmisalim.AutoSize = true;
            this.lbliptaledilmisalim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbliptaledilmisalim.ForeColor = System.Drawing.Color.White;
            this.lbliptaledilmisalim.Location = new System.Drawing.Point(36, 199);
            this.lbliptaledilmisalim.Name = "lbliptaledilmisalim";
            this.lbliptaledilmisalim.Size = new System.Drawing.Size(131, 13);
            this.lbliptaledilmisalim.TabIndex = 59;
            this.lbliptaledilmisalim.Text = "İptal Edilmiş Alımları Göster";
            this.lbliptaledilmisalim.Click += new System.EventHandler(this.lbliptaledilmisalim_Click);
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
            this.btnUygula.Location = new System.Drawing.Point(16, 577);
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
            this.checkKelime.Location = new System.Drawing.Point(12, 127);
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
            this.cadrsKelime.Location = new System.Drawing.Point(0, 157);
            this.cadrsKelime.Name = "cadrsKelime";
            this.cadrsKelime.RightSahddow = true;
            this.cadrsKelime.ShadowDepth = 20;
            this.cadrsKelime.Size = new System.Drawing.Size(215, 10);
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
            // lblAlimKayitlariKelime
            // 
            this.lblAlimKayitlariKelime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlimKayitlariKelime.AutoSize = true;
            this.lblAlimKayitlariKelime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlimKayitlariKelime.ForeColor = System.Drawing.Color.White;
            this.lblAlimKayitlariKelime.Location = new System.Drawing.Point(36, 129);
            this.lblAlimKayitlariKelime.Name = "lblAlimKayitlariKelime";
            this.lblAlimKayitlariKelime.Size = new System.Drawing.Size(116, 13);
            this.lblAlimKayitlariKelime.TabIndex = 57;
            this.lblAlimKayitlariKelime.Text = "Alım Kayıtları İçinde Ara";
            this.lblAlimKayitlariKelime.Click += new System.EventHandler(this.lblAlimKayitlariKelime_Click);
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
            this.cardTarihlerArasiAlimKayitlari.Size = new System.Drawing.Size(215, 10);
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
            this.dateSonTarih.Location = new System.Drawing.Point(16, 92);
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
            this.dateilkTarih.Location = new System.Drawing.Point(16, 37);
            this.dateilkTarih.Name = "dateilkTarih";
            this.dateilkTarih.Size = new System.Drawing.Size(183, 36);
            this.dateilkTarih.TabIndex = 45;
            this.dateilkTarih.Value = new System.DateTime(2022, 2, 1, 13, 53, 4, 194);
            // 
            // checkTarihlerArasiAlimKayitlari
            // 
            this.checkTarihlerArasiAlimKayitlari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTarihlerArasiAlimKayitlari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkTarihlerArasiAlimKayitlari.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkTarihlerArasiAlimKayitlari.Checked = false;
            this.checkTarihlerArasiAlimKayitlari.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkTarihlerArasiAlimKayitlari.ForeColor = System.Drawing.Color.White;
            this.checkTarihlerArasiAlimKayitlari.Location = new System.Drawing.Point(12, 61);
            this.checkTarihlerArasiAlimKayitlari.Name = "checkTarihlerArasiAlimKayitlari";
            this.checkTarihlerArasiAlimKayitlari.Size = new System.Drawing.Size(20, 20);
            this.checkTarihlerArasiAlimKayitlari.TabIndex = 55;
            this.checkTarihlerArasiAlimKayitlari.OnChange += new System.EventHandler(this.checkTarihlerArasiAlimKayitlari_OnChange);
            // 
            // lblTarihlerArasiAlimKayitlari
            // 
            this.lblTarihlerArasiAlimKayitlari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarihlerArasiAlimKayitlari.AutoSize = true;
            this.lblTarihlerArasiAlimKayitlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTarihlerArasiAlimKayitlari.ForeColor = System.Drawing.Color.White;
            this.lblTarihlerArasiAlimKayitlari.Location = new System.Drawing.Point(36, 63);
            this.lblTarihlerArasiAlimKayitlari.Name = "lblTarihlerArasiAlimKayitlari";
            this.lblTarihlerArasiAlimKayitlari.Size = new System.Drawing.Size(129, 13);
            this.lblTarihlerArasiAlimKayitlari.TabIndex = 55;
            this.lblTarihlerArasiAlimKayitlari.Text = "Tarihler Arası Alım Kayıtları";
            this.lblTarihlerArasiAlimKayitlari.Click += new System.EventHandler(this.lblTarihlerArasiAlimKayitlari_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(84, 22);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(46, 13);
            this.bunifuCustomLabel3.TabIndex = 54;
            this.bunifuCustomLabel3.Text = "Filtreler :";
            // 
            // lblAlimicerigi
            // 
            this.lblAlimicerigi.AutoSize = true;
            this.lblAlimicerigi.Location = new System.Drawing.Point(12, 288);
            this.lblAlimicerigi.Name = "lblAlimicerigi";
            this.lblAlimicerigi.Size = new System.Drawing.Size(63, 13);
            this.lblAlimicerigi.TabIndex = 51;
            this.lblAlimicerigi.Text = "Alım İçeriği :";
            // 
            // lblAlimlar
            // 
            this.lblAlimlar.AutoSize = true;
            this.lblAlimlar.Location = new System.Drawing.Point(12, 22);
            this.lblAlimlar.Name = "lblAlimlar";
            this.lblAlimlar.Size = new System.Drawing.Size(43, 13);
            this.lblAlimlar.TabIndex = 50;
            this.lblAlimlar.Text = "Alımlar :";
            // 
            // datagridHareketAlimListesi
            // 
            this.datagridHareketAlimListesi.AllowUserToAddRows = false;
            this.datagridHareketAlimListesi.AllowUserToDeleteRows = false;
            this.datagridHareketAlimListesi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridHareketAlimListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridHareketAlimListesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridHareketAlimListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridHareketAlimListesi.BackgroundColor = System.Drawing.Color.White;
            this.datagridHareketAlimListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridHareketAlimListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridHareketAlimListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridHareketAlimListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridHareketAlimListesi.DoubleBuffered = true;
            this.datagridHareketAlimListesi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridHareketAlimListesi.EnableHeadersVisualStyles = false;
            this.datagridHareketAlimListesi.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridHareketAlimListesi.HeaderForeColor = System.Drawing.Color.White;
            this.datagridHareketAlimListesi.Location = new System.Drawing.Point(15, 38);
            this.datagridHareketAlimListesi.MultiSelect = false;
            this.datagridHareketAlimListesi.Name = "datagridHareketAlimListesi";
            this.datagridHareketAlimListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridHareketAlimListesi.RowHeadersVisible = false;
            this.datagridHareketAlimListesi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridHareketAlimListesi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridHareketAlimListesi.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridHareketAlimListesi.RowTemplate.Height = 33;
            this.datagridHareketAlimListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridHareketAlimListesi.Size = new System.Drawing.Size(922, 229);
            this.datagridHareketAlimListesi.TabIndex = 53;
            this.datagridHareketAlimListesi.SelectionChanged += new System.EventHandler(this.datagridHareketAlimListesi_SelectionChanged);
            // 
            // datagridAlimicerik
            // 
            this.datagridAlimicerik.AllowUserToAddRows = false;
            this.datagridAlimicerik.AllowUserToDeleteRows = false;
            this.datagridAlimicerik.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridAlimicerik.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridAlimicerik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridAlimicerik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridAlimicerik.BackgroundColor = System.Drawing.Color.White;
            this.datagridAlimicerik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridAlimicerik.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAlimicerik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridAlimicerik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAlimicerik.DoubleBuffered = true;
            this.datagridAlimicerik.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridAlimicerik.EnableHeadersVisualStyles = false;
            this.datagridAlimicerik.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridAlimicerik.HeaderForeColor = System.Drawing.Color.White;
            this.datagridAlimicerik.Location = new System.Drawing.Point(15, 305);
            this.datagridAlimicerik.MultiSelect = false;
            this.datagridAlimicerik.Name = "datagridAlimicerik";
            this.datagridAlimicerik.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridAlimicerik.RowHeadersVisible = false;
            this.datagridAlimicerik.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridAlimicerik.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridAlimicerik.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridAlimicerik.RowTemplate.Height = 33;
            this.datagridAlimicerik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridAlimicerik.Size = new System.Drawing.Size(922, 313);
            this.datagridAlimicerik.TabIndex = 52;
            // 
            // lblMaxRows
            // 
            this.lblMaxRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxRows.ForeColor = System.Drawing.Color.Crimson;
            this.lblMaxRows.Location = new System.Drawing.Point(760, 22);
            this.lblMaxRows.Name = "lblMaxRows";
            this.lblMaxRows.Size = new System.Drawing.Size(177, 13);
            this.lblMaxRows.TabIndex = 54;
            this.lblMaxRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAlimHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.lblMaxRows);
            this.Controls.Add(this.lblAlimicerigi);
            this.Controls.Add(this.lblAlimlar);
            this.Controls.Add(this.datagridHareketAlimListesi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagridAlimicerik);
            this.Name = "frmAlimHareketleri";
            this.Text = "Alım Hareketleri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cadrsKelime.ResumeLayout(false);
            this.cardTarihlerArasiAlimKayitlari.ResumeLayout(false);
            this.cardTarihlerArasiAlimKayitlari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridHareketAlimListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAlimicerik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAlimicerigi;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAlimlar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridHareketAlimListesi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridAlimicerik;
        private Bunifu.Framework.UI.BunifuCheckbox checkKelime;
        private Bunifu.Framework.UI.BunifuCards cadrsKelime;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAlimKayitlariKelime;
        private Bunifu.Framework.UI.BunifuCards cardTarihlerArasiAlimKayitlari;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker dateSonTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDatepicker dateilkTarih;
        private Bunifu.Framework.UI.BunifuCheckbox checkTarihlerArasiAlimKayitlari;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTarihlerArasiAlimKayitlari;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUygula;
        private Bunifu.Framework.UI.BunifuCheckbox checkUserDeleted;
        private Bunifu.Framework.UI.BunifuCustomLabel lbliptaledilmisalim;
        private Bunifu.Framework.UI.BunifuCheckbox checkProgramDeleted;
        private Bunifu.Framework.UI.BunifuCustomLabel lblmiktarbitmisalim;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMaxRows;
    }
}