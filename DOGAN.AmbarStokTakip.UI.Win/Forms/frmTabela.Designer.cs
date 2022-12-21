
namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmTabela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabela));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTabelaListesi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridTabelaListe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnTabelaKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.datagridSabahYemekAdi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SabahYemekAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.datagridOgleYemekAdi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OgleYemekAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.datagridAksamYemekAdi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.AksamYemekAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateTabelaTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTabelaListe)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSabahYemekAdi)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridOgleYemekAdi)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAksamYemekAdi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabelaListesi
            // 
            this.lblTabelaListesi.AutoSize = true;
            this.lblTabelaListesi.Location = new System.Drawing.Point(12, 410);
            this.lblTabelaListesi.Name = "lblTabelaListesi";
            this.lblTabelaListesi.Size = new System.Drawing.Size(72, 13);
            this.lblTabelaListesi.TabIndex = 35;
            this.lblTabelaListesi.Text = "Tabela Listesi";
            // 
            // datagridTabelaListe
            // 
            this.datagridTabelaListe.AllowUserToAddRows = false;
            this.datagridTabelaListe.AllowUserToDeleteRows = false;
            this.datagridTabelaListe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridTabelaListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridTabelaListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridTabelaListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridTabelaListe.BackgroundColor = System.Drawing.Color.White;
            this.datagridTabelaListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridTabelaListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridTabelaListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridTabelaListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTabelaListe.DoubleBuffered = true;
            this.datagridTabelaListe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridTabelaListe.EnableHeadersVisualStyles = false;
            this.datagridTabelaListe.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridTabelaListe.HeaderForeColor = System.Drawing.Color.White;
            this.datagridTabelaListe.Location = new System.Drawing.Point(15, 431);
            this.datagridTabelaListe.MultiSelect = false;
            this.datagridTabelaListe.Name = "datagridTabelaListe";
            this.datagridTabelaListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridTabelaListe.RowHeadersVisible = false;
            this.datagridTabelaListe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridTabelaListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridTabelaListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridTabelaListe.RowTemplate.Height = 33;
            this.datagridTabelaListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTabelaListe.Size = new System.Drawing.Size(1126, 56);
            this.datagridTabelaListe.TabIndex = 34;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(25, 23);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(44, 13);
            this.bunifuCustomLabel5.TabIndex = 32;
            this.bunifuCustomLabel5.Text = "Sabah :";
            // 
            // btnTabelaKaydet
            // 
            this.btnTabelaKaydet.ActiveBorderThickness = 1;
            this.btnTabelaKaydet.ActiveCornerRadius = 20;
            this.btnTabelaKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnTabelaKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnTabelaKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTabelaKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTabelaKaydet.BackColor = System.Drawing.Color.White;
            this.btnTabelaKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTabelaKaydet.BackgroundImage")));
            this.btnTabelaKaydet.ButtonText = "Kaydet";
            this.btnTabelaKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabelaKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabelaKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTabelaKaydet.IdleBorderThickness = 1;
            this.btnTabelaKaydet.IdleCornerRadius = 20;
            this.btnTabelaKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnTabelaKaydet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnTabelaKaydet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTabelaKaydet.Location = new System.Drawing.Point(452, 374);
            this.btnTabelaKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnTabelaKaydet.Name = "btnTabelaKaydet";
            this.btnTabelaKaydet.Size = new System.Drawing.Size(211, 41);
            this.btnTabelaKaydet.TabIndex = 31;
            this.btnTabelaKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTabelaKaydet.Click += new System.EventHandler(this.btnTabelaKaydet_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.datagridSabahYemekAdi);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(28, 39);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 50;
            this.bunifuCards1.Size = new System.Drawing.Size(317, 256);
            this.bunifuCards1.TabIndex = 38;
            // 
            // datagridSabahYemekAdi
            // 
            this.datagridSabahYemekAdi.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridSabahYemekAdi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridSabahYemekAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridSabahYemekAdi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridSabahYemekAdi.BackgroundColor = System.Drawing.Color.White;
            this.datagridSabahYemekAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridSabahYemekAdi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridSabahYemekAdi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridSabahYemekAdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSabahYemekAdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SabahYemekAdi});
            this.datagridSabahYemekAdi.DoubleBuffered = true;
            this.datagridSabahYemekAdi.EnableHeadersVisualStyles = false;
            this.datagridSabahYemekAdi.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridSabahYemekAdi.HeaderForeColor = System.Drawing.Color.White;
            this.datagridSabahYemekAdi.Location = new System.Drawing.Point(3, 21);
            this.datagridSabahYemekAdi.MultiSelect = false;
            this.datagridSabahYemekAdi.Name = "datagridSabahYemekAdi";
            this.datagridSabahYemekAdi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridSabahYemekAdi.RowHeadersVisible = false;
            this.datagridSabahYemekAdi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridSabahYemekAdi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridSabahYemekAdi.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridSabahYemekAdi.RowTemplate.Height = 33;
            this.datagridSabahYemekAdi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridSabahYemekAdi.Size = new System.Drawing.Size(298, 214);
            this.datagridSabahYemekAdi.TabIndex = 35;
            this.datagridSabahYemekAdi.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.datagridSabahYemekAdi_EditingControlShowing);
            // 
            // SabahYemekAdi
            // 
            this.SabahYemekAdi.HeaderText = "Yemek Adı";
            this.SabahYemekAdi.Name = "SabahYemekAdi";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.datagridOgleYemekAdi);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(417, 39);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 50;
            this.bunifuCards2.Size = new System.Drawing.Size(317, 256);
            this.bunifuCards2.TabIndex = 39;
            // 
            // datagridOgleYemekAdi
            // 
            this.datagridOgleYemekAdi.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridOgleYemekAdi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridOgleYemekAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridOgleYemekAdi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridOgleYemekAdi.BackgroundColor = System.Drawing.Color.White;
            this.datagridOgleYemekAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridOgleYemekAdi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridOgleYemekAdi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridOgleYemekAdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridOgleYemekAdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OgleYemekAdi});
            this.datagridOgleYemekAdi.DoubleBuffered = true;
            this.datagridOgleYemekAdi.EnableHeadersVisualStyles = false;
            this.datagridOgleYemekAdi.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridOgleYemekAdi.HeaderForeColor = System.Drawing.Color.White;
            this.datagridOgleYemekAdi.Location = new System.Drawing.Point(7, 19);
            this.datagridOgleYemekAdi.MultiSelect = false;
            this.datagridOgleYemekAdi.Name = "datagridOgleYemekAdi";
            this.datagridOgleYemekAdi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridOgleYemekAdi.RowHeadersVisible = false;
            this.datagridOgleYemekAdi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridOgleYemekAdi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridOgleYemekAdi.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridOgleYemekAdi.RowTemplate.Height = 33;
            this.datagridOgleYemekAdi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridOgleYemekAdi.Size = new System.Drawing.Size(298, 214);
            this.datagridOgleYemekAdi.TabIndex = 36;
            this.datagridOgleYemekAdi.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.datagridOgleYemekAdi_EditingControlShowing);
            // 
            // OgleYemekAdi
            // 
            this.OgleYemekAdi.HeaderText = "Yemek Adı";
            this.OgleYemekAdi.Name = "OgleYemekAdi";
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Tomato;
            this.bunifuCards3.Controls.Add(this.datagridAksamYemekAdi);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(791, 39);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 50;
            this.bunifuCards3.Size = new System.Drawing.Size(317, 256);
            this.bunifuCards3.TabIndex = 40;
            // 
            // datagridAksamYemekAdi
            // 
            this.datagridAksamYemekAdi.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridAksamYemekAdi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.datagridAksamYemekAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridAksamYemekAdi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridAksamYemekAdi.BackgroundColor = System.Drawing.Color.White;
            this.datagridAksamYemekAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridAksamYemekAdi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAksamYemekAdi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.datagridAksamYemekAdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAksamYemekAdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AksamYemekAdi});
            this.datagridAksamYemekAdi.DoubleBuffered = true;
            this.datagridAksamYemekAdi.EnableHeadersVisualStyles = false;
            this.datagridAksamYemekAdi.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridAksamYemekAdi.HeaderForeColor = System.Drawing.Color.White;
            this.datagridAksamYemekAdi.Location = new System.Drawing.Point(7, 19);
            this.datagridAksamYemekAdi.MultiSelect = false;
            this.datagridAksamYemekAdi.Name = "datagridAksamYemekAdi";
            this.datagridAksamYemekAdi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridAksamYemekAdi.RowHeadersVisible = false;
            this.datagridAksamYemekAdi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridAksamYemekAdi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridAksamYemekAdi.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridAksamYemekAdi.RowTemplate.Height = 33;
            this.datagridAksamYemekAdi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridAksamYemekAdi.Size = new System.Drawing.Size(298, 214);
            this.datagridAksamYemekAdi.TabIndex = 36;
            this.datagridAksamYemekAdi.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.datagridAksamYemekAdi_EditingControlShowing);
            // 
            // AksamYemekAdi
            // 
            this.AksamYemekAdi.HeaderText = "Yemek Adı";
            this.AksamYemekAdi.Name = "AksamYemekAdi";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(414, 23);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(35, 13);
            this.bunifuCustomLabel2.TabIndex = 41;
            this.bunifuCustomLabel2.Text = "Öğle :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(788, 23);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(45, 13);
            this.bunifuCustomLabel3.TabIndex = 42;
            this.bunifuCustomLabel3.Text = "Akşam :";
            // 
            // dateTabelaTarih
            // 
            this.dateTabelaTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTabelaTarih.BackColor = System.Drawing.Color.SeaGreen;
            this.dateTabelaTarih.BorderRadius = 0;
            this.dateTabelaTarih.ForeColor = System.Drawing.Color.White;
            this.dateTabelaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTabelaTarih.FormatCustom = null;
            this.dateTabelaTarih.Location = new System.Drawing.Point(415, 320);
            this.dateTabelaTarih.Name = "dateTabelaTarih";
            this.dateTabelaTarih.Size = new System.Drawing.Size(314, 36);
            this.dateTabelaTarih.TabIndex = 43;
            this.dateTabelaTarih.Value = new System.DateTime(2022, 2, 1, 13, 53, 4, 194);
            this.dateTabelaTarih.onValueChanged += new System.EventHandler(this.dateTabelaTarih_onValueChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(412, 304);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(75, 13);
            this.bunifuCustomLabel4.TabIndex = 44;
            this.bunifuCustomLabel4.Text = "Tabela Tarihi :";
            // 
            // frmTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 644);
            this.Controls.Add(this.dateTabelaTarih);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.lblTabelaListesi);
            this.Controls.Add(this.datagridTabelaListe);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnTabelaKaydet);
            this.Name = "frmTabela";
            this.Text = "Yemek Listesi Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.datagridTabelaListe)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridSabahYemekAdi)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridOgleYemekAdi)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridAksamYemekAdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblTabelaListesi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridTabelaListe;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTabelaKaydet;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDatepicker dateTabelaTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridSabahYemekAdi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridOgleYemekAdi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridAksamYemekAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SabahYemekAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgleYemekAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AksamYemekAdi;
    }
}