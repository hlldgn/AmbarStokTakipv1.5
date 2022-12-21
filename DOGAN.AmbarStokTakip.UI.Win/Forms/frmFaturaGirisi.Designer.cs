namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmFaturaGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturaGirisi));
            this.dateFaturaTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUrunler = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridFaturaListe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnFaturaKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTumunuSec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFaturaListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFaturaTarih
            // 
            this.dateFaturaTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFaturaTarih.BackColor = System.Drawing.Color.SeaGreen;
            this.dateFaturaTarih.BorderRadius = 0;
            this.dateFaturaTarih.ForeColor = System.Drawing.Color.White;
            this.dateFaturaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFaturaTarih.FormatCustom = null;
            this.dateFaturaTarih.Location = new System.Drawing.Point(452, 72);
            this.dateFaturaTarih.Name = "dateFaturaTarih";
            this.dateFaturaTarih.Size = new System.Drawing.Size(303, 36);
            this.dateFaturaTarih.TabIndex = 34;
            this.dateFaturaTarih.Value = new System.DateTime(2022, 2, 1, 13, 53, 4, 194);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(449, 56);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(72, 13);
            this.bunifuCustomLabel3.TabIndex = 35;
            this.bunifuCustomLabel3.Text = "Fatura Tarihi :";
            // 
            // lblUrunler
            // 
            this.lblUrunler.AutoSize = true;
            this.lblUrunler.Location = new System.Drawing.Point(12, 176);
            this.lblUrunler.Name = "lblUrunler";
            this.lblUrunler.Size = new System.Drawing.Size(141, 13);
            this.lblUrunler.TabIndex = 37;
            this.lblUrunler.Text = "Faturası Kesilmemiş Ürünler :";
            // 
            // datagridFaturaListe
            // 
            this.datagridFaturaListe.AllowUserToAddRows = false;
            this.datagridFaturaListe.AllowUserToDeleteRows = false;
            this.datagridFaturaListe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridFaturaListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridFaturaListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridFaturaListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridFaturaListe.BackgroundColor = System.Drawing.Color.White;
            this.datagridFaturaListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridFaturaListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridFaturaListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridFaturaListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridFaturaListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sec});
            this.datagridFaturaListe.DoubleBuffered = true;
            this.datagridFaturaListe.EnableHeadersVisualStyles = false;
            this.datagridFaturaListe.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridFaturaListe.HeaderForeColor = System.Drawing.Color.White;
            this.datagridFaturaListe.Location = new System.Drawing.Point(12, 220);
            this.datagridFaturaListe.MultiSelect = false;
            this.datagridFaturaListe.Name = "datagridFaturaListe";
            this.datagridFaturaListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridFaturaListe.RowHeadersVisible = false;
            this.datagridFaturaListe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridFaturaListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridFaturaListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridFaturaListe.RowTemplate.Height = 33;
            this.datagridFaturaListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridFaturaListe.Size = new System.Drawing.Size(1126, 314);
            this.datagridFaturaListe.TabIndex = 36;
            // 
            // sec
            // 
            this.sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sec.HeaderText = "Seç";
            this.sec.Name = "sec";
            this.sec.Width = 50;
            // 
            // btnFaturaKaydet
            // 
            this.btnFaturaKaydet.ActiveBorderThickness = 1;
            this.btnFaturaKaydet.ActiveCornerRadius = 20;
            this.btnFaturaKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnFaturaKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnFaturaKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnFaturaKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFaturaKaydet.BackColor = System.Drawing.Color.White;
            this.btnFaturaKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFaturaKaydet.BackgroundImage")));
            this.btnFaturaKaydet.ButtonText = "Kaydet";
            this.btnFaturaKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturaKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturaKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFaturaKaydet.IdleBorderThickness = 1;
            this.btnFaturaKaydet.IdleCornerRadius = 20;
            this.btnFaturaKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnFaturaKaydet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnFaturaKaydet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnFaturaKaydet.Location = new System.Drawing.Point(471, 589);
            this.btnFaturaKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnFaturaKaydet.Name = "btnFaturaKaydet";
            this.btnFaturaKaydet.Size = new System.Drawing.Size(211, 41);
            this.btnFaturaKaydet.TabIndex = 38;
            this.btnFaturaKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFaturaKaydet.Click += new System.EventHandler(this.btnFaturaKaydet_Click);
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.txtAra.Location = new System.Drawing.Point(15, 541);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(379, 33);
            this.txtAra.TabIndex = 42;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
            // 
            // lblTumunuSec
            // 
            this.lblTumunuSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblTumunuSec.ForeColor = System.Drawing.Color.White;
            this.lblTumunuSec.Location = new System.Drawing.Point(14, 194);
            this.lblTumunuSec.Name = "lblTumunuSec";
            this.lblTumunuSec.Size = new System.Drawing.Size(76, 25);
            this.lblTumunuSec.TabIndex = 43;
            this.lblTumunuSec.Text = "Tümünü Seç";
            this.lblTumunuSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTumunuSec.Click += new System.EventHandler(this.lblTumunuSec_Click);
            // 
            // frmFaturaGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.lblTumunuSec);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnFaturaKaydet);
            this.Controls.Add(this.lblUrunler);
            this.Controls.Add(this.datagridFaturaListe);
            this.Controls.Add(this.dateFaturaTarih);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Name = "frmFaturaGirisi";
            this.Text = "Fatura Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.datagridFaturaListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker dateFaturaTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUrunler;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridFaturaListe;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFaturaKaydet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sec;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private System.Windows.Forms.Label lblTumunuSec;
    }
}