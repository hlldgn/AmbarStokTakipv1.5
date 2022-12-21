
namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmBirim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBirim));
            this.lblBirimListesi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridBirimListe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBirimAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnBirimKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBirimListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBirimListesi
            // 
            this.lblBirimListesi.AutoSize = true;
            this.lblBirimListesi.Location = new System.Drawing.Point(12, 249);
            this.lblBirimListesi.Name = "lblBirimListesi";
            this.lblBirimListesi.Size = new System.Drawing.Size(67, 13);
            this.lblBirimListesi.TabIndex = 35;
            this.lblBirimListesi.Text = "Birim Listesi :";
            // 
            // datagridBirimListe
            // 
            this.datagridBirimListe.AllowUserToAddRows = false;
            this.datagridBirimListe.AllowUserToDeleteRows = false;
            this.datagridBirimListe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridBirimListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridBirimListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridBirimListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridBirimListe.BackgroundColor = System.Drawing.Color.White;
            this.datagridBirimListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridBirimListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridBirimListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridBirimListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBirimListe.DoubleBuffered = true;
            this.datagridBirimListe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridBirimListe.EnableHeadersVisualStyles = false;
            this.datagridBirimListe.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridBirimListe.HeaderForeColor = System.Drawing.Color.White;
            this.datagridBirimListe.Location = new System.Drawing.Point(12, 265);
            this.datagridBirimListe.MultiSelect = false;
            this.datagridBirimListe.Name = "datagridBirimListe";
            this.datagridBirimListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridBirimListe.RowHeadersVisible = false;
            this.datagridBirimListe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridBirimListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridBirimListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridBirimListe.RowTemplate.Height = 33;
            this.datagridBirimListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridBirimListe.Size = new System.Drawing.Size(1126, 347);
            this.datagridBirimListe.TabIndex = 34;
            // 
            // txtBirimAdi
            // 
            this.txtBirimAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBirimAdi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBirimAdi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBirimAdi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBirimAdi.BorderThickness = 3;
            this.txtBirimAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirimAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBirimAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBirimAdi.isPassword = false;
            this.txtBirimAdi.Location = new System.Drawing.Point(499, 49);
            this.txtBirimAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirimAdi.Name = "txtBirimAdi";
            this.txtBirimAdi.Size = new System.Drawing.Size(242, 30);
            this.txtBirimAdi.TabIndex = 33;
            this.txtBirimAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBirimAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBirimAdi_KeyDown);
            this.txtBirimAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimAdi_KeyPress);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(496, 32);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(53, 13);
            this.bunifuCustomLabel5.TabIndex = 32;
            this.bunifuCustomLabel5.Text = "Birim Adı :";
            // 
            // btnBirimKaydet
            // 
            this.btnBirimKaydet.ActiveBorderThickness = 1;
            this.btnBirimKaydet.ActiveCornerRadius = 20;
            this.btnBirimKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnBirimKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnBirimKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBirimKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBirimKaydet.BackColor = System.Drawing.Color.White;
            this.btnBirimKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBirimKaydet.BackgroundImage")));
            this.btnBirimKaydet.ButtonText = "Kaydet";
            this.btnBirimKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBirimKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBirimKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBirimKaydet.IdleBorderThickness = 1;
            this.btnBirimKaydet.IdleCornerRadius = 20;
            this.btnBirimKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnBirimKaydet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBirimKaydet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBirimKaydet.Location = new System.Drawing.Point(514, 88);
            this.btnBirimKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnBirimKaydet.Name = "btnBirimKaydet";
            this.btnBirimKaydet.Size = new System.Drawing.Size(211, 41);
            this.btnBirimKaydet.TabIndex = 31;
            this.btnBirimKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBirimKaydet.Click += new System.EventHandler(this.btnBirimKaydet_Click);
            // 
            // picDelete
            // 
            this.picDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDelete.Image = global::DOGAN.AmbarStokTakip.UI.Win.Properties.Resources.Delete;
            this.picDelete.Location = new System.Drawing.Point(1112, 233);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(26, 29);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 36;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click_1);
            // 
            // frmBirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.lblBirimListesi);
            this.Controls.Add(this.datagridBirimListe);
            this.Controls.Add(this.txtBirimAdi);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnBirimKaydet);
            this.Name = "frmBirim";
            this.Text = "Birim Tanımlama";
            ((System.ComponentModel.ISupportInitialize)(this.datagridBirimListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblBirimListesi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridBirimListe;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBirimAdi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBirimKaydet;
        private System.Windows.Forms.PictureBox picDelete;
    }
}