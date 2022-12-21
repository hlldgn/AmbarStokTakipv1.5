namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmTelefonRehber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefonRehber));
            this.lblTelefonListesi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridTelefonRehberListe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtIsletmeAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAdSoyad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTelefonNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFax = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEPosta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtVergiTC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTelefonNo2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTelefonRehberListe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTelefonListesi
            // 
            this.lblTelefonListesi.AutoSize = true;
            this.lblTelefonListesi.Location = new System.Drawing.Point(287, 38);
            this.lblTelefonListesi.Name = "lblTelefonListesi";
            this.lblTelefonListesi.Size = new System.Drawing.Size(119, 13);
            this.lblTelefonListesi.TabIndex = 41;
            this.lblTelefonListesi.Text = "Telefon Rehber Listesi :";
            // 
            // datagridTelefonRehberListe
            // 
            this.datagridTelefonRehberListe.AllowUserToAddRows = false;
            this.datagridTelefonRehberListe.AllowUserToDeleteRows = false;
            this.datagridTelefonRehberListe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridTelefonRehberListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridTelefonRehberListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridTelefonRehberListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridTelefonRehberListe.BackgroundColor = System.Drawing.Color.White;
            this.datagridTelefonRehberListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridTelefonRehberListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridTelefonRehberListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridTelefonRehberListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTelefonRehberListe.DoubleBuffered = true;
            this.datagridTelefonRehberListe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridTelefonRehberListe.EnableHeadersVisualStyles = false;
            this.datagridTelefonRehberListe.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridTelefonRehberListe.HeaderForeColor = System.Drawing.Color.White;
            this.datagridTelefonRehberListe.Location = new System.Drawing.Point(290, 54);
            this.datagridTelefonRehberListe.MultiSelect = false;
            this.datagridTelefonRehberListe.Name = "datagridTelefonRehberListe";
            this.datagridTelefonRehberListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridTelefonRehberListe.RowHeadersVisible = false;
            this.datagridTelefonRehberListe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridTelefonRehberListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridTelefonRehberListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridTelefonRehberListe.RowTemplate.Height = 33;
            this.datagridTelefonRehberListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTelefonRehberListe.Size = new System.Drawing.Size(847, 513);
            this.datagridTelefonRehberListe.TabIndex = 10;
            this.datagridTelefonRehberListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridTelefonRehberListe_CellDoubleClick);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(20, 38);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(64, 13);
            this.bunifuCustomLabel5.TabIndex = 38;
            this.bunifuCustomLabel5.Text = "İşletme Adı :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 100);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 13);
            this.bunifuCustomLabel1.TabIndex = 49;
            this.bunifuCustomLabel1.Text = "İlgili Kişi Adı Soyadı :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(20, 160);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(96, 13);
            this.bunifuCustomLabel2.TabIndex = 50;
            this.bunifuCustomLabel2.Text = "Telefon Numarası :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(20, 284);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(30, 13);
            this.bunifuCustomLabel3.TabIndex = 51;
            this.bunifuCustomLabel3.Text = "Fax :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(20, 350);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(50, 13);
            this.bunifuCustomLabel4.TabIndex = 52;
            this.bunifuCustomLabel4.Text = "E-Posta :";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(20, 416);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(109, 13);
            this.bunifuCustomLabel6.TabIndex = 53;
            this.bunifuCustomLabel6.Text = "Vergi/T.C. Numarası :";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(20, 466);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel7.TabIndex = 54;
            this.bunifuCustomLabel7.Text = "Adres :";
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.txtAra.Location = new System.Drawing.Point(290, 597);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(313, 33);
            this.txtAra.TabIndex = 9;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdres.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdres.Location = new System.Drawing.Point(34, 492);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(222, 62);
            this.txtAdres.TabIndex = 7;
            // 
            // txtIsletmeAdi
            // 
            this.txtIsletmeAdi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtIsletmeAdi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIsletmeAdi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtIsletmeAdi.BorderThickness = 3;
            this.txtIsletmeAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIsletmeAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIsletmeAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIsletmeAdi.isPassword = false;
            this.txtIsletmeAdi.Location = new System.Drawing.Point(23, 54);
            this.txtIsletmeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsletmeAdi.Name = "txtIsletmeAdi";
            this.txtIsletmeAdi.Size = new System.Drawing.Size(242, 30);
            this.txtIsletmeAdi.TabIndex = 0;
            this.txtIsletmeAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Enabled = false;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(23, 482);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(242, 85);
            this.bunifuMetroTextbox1.TabIndex = 56;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAdSoyad.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdSoyad.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAdSoyad.BorderThickness = 3;
            this.txtAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdSoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdSoyad.isPassword = false;
            this.txtAdSoyad.Location = new System.Drawing.Point(23, 117);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(242, 30);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTelefonNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefonNo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTelefonNo.BorderThickness = 3;
            this.txtTelefonNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefonNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefonNo.isPassword = false;
            this.txtTelefonNo.Location = new System.Drawing.Point(23, 177);
            this.txtTelefonNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(242, 30);
            this.txtTelefonNo.TabIndex = 2;
            this.txtTelefonNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefonNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonNo_KeyPress);
            // 
            // txtFax
            // 
            this.txtFax.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFax.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFax.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtFax.BorderThickness = 3;
            this.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFax.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFax.isPassword = false;
            this.txtFax.Location = new System.Drawing.Point(23, 301);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(242, 30);
            this.txtFax.TabIndex = 4;
            this.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFax_KeyPress);
            // 
            // txtEPosta
            // 
            this.txtEPosta.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtEPosta.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEPosta.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtEPosta.BorderThickness = 3;
            this.txtEPosta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEPosta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEPosta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEPosta.isPassword = false;
            this.txtEPosta.Location = new System.Drawing.Point(23, 367);
            this.txtEPosta.Margin = new System.Windows.Forms.Padding(4);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(242, 30);
            this.txtEPosta.TabIndex = 5;
            this.txtEPosta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEPosta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEPosta_KeyPress);
            // 
            // txtVergiTC
            // 
            this.txtVergiTC.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtVergiTC.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVergiTC.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtVergiTC.BorderThickness = 3;
            this.txtVergiTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVergiTC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtVergiTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVergiTC.isPassword = false;
            this.txtVergiTC.Location = new System.Drawing.Point(23, 433);
            this.txtVergiTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtVergiTC.Name = "txtVergiTC";
            this.txtVergiTC.Size = new System.Drawing.Size(242, 30);
            this.txtVergiTC.TabIndex = 6;
            this.txtVergiTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVergiTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVergiTC_KeyPress);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveBorderThickness = 1;
            this.btnKaydet.ActiveCornerRadius = 20;
            this.btnKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.BackColor = System.Drawing.Color.White;
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
            this.btnKaydet.Location = new System.Drawing.Point(34, 589);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(211, 41);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTelefonNo2
            // 
            this.txtTelefonNo2.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTelefonNo2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefonNo2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTelefonNo2.BorderThickness = 3;
            this.txtTelefonNo2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonNo2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefonNo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefonNo2.isPassword = false;
            this.txtTelefonNo2.Location = new System.Drawing.Point(23, 238);
            this.txtTelefonNo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonNo2.Name = "txtTelefonNo2";
            this.txtTelefonNo2.Size = new System.Drawing.Size(242, 30);
            this.txtTelefonNo2.TabIndex = 3;
            this.txtTelefonNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefonNo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonNo2_KeyPress);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(20, 221);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(99, 13);
            this.bunifuCustomLabel8.TabIndex = 62;
            this.bunifuCustomLabel8.Text = "Telefon Numarası  :";
            // 
            // frmTelefonRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.txtTelefonNo2);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.txtVergiTC);
            this.Controls.Add(this.txtEPosta);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblTelefonListesi);
            this.Controls.Add(this.datagridTelefonRehberListe);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.txtIsletmeAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelefonRehber";
            this.Text = "Telefon Rehberi";
            ((System.ComponentModel.ISupportInitialize)(this.datagridTelefonRehberListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelefonListesi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridTelefonRehberListe;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKaydet;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private System.Windows.Forms.TextBox txtAdres;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIsletmeAdi;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAdSoyad;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTelefonNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFax;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEPosta;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtVergiTC;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTelefonNo2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
    }
}