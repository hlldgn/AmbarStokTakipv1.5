namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmDepolarArasiUrunTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepolarArasiUrunTransfer));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbHedefDepo = new System.Windows.Forms.ComboBox();
            this.lblDepoListesi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridDepoListe = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbKaynakDepo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDokuman = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDepoListe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(613, 76);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(68, 13);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Hedef Depo:";
            // 
            // cmbHedefDepo
            // 
            this.cmbHedefDepo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbHedefDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHedefDepo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHedefDepo.FormattingEnabled = true;
            this.cmbHedefDepo.Location = new System.Drawing.Point(616, 92);
            this.cmbHedefDepo.Name = "cmbHedefDepo";
            this.cmbHedefDepo.Size = new System.Drawing.Size(303, 25);
            this.cmbHedefDepo.TabIndex = 8;
            // 
            // lblDepoListesi
            // 
            this.lblDepoListesi.AutoSize = true;
            this.lblDepoListesi.Location = new System.Drawing.Point(7, 224);
            this.lblDepoListesi.Name = "lblDepoListesi";
            this.lblDepoListesi.Size = new System.Drawing.Size(71, 13);
            this.lblDepoListesi.TabIndex = 55;
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
            this.datagridDepoListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sec});
            this.datagridDepoListe.DoubleBuffered = true;
            this.datagridDepoListe.EnableHeadersVisualStyles = false;
            this.datagridDepoListe.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridDepoListe.HeaderForeColor = System.Drawing.Color.White;
            this.datagridDepoListe.Location = new System.Drawing.Point(10, 240);
            this.datagridDepoListe.MultiSelect = false;
            this.datagridDepoListe.Name = "datagridDepoListe";
            this.datagridDepoListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridDepoListe.RowHeadersVisible = false;
            this.datagridDepoListe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridDepoListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridDepoListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridDepoListe.RowTemplate.Height = 33;
            this.datagridDepoListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridDepoListe.Size = new System.Drawing.Size(1128, 341);
            this.datagridDepoListe.TabIndex = 56;
            // 
            // sec
            // 
            this.sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sec.HeaderText = "Seç";
            this.sec.Name = "sec";
            this.sec.Width = 50;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(254, 76);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 13);
            this.bunifuCustomLabel3.TabIndex = 54;
            this.bunifuCustomLabel3.Text = "Kaynak Depo :";
            // 
            // cmbKaynakDepo
            // 
            this.cmbKaynakDepo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbKaynakDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKaynakDepo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKaynakDepo.FormattingEnabled = true;
            this.cmbKaynakDepo.Location = new System.Drawing.Point(257, 92);
            this.cmbKaynakDepo.Name = "cmbKaynakDepo";
            this.cmbKaynakDepo.Size = new System.Drawing.Size(303, 25);
            this.cmbKaynakDepo.TabIndex = 53;
            this.cmbKaynakDepo.SelectedIndexChanged += new System.EventHandler(this.cmbKaynakDepo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.cmbKaynakDepo);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.cmbHedefDepo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 205);
            this.panel1.TabIndex = 57;
            // 
            // btnDokuman
            // 
            this.btnDokuman.ActiveBorderThickness = 1;
            this.btnDokuman.ActiveCornerRadius = 20;
            this.btnDokuman.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDokuman.ActiveForecolor = System.Drawing.Color.White;
            this.btnDokuman.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDokuman.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDokuman.BackColor = System.Drawing.Color.White;
            this.btnDokuman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDokuman.BackgroundImage")));
            this.btnDokuman.ButtonText = "Transfer Et";
            this.btnDokuman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDokuman.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDokuman.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDokuman.IdleBorderThickness = 1;
            this.btnDokuman.IdleCornerRadius = 20;
            this.btnDokuman.IdleFillColor = System.Drawing.Color.White;
            this.btnDokuman.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDokuman.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDokuman.Location = new System.Drawing.Point(480, 589);
            this.btnDokuman.Margin = new System.Windows.Forms.Padding(5);
            this.btnDokuman.Name = "btnDokuman";
            this.btnDokuman.Size = new System.Drawing.Size(211, 41);
            this.btnDokuman.TabIndex = 58;
            this.btnDokuman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDokuman.Click += new System.EventHandler(this.btnDokuman_Click);
            // 
            // frmDepolarArasiUrunTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 644);
            this.Controls.Add(this.btnDokuman);
            this.Controls.Add(this.lblDepoListesi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagridDepoListe);
            this.Name = "frmDepolarArasiUrunTransfer";
            this.Text = "Depolar Arası Ürün Transferi";
            this.Load += new System.EventHandler(this.frmDepolarArasiUrunTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridDepoListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cmbHedefDepo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDepoListesi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridDepoListe;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox cmbKaynakDepo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDokuman;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sec;
    }
}