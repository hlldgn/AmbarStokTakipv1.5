
namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmGuncelAlim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuncelAlim));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progresAlinan = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblAlinanMiktar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.datagridHareketAlimListesi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.datagridAlimicerik = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btniptal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridHareketAlimListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAlimicerik)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(15, 376);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(63, 13);
            this.bunifuCustomLabel2.TabIndex = 47;
            this.bunifuCustomLabel2.Text = "Alım İçeriği :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 187);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(43, 13);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Alımlar :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.progresAlinan);
            this.panel1.Controls.Add(this.lblAlinanMiktar);
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 163);
            this.panel1.TabIndex = 42;
            // 
            // progresAlinan
            // 
            this.progresAlinan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progresAlinan.animated = true;
            this.progresAlinan.animationIterval = 3;
            this.progresAlinan.animationSpeed = 15;
            this.progresAlinan.BackColor = System.Drawing.Color.Transparent;
            this.progresAlinan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progresAlinan.BackgroundImage")));
            this.progresAlinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progresAlinan.ForeColor = System.Drawing.Color.White;
            this.progresAlinan.LabelVisible = true;
            this.progresAlinan.LineProgressThickness = 5;
            this.progresAlinan.LineThickness = 5;
            this.progresAlinan.Location = new System.Drawing.Point(500, 29);
            this.progresAlinan.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progresAlinan.MaxValue = 100;
            this.progresAlinan.Name = "progresAlinan";
            this.progresAlinan.ProgressBackColor = System.Drawing.Color.Crimson;
            this.progresAlinan.ProgressColor = System.Drawing.Color.White;
            this.progresAlinan.Size = new System.Drawing.Size(128, 128);
            this.progresAlinan.TabIndex = 44;
            this.progresAlinan.Value = 90;
            // 
            // lblAlinanMiktar
            // 
            this.lblAlinanMiktar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAlinanMiktar.AutoSize = true;
            this.lblAlinanMiktar.ForeColor = System.Drawing.Color.White;
            this.lblAlinanMiktar.Location = new System.Drawing.Point(510, 12);
            this.lblAlinanMiktar.Name = "lblAlinanMiktar";
            this.lblAlinanMiktar.Size = new System.Drawing.Size(114, 13);
            this.lblAlinanMiktar.TabIndex = 41;
            this.lblAlinanMiktar.Text = "Alınan Miktar Yüzdesel";
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
            this.txtAra.Location = new System.Drawing.Point(13, 120);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(319, 33);
            this.txtAra.TabIndex = 42;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
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
            this.datagridHareketAlimListesi.Location = new System.Drawing.Point(16, 203);
            this.datagridHareketAlimListesi.MultiSelect = false;
            this.datagridHareketAlimListesi.Name = "datagridHareketAlimListesi";
            this.datagridHareketAlimListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridHareketAlimListesi.RowHeadersVisible = false;
            this.datagridHareketAlimListesi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridHareketAlimListesi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridHareketAlimListesi.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridHareketAlimListesi.RowTemplate.Height = 33;
            this.datagridHareketAlimListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridHareketAlimListesi.Size = new System.Drawing.Size(1128, 157);
            this.datagridHareketAlimListesi.TabIndex = 49;
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
            this.datagridAlimicerik.Location = new System.Drawing.Point(15, 392);
            this.datagridAlimicerik.MultiSelect = false;
            this.datagridAlimicerik.Name = "datagridAlimicerik";
            this.datagridAlimicerik.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridAlimicerik.RowHeadersVisible = false;
            this.datagridAlimicerik.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridAlimicerik.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridAlimicerik.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridAlimicerik.RowTemplate.Height = 33;
            this.datagridAlimicerik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridAlimicerik.Size = new System.Drawing.Size(1129, 244);
            this.datagridAlimicerik.TabIndex = 48;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-7, -26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 680);
            this.tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btniptal);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage1.Controls.Add(this.datagridHareketAlimListesi);
            this.tabPage1.Controls.Add(this.datagridAlimicerik);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1170, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
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
            this.btniptal.Location = new System.Drawing.Point(1056, 173);
            this.btniptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(88, 31);
            this.btniptal.TabIndex = 48;
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // frmGuncelAlim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmGuncelAlim";
            this.Text = "Güncel Alım Kayıtları";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridHareketAlimListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAlimicerik)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAlinanMiktar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridHareketAlimListesi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridAlimicerik;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progresAlinan;
        private Bunifu.Framework.UI.BunifuThinButton2 btniptal;
    }
}