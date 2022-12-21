namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblUrunler = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridOdemeListe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateOdemeTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblTumunuSec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridOdemeListe)).BeginInit();
            this.SuspendLayout();
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
            this.txtAra.Location = new System.Drawing.Point(15, 520);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(379, 33);
            this.txtAra.TabIndex = 48;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
            // 
            // lblUrunler
            // 
            this.lblUrunler.AutoSize = true;
            this.lblUrunler.Location = new System.Drawing.Point(9, 155);
            this.lblUrunler.Name = "lblUrunler";
            this.lblUrunler.Size = new System.Drawing.Size(146, 13);
            this.lblUrunler.TabIndex = 46;
            this.lblUrunler.Text = "Ödemesi Yapılmamış Ürünler :";
            // 
            // datagridOdemeListe
            // 
            this.datagridOdemeListe.AllowUserToAddRows = false;
            this.datagridOdemeListe.AllowUserToDeleteRows = false;
            this.datagridOdemeListe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridOdemeListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridOdemeListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridOdemeListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridOdemeListe.BackgroundColor = System.Drawing.Color.White;
            this.datagridOdemeListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridOdemeListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridOdemeListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridOdemeListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridOdemeListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sec});
            this.datagridOdemeListe.DoubleBuffered = true;
            this.datagridOdemeListe.EnableHeadersVisualStyles = false;
            this.datagridOdemeListe.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridOdemeListe.HeaderForeColor = System.Drawing.Color.White;
            this.datagridOdemeListe.Location = new System.Drawing.Point(12, 199);
            this.datagridOdemeListe.MultiSelect = false;
            this.datagridOdemeListe.Name = "datagridOdemeListe";
            this.datagridOdemeListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridOdemeListe.RowHeadersVisible = false;
            this.datagridOdemeListe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridOdemeListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridOdemeListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridOdemeListe.RowTemplate.Height = 33;
            this.datagridOdemeListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridOdemeListe.Size = new System.Drawing.Size(1126, 314);
            this.datagridOdemeListe.TabIndex = 45;
            // 
            // sec
            // 
            this.sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sec.HeaderText = "Seç";
            this.sec.Name = "sec";
            this.sec.Width = 50;
            // 
            // dateOdemeTarih
            // 
            this.dateOdemeTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateOdemeTarih.BackColor = System.Drawing.Color.SeaGreen;
            this.dateOdemeTarih.BorderRadius = 0;
            this.dateOdemeTarih.ForeColor = System.Drawing.Color.White;
            this.dateOdemeTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOdemeTarih.FormatCustom = null;
            this.dateOdemeTarih.Location = new System.Drawing.Point(452, 51);
            this.dateOdemeTarih.Name = "dateOdemeTarih";
            this.dateOdemeTarih.Size = new System.Drawing.Size(303, 36);
            this.dateOdemeTarih.TabIndex = 43;
            this.dateOdemeTarih.Value = new System.DateTime(2022, 2, 1, 13, 53, 4, 194);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(449, 35);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(76, 13);
            this.bunifuCustomLabel3.TabIndex = 44;
            this.bunifuCustomLabel3.Text = "Ödeme Tarihi :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveBorderThickness = 1;
            this.btnKaydet.ActiveCornerRadius = 20;
            this.btnKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnKaydet.Location = new System.Drawing.Point(471, 568);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(211, 41);
            this.btnKaydet.TabIndex = 47;
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblTumunuSec
            // 
            this.lblTumunuSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblTumunuSec.ForeColor = System.Drawing.Color.White;
            this.lblTumunuSec.Location = new System.Drawing.Point(12, 173);
            this.lblTumunuSec.Name = "lblTumunuSec";
            this.lblTumunuSec.Size = new System.Drawing.Size(76, 25);
            this.lblTumunuSec.TabIndex = 49;
            this.lblTumunuSec.Text = "Tümünü Seç";
            this.lblTumunuSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTumunuSec.Click += new System.EventHandler(this.lblTumunuSec_Click);
            // 
            // frmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.lblTumunuSec);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblUrunler);
            this.Controls.Add(this.datagridOdemeListe);
            this.Controls.Add(this.dateOdemeTarih);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Name = "frmOdeme";
            this.Text = "Ödeme Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.datagridOdemeListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKaydet;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUrunler;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridOdemeListe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sec;
        private Bunifu.Framework.UI.BunifuDatepicker dateOdemeTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Label lblTumunuSec;
    }
}