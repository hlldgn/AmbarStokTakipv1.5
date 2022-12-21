namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmOtomatikiaseCikis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtomatikiaseCikis));
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.lbliaseYapilandirmaListesi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridOtomatikCikisListe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtAksam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtogle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSabah = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.checkHeriase = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkBanaBirak = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridOtomatikCikisListe)).BeginInit();
            this.SuspendLayout();
            // 
            // picDelete
            // 
            this.picDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDelete.Image = global::DOGAN.AmbarStokTakip.UI.Win.Properties.Resources.Delete;
            this.picDelete.Location = new System.Drawing.Point(1112, 361);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(26, 29);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 53;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // lbliaseYapilandirmaListesi
            // 
            this.lbliaseYapilandirmaListesi.AutoSize = true;
            this.lbliaseYapilandirmaListesi.Location = new System.Drawing.Point(12, 377);
            this.lbliaseYapilandirmaListesi.Name = "lbliaseYapilandirmaListesi";
            this.lbliaseYapilandirmaListesi.Size = new System.Drawing.Size(168, 13);
            this.lbliaseYapilandirmaListesi.TabIndex = 52;
            this.lbliaseYapilandirmaListesi.Text = "İaşe Yapılandırma Ayaraları Listesi:";
            // 
            // datagridOtomatikCikisListe
            // 
            this.datagridOtomatikCikisListe.AllowUserToAddRows = false;
            this.datagridOtomatikCikisListe.AllowUserToDeleteRows = false;
            this.datagridOtomatikCikisListe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridOtomatikCikisListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridOtomatikCikisListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridOtomatikCikisListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridOtomatikCikisListe.BackgroundColor = System.Drawing.Color.White;
            this.datagridOtomatikCikisListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridOtomatikCikisListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridOtomatikCikisListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridOtomatikCikisListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridOtomatikCikisListe.DoubleBuffered = true;
            this.datagridOtomatikCikisListe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridOtomatikCikisListe.EnableHeadersVisualStyles = false;
            this.datagridOtomatikCikisListe.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridOtomatikCikisListe.HeaderForeColor = System.Drawing.Color.White;
            this.datagridOtomatikCikisListe.Location = new System.Drawing.Point(12, 393);
            this.datagridOtomatikCikisListe.MultiSelect = false;
            this.datagridOtomatikCikisListe.Name = "datagridOtomatikCikisListe";
            this.datagridOtomatikCikisListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridOtomatikCikisListe.RowHeadersVisible = false;
            this.datagridOtomatikCikisListe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridOtomatikCikisListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridOtomatikCikisListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridOtomatikCikisListe.RowTemplate.Height = 33;
            this.datagridOtomatikCikisListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridOtomatikCikisListe.Size = new System.Drawing.Size(1126, 228);
            this.datagridOtomatikCikisListe.TabIndex = 51;
            // 
            // txtAksam
            // 
            this.txtAksam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAksam.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAksam.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAksam.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAksam.BorderThickness = 3;
            this.txtAksam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAksam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAksam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAksam.isPassword = false;
            this.txtAksam.Location = new System.Drawing.Point(471, 213);
            this.txtAksam.Margin = new System.Windows.Forms.Padding(4);
            this.txtAksam.Name = "txtAksam";
            this.txtAksam.Size = new System.Drawing.Size(242, 30);
            this.txtAksam.TabIndex = 48;
            this.txtAksam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAksam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAksam_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(468, 196);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(197, 13);
            this.bunifuCustomLabel2.TabIndex = 47;
            this.bunifuCustomLabel2.Text = "Akşam Çikilacak Kişi Başı Kilogram/Adet";
            // 
            // txtogle
            // 
            this.txtogle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtogle.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtogle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtogle.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtogle.BorderThickness = 3;
            this.txtogle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtogle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtogle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtogle.isPassword = false;
            this.txtogle.Location = new System.Drawing.Point(471, 150);
            this.txtogle.Margin = new System.Windows.Forms.Padding(4);
            this.txtogle.Name = "txtogle";
            this.txtogle.Size = new System.Drawing.Size(242, 30);
            this.txtogle.TabIndex = 46;
            this.txtogle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtogle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtogle_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(468, 133);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(187, 13);
            this.bunifuCustomLabel1.TabIndex = 45;
            this.bunifuCustomLabel1.Text = "Öğle Çikilacak Kişi Başı Kilogram/Adet";
            // 
            // txtSabah
            // 
            this.txtSabah.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSabah.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSabah.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSabah.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSabah.BorderThickness = 3;
            this.txtSabah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSabah.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSabah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSabah.isPassword = false;
            this.txtSabah.Location = new System.Drawing.Point(471, 91);
            this.txtSabah.Margin = new System.Windows.Forms.Padding(4);
            this.txtSabah.Name = "txtSabah";
            this.txtSabah.Size = new System.Drawing.Size(242, 30);
            this.txtSabah.TabIndex = 44;
            this.txtSabah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSabah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSabah_KeyPress);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(469, 74);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(196, 13);
            this.bunifuCustomLabel5.TabIndex = 43;
            this.bunifuCustomLabel5.Text = "Sabah Çıkılacak Kişi Başı Kilogram/Adet";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveBorderThickness = 1;
            this.btnKaydet.ActiveCornerRadius = 20;
            this.btnKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnKaydet.Location = new System.Drawing.Point(488, 319);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(211, 41);
            this.btnKaydet.TabIndex = 42;
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunler.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(471, 36);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(242, 25);
            this.cmbUrunler.TabIndex = 54;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(468, 20);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(47, 13);
            this.bunifuCustomLabel6.TabIndex = 55;
            this.bunifuCustomLabel6.Text = "Ürünler :";
            // 
            // checkHeriase
            // 
            this.checkHeriase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkHeriase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkHeriase.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkHeriase.Checked = false;
            this.checkHeriase.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkHeriase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkHeriase.ForeColor = System.Drawing.Color.White;
            this.checkHeriase.Location = new System.Drawing.Point(481, 264);
            this.checkHeriase.Name = "checkHeriase";
            this.checkHeriase.Size = new System.Drawing.Size(20, 20);
            this.checkHeriase.TabIndex = 56;
            this.checkHeriase.OnChange += new System.EventHandler(this.checkHeriase_OnChange);
            // 
            // checkBanaBirak
            // 
            this.checkBanaBirak.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBanaBirak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBanaBirak.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBanaBirak.Checked = true;
            this.checkBanaBirak.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBanaBirak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBanaBirak.ForeColor = System.Drawing.Color.White;
            this.checkBanaBirak.Location = new System.Drawing.Point(481, 290);
            this.checkBanaBirak.Name = "checkBanaBirak";
            this.checkBanaBirak.Size = new System.Drawing.Size(20, 20);
            this.checkBanaBirak.TabIndex = 57;
            this.checkBanaBirak.OnChange += new System.EventHandler(this.checkBanaBirak_OnChange);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(507, 264);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(128, 13);
            this.bunifuCustomLabel3.TabIndex = 58;
            this.bunifuCustomLabel3.Text = "Her İaşede Çıkışı Yapılsın.";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(507, 297);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(94, 13);
            this.bunifuCustomLabel7.TabIndex = 59;
            this.bunifuCustomLabel7.Text = "Seçimi bana bırak.";
            this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuCustomLabel7_Click);
            // 
            // frmOtomatikiaseCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.checkBanaBirak);
            this.Controls.Add(this.checkHeriase);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.lbliaseYapilandirmaListesi);
            this.Controls.Add(this.datagridOtomatikCikisListe);
            this.Controls.Add(this.txtAksam);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtogle);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtSabah);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmOtomatikiaseCikis";
            this.Text = "Otomatik İaşe Çıkış Tanımlama";
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridOtomatikCikisListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDelete;
        private Bunifu.Framework.UI.BunifuCustomLabel lbliaseYapilandirmaListesi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridOtomatikCikisListe;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAksam;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtogle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSabah;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKaydet;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCheckbox checkHeriase;
        private Bunifu.Framework.UI.BunifuCheckbox checkBanaBirak;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}