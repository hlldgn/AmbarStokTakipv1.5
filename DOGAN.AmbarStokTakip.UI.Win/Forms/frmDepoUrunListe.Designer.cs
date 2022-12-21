namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmDepoUrunListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepoUrunListe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbYuzde = new System.Windows.Forms.ComboBox();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbDepo = new System.Windows.Forms.ComboBox();
            this.lblDepoListesi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridDepoListe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnDokuman = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btniptal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblToplamTutar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDepoListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.cmbYuzde);
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.cmbDepo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 205);
            this.panel1.TabIndex = 43;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(926, 181);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(157, 13);
            this.bunifuCustomLabel3.TabIndex = 52;
            this.bunifuCustomLabel3.Text = "Kalan Miktar Alarm Seviyesi (%):";
            // 
            // cmbYuzde
            // 
            this.cmbYuzde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbYuzde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYuzde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYuzde.FormattingEnabled = true;
            this.cmbYuzde.Location = new System.Drawing.Point(1089, 176);
            this.cmbYuzde.Name = "cmbYuzde";
            this.cmbYuzde.Size = new System.Drawing.Size(52, 25);
            this.cmbYuzde.TabIndex = 51;
            this.cmbYuzde.SelectedIndexChanged += new System.EventHandler(this.cmbYuzde_SelectedIndexChanged);
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.txtAra.Location = new System.Drawing.Point(15, 168);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(319, 33);
            this.txtAra.TabIndex = 50;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
            this.txtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAra_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(431, 77);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(39, 13);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Depo :";
            // 
            // cmbDepo
            // 
            this.cmbDepo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepo.FormattingEnabled = true;
            this.cmbDepo.Location = new System.Drawing.Point(434, 93);
            this.cmbDepo.Name = "cmbDepo";
            this.cmbDepo.Size = new System.Drawing.Size(303, 25);
            this.cmbDepo.TabIndex = 6;
            this.cmbDepo.SelectedIndexChanged += new System.EventHandler(this.cmbDepo_SelectedIndexChanged);
            // 
            // lblDepoListesi
            // 
            this.lblDepoListesi.AutoSize = true;
            this.lblDepoListesi.Location = new System.Drawing.Point(12, 229);
            this.lblDepoListesi.Name = "lblDepoListesi";
            this.lblDepoListesi.Size = new System.Drawing.Size(71, 13);
            this.lblDepoListesi.TabIndex = 51;
            this.lblDepoListesi.Text = "Depo Listesi :";
            // 
            // datagridDepoListe
            // 
            this.datagridDepoListe.AllowUserToAddRows = false;
            this.datagridDepoListe.AllowUserToDeleteRows = false;
            this.datagridDepoListe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridDepoListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridDepoListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridDepoListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridDepoListe.BackgroundColor = System.Drawing.Color.White;
            this.datagridDepoListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridDepoListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridDepoListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridDepoListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDepoListe.DoubleBuffered = true;
            this.datagridDepoListe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridDepoListe.EnableHeadersVisualStyles = false;
            this.datagridDepoListe.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridDepoListe.HeaderForeColor = System.Drawing.Color.White;
            this.datagridDepoListe.Location = new System.Drawing.Point(13, 245);
            this.datagridDepoListe.MultiSelect = false;
            this.datagridDepoListe.Name = "datagridDepoListe";
            this.datagridDepoListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridDepoListe.RowHeadersVisible = false;
            this.datagridDepoListe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridDepoListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridDepoListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridDepoListe.RowTemplate.Height = 33;
            this.datagridDepoListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridDepoListe.Size = new System.Drawing.Size(1125, 317);
            this.datagridDepoListe.TabIndex = 52;
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
            this.btnDokuman.Location = new System.Drawing.Point(473, 589);
            this.btnDokuman.Margin = new System.Windows.Forms.Padding(5);
            this.btnDokuman.Name = "btnDokuman";
            this.btnDokuman.Size = new System.Drawing.Size(211, 41);
            this.btnDokuman.TabIndex = 53;
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
            this.btniptal.Location = new System.Drawing.Point(1053, 211);
            this.btniptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(88, 31);
            this.btniptal.TabIndex = 54;
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplamTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.White;
            this.lblToplamTutar.Location = new System.Drawing.Point(13, 565);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(1128, 18);
            this.lblToplamTutar.TabIndex = 97;
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmDepoUrunListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnDokuman);
            this.Controls.Add(this.lblDepoListesi);
            this.Controls.Add(this.datagridDepoListe);
            this.Controls.Add(this.panel1);
            this.Name = "frmDepoUrunListe";
            this.Text = "Güncel  Ürün Kayıtları";
            this.Load += new System.EventHandler(this.frmDepoUrunListe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDepoListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cmbDepo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDepoListesi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridDepoListe;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDokuman;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox cmbYuzde;
        private Bunifu.Framework.UI.BunifuThinButton2 btniptal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblToplamTutar;
    }
}