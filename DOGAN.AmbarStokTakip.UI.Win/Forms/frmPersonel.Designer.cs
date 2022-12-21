
namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.txtPersonelAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPersonelSoyadi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPersonelSicil = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPersonelUnvan = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPersonelListesi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridPersonelListe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnPersonelKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbBirimler = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPersonelListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPersonelAdi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPersonelAdi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelAdi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPersonelAdi.BorderThickness = 3;
            this.txtPersonelAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelAdi.isPassword = false;
            this.txtPersonelAdi.Location = new System.Drawing.Point(478, 47);
            this.txtPersonelAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(242, 30);
            this.txtPersonelAdi.TabIndex = 30;
            this.txtPersonelAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(475, 30);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(72, 13);
            this.bunifuCustomLabel5.TabIndex = 29;
            this.bunifuCustomLabel5.Text = "Personel Adı :";
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPersonelSoyadi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPersonelSoyadi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelSoyadi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPersonelSoyadi.BorderThickness = 3;
            this.txtPersonelSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelSoyadi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelSoyadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelSoyadi.isPassword = false;
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(482, 107);
            this.txtPersonelSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(242, 30);
            this.txtPersonelSoyadi.TabIndex = 32;
            this.txtPersonelSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPersonelSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSoyadi_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(479, 90);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(89, 13);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "Personel Soyadı :";
            // 
            // txtPersonelSicil
            // 
            this.txtPersonelSicil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPersonelSicil.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPersonelSicil.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelSicil.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPersonelSicil.BorderThickness = 3;
            this.txtPersonelSicil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelSicil.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelSicil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelSicil.isPassword = false;
            this.txtPersonelSicil.Location = new System.Drawing.Point(482, 167);
            this.txtPersonelSicil.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelSicil.Name = "txtPersonelSicil";
            this.txtPersonelSicil.Size = new System.Drawing.Size(242, 30);
            this.txtPersonelSicil.TabIndex = 34;
            this.txtPersonelSicil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(479, 150);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 13);
            this.bunifuCustomLabel2.TabIndex = 33;
            this.bunifuCustomLabel2.Text = "Personel Sicili :";
            // 
            // txtPersonelUnvan
            // 
            this.txtPersonelUnvan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPersonelUnvan.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPersonelUnvan.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelUnvan.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPersonelUnvan.BorderThickness = 3;
            this.txtPersonelUnvan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelUnvan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelUnvan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelUnvan.isPassword = false;
            this.txtPersonelUnvan.Location = new System.Drawing.Point(482, 229);
            this.txtPersonelUnvan.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelUnvan.Name = "txtPersonelUnvan";
            this.txtPersonelUnvan.Size = new System.Drawing.Size(242, 30);
            this.txtPersonelUnvan.TabIndex = 36;
            this.txtPersonelUnvan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(479, 212);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(91, 13);
            this.bunifuCustomLabel3.TabIndex = 35;
            this.bunifuCustomLabel3.Text = "Personel Ünvanı :";
            // 
            // lblPersonelListesi
            // 
            this.lblPersonelListesi.AutoSize = true;
            this.lblPersonelListesi.Location = new System.Drawing.Point(12, 384);
            this.lblPersonelListesi.Name = "lblPersonelListesi";
            this.lblPersonelListesi.Size = new System.Drawing.Size(86, 13);
            this.lblPersonelListesi.TabIndex = 38;
            this.lblPersonelListesi.Text = "Personel Listesi :";
            // 
            // datagridPersonelListe
            // 
            this.datagridPersonelListe.AllowUserToAddRows = false;
            this.datagridPersonelListe.AllowUserToDeleteRows = false;
            this.datagridPersonelListe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridPersonelListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridPersonelListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridPersonelListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridPersonelListe.BackgroundColor = System.Drawing.Color.White;
            this.datagridPersonelListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridPersonelListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPersonelListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridPersonelListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPersonelListe.DoubleBuffered = true;
            this.datagridPersonelListe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridPersonelListe.EnableHeadersVisualStyles = false;
            this.datagridPersonelListe.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridPersonelListe.HeaderForeColor = System.Drawing.Color.White;
            this.datagridPersonelListe.Location = new System.Drawing.Point(12, 400);
            this.datagridPersonelListe.MultiSelect = false;
            this.datagridPersonelListe.Name = "datagridPersonelListe";
            this.datagridPersonelListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridPersonelListe.RowHeadersVisible = false;
            this.datagridPersonelListe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridPersonelListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridPersonelListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridPersonelListe.RowTemplate.Height = 33;
            this.datagridPersonelListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPersonelListe.Size = new System.Drawing.Size(1126, 228);
            this.datagridPersonelListe.TabIndex = 37;
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.ActiveBorderThickness = 1;
            this.btnPersonelKaydet.ActiveCornerRadius = 20;
            this.btnPersonelKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnPersonelKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnPersonelKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnPersonelKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPersonelKaydet.BackColor = System.Drawing.Color.White;
            this.btnPersonelKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelKaydet.BackgroundImage")));
            this.btnPersonelKaydet.ButtonText = "Kaydet";
            this.btnPersonelKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPersonelKaydet.IdleBorderThickness = 1;
            this.btnPersonelKaydet.IdleCornerRadius = 20;
            this.btnPersonelKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnPersonelKaydet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnPersonelKaydet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnPersonelKaydet.Location = new System.Drawing.Point(493, 334);
            this.btnPersonelKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(211, 41);
            this.btnPersonelKaydet.TabIndex = 28;
            this.btnPersonelKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click);
            // 
            // picDelete
            // 
            this.picDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDelete.Image = global::DOGAN.AmbarStokTakip.UI.Win.Properties.Resources.Delete;
            this.picDelete.Location = new System.Drawing.Point(1112, 368);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(26, 29);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 39;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(479, 276);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(46, 13);
            this.bunifuCustomLabel6.TabIndex = 41;
            this.bunifuCustomLabel6.Text = "Birimler :";
            // 
            // cmbBirimler
            // 
            this.cmbBirimler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBirimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirimler.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBirimler.FormattingEnabled = true;
            this.cmbBirimler.Location = new System.Drawing.Point(482, 292);
            this.cmbBirimler.Name = "cmbBirimler";
            this.cmbBirimler.Size = new System.Drawing.Size(242, 25);
            this.cmbBirimler.TabIndex = 40;
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.cmbBirimler);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.lblPersonelListesi);
            this.Controls.Add(this.datagridPersonelListe);
            this.Controls.Add(this.txtPersonelUnvan);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtPersonelSicil);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtPersonelSoyadi);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtPersonelAdi);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnPersonelKaydet);
            this.Name = "frmPersonel";
            this.Text = "Personel Tanımlama";
            ((System.ComponentModel.ISupportInitialize)(this.datagridPersonelListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtPersonelAdi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPersonelKaydet;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPersonelSoyadi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPersonelSicil;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPersonelUnvan;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPersonelListesi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridPersonelListe;
        private System.Windows.Forms.PictureBox picDelete;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.ComboBox cmbBirimler;
    }
}