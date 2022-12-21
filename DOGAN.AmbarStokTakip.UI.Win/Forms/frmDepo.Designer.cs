
namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmDepo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepo));
            this.datagridDepoListe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtDepoAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDepoListesi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.btnDepoKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDepoListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.SuspendLayout();
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
            this.datagridDepoListe.Location = new System.Drawing.Point(12, 285);
            this.datagridDepoListe.MultiSelect = false;
            this.datagridDepoListe.Name = "datagridDepoListe";
            this.datagridDepoListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridDepoListe.RowHeadersVisible = false;
            this.datagridDepoListe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridDepoListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridDepoListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridDepoListe.RowTemplate.Height = 33;
            this.datagridDepoListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridDepoListe.Size = new System.Drawing.Size(1126, 347);
            this.datagridDepoListe.TabIndex = 28;
            // 
            // txtDepoAdi
            // 
            this.txtDepoAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDepoAdi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDepoAdi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDepoAdi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDepoAdi.BorderThickness = 3;
            this.txtDepoAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepoAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDepoAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDepoAdi.isPassword = false;
            this.txtDepoAdi.Location = new System.Drawing.Point(499, 69);
            this.txtDepoAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepoAdi.Name = "txtDepoAdi";
            this.txtDepoAdi.Size = new System.Drawing.Size(242, 30);
            this.txtDepoAdi.TabIndex = 27;
            this.txtDepoAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDepoAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDepoAdi_KeyDown);
            this.txtDepoAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepoAdi_KeyPress);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(496, 52);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(57, 13);
            this.bunifuCustomLabel5.TabIndex = 26;
            this.bunifuCustomLabel5.Text = "Depo Adı :";
            // 
            // lblDepoListesi
            // 
            this.lblDepoListesi.AutoSize = true;
            this.lblDepoListesi.Location = new System.Drawing.Point(12, 269);
            this.lblDepoListesi.Name = "lblDepoListesi";
            this.lblDepoListesi.Size = new System.Drawing.Size(71, 13);
            this.lblDepoListesi.TabIndex = 29;
            this.lblDepoListesi.Text = "Depo Listesi :";
            // 
            // picDelete
            // 
            this.picDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDelete.Image = global::DOGAN.AmbarStokTakip.UI.Win.Properties.Resources.Delete;
            this.picDelete.Location = new System.Drawing.Point(1112, 253);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(26, 29);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 30;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // btnDepoKaydet
            // 
            this.btnDepoKaydet.ActiveBorderThickness = 1;
            this.btnDepoKaydet.ActiveCornerRadius = 20;
            this.btnDepoKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDepoKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnDepoKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDepoKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDepoKaydet.BackColor = System.Drawing.Color.White;
            this.btnDepoKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDepoKaydet.BackgroundImage")));
            this.btnDepoKaydet.ButtonText = "Kaydet";
            this.btnDepoKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepoKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepoKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDepoKaydet.IdleBorderThickness = 1;
            this.btnDepoKaydet.IdleCornerRadius = 20;
            this.btnDepoKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnDepoKaydet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDepoKaydet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDepoKaydet.Location = new System.Drawing.Point(515, 108);
            this.btnDepoKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnDepoKaydet.Name = "btnDepoKaydet";
            this.btnDepoKaydet.Size = new System.Drawing.Size(211, 41);
            this.btnDepoKaydet.TabIndex = 25;
            this.btnDepoKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDepoKaydet.Click += new System.EventHandler(this.btnDepoKaydet_Click);
            // 
            // frmDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.lblDepoListesi);
            this.Controls.Add(this.datagridDepoListe);
            this.Controls.Add(this.txtDepoAdi);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnDepoKaydet);
            this.Name = "frmDepo";
            this.Text = "Depo Tanımlama";
            ((System.ComponentModel.ISupportInitialize)(this.datagridDepoListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridDepoListe;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDepoAdi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDepoKaydet;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDepoListesi;
        private System.Windows.Forms.PictureBox picDelete;
    }
}