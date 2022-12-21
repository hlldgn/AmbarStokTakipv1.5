namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    partial class frmDokumanIaseTabelaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDokumanIaseTabelaKayit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDokuman = new Bunifu.Framework.UI.BunifuThinButton2();
            this.datagridYemekTabelasi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.datagridiaseicerik = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lbliaseiceregi = new System.Windows.Forms.Label();
            this.btniaseiptal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblKaloriToplam = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbliaseTutar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbliasePlanKisiSayilari = new System.Windows.Forms.Label();
            this.datagridIaseIptalPlan = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtAra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaxRow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridYemekTabelasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridiaseicerik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridIaseIptalPlan)).BeginInit();
            this.SuspendLayout();
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
            this.btnDokuman.Location = new System.Drawing.Point(365, 589);
            this.btnDokuman.Margin = new System.Windows.Forms.Padding(5);
            this.btnDokuman.Name = "btnDokuman";
            this.btnDokuman.Size = new System.Drawing.Size(211, 41);
            this.btnDokuman.TabIndex = 47;
            this.btnDokuman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDokuman.Click += new System.EventHandler(this.btnDokuman_Click);
            // 
            // datagridYemekTabelasi
            // 
            this.datagridYemekTabelasi.AllowUserToAddRows = false;
            this.datagridYemekTabelasi.AllowUserToDeleteRows = false;
            this.datagridYemekTabelasi.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridYemekTabelasi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.datagridYemekTabelasi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridYemekTabelasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridYemekTabelasi.BackgroundColor = System.Drawing.Color.White;
            this.datagridYemekTabelasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridYemekTabelasi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridYemekTabelasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.datagridYemekTabelasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridYemekTabelasi.DoubleBuffered = true;
            this.datagridYemekTabelasi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridYemekTabelasi.EnableHeadersVisualStyles = false;
            this.datagridYemekTabelasi.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridYemekTabelasi.HeaderForeColor = System.Drawing.Color.White;
            this.datagridYemekTabelasi.Location = new System.Drawing.Point(12, 62);
            this.datagridYemekTabelasi.MultiSelect = false;
            this.datagridYemekTabelasi.Name = "datagridYemekTabelasi";
            this.datagridYemekTabelasi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridYemekTabelasi.RowHeadersVisible = false;
            this.datagridYemekTabelasi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridYemekTabelasi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridYemekTabelasi.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridYemekTabelasi.RowTemplate.Height = 33;
            this.datagridYemekTabelasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridYemekTabelasi.Size = new System.Drawing.Size(1124, 135);
            this.datagridYemekTabelasi.TabIndex = 45;
            this.datagridYemekTabelasi.SelectionChanged += new System.EventHandler(this.datagridYemekTabelasi_SelectionChanged);
            // 
            // datagridiaseicerik
            // 
            this.datagridiaseicerik.AllowUserToAddRows = false;
            this.datagridiaseicerik.AllowUserToDeleteRows = false;
            this.datagridiaseicerik.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridiaseicerik.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.datagridiaseicerik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridiaseicerik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridiaseicerik.BackgroundColor = System.Drawing.Color.White;
            this.datagridiaseicerik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridiaseicerik.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridiaseicerik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.datagridiaseicerik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridiaseicerik.DoubleBuffered = true;
            this.datagridiaseicerik.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridiaseicerik.EnableHeadersVisualStyles = false;
            this.datagridiaseicerik.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridiaseicerik.HeaderForeColor = System.Drawing.Color.White;
            this.datagridiaseicerik.Location = new System.Drawing.Point(12, 370);
            this.datagridiaseicerik.MultiSelect = false;
            this.datagridiaseicerik.Name = "datagridiaseicerik";
            this.datagridiaseicerik.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridiaseicerik.RowHeadersVisible = false;
            this.datagridiaseicerik.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridiaseicerik.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridiaseicerik.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridiaseicerik.RowTemplate.Height = 33;
            this.datagridiaseicerik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridiaseicerik.Size = new System.Drawing.Size(1124, 175);
            this.datagridiaseicerik.TabIndex = 88;
            // 
            // lbliaseiceregi
            // 
            this.lbliaseiceregi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbliaseiceregi.AutoSize = true;
            this.lbliaseiceregi.Location = new System.Drawing.Point(1046, 354);
            this.lbliaseiceregi.Name = "lbliaseiceregi";
            this.lbliaseiceregi.Size = new System.Drawing.Size(90, 13);
            this.lbliaseiceregi.TabIndex = 89;
            this.lbliaseiceregi.Text = "İaşe İçeriği Listesi";
            // 
            // btniaseiptal
            // 
            this.btniaseiptal.ActiveBorderThickness = 1;
            this.btniaseiptal.ActiveCornerRadius = 20;
            this.btniaseiptal.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btniaseiptal.ActiveForecolor = System.Drawing.Color.White;
            this.btniaseiptal.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btniaseiptal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btniaseiptal.BackColor = System.Drawing.Color.White;
            this.btniaseiptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btniaseiptal.BackgroundImage")));
            this.btniaseiptal.ButtonText = "İaşe İptal";
            this.btniaseiptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniaseiptal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniaseiptal.ForeColor = System.Drawing.Color.SeaGreen;
            this.btniaseiptal.IdleBorderThickness = 1;
            this.btniaseiptal.IdleCornerRadius = 20;
            this.btniaseiptal.IdleFillColor = System.Drawing.Color.White;
            this.btniaseiptal.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btniaseiptal.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btniaseiptal.Location = new System.Drawing.Point(612, 589);
            this.btniaseiptal.Margin = new System.Windows.Forms.Padding(5);
            this.btniaseiptal.Name = "btniaseiptal";
            this.btniaseiptal.Size = new System.Drawing.Size(211, 41);
            this.btniaseiptal.TabIndex = 90;
            this.btniaseiptal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btniaseiptal.Click += new System.EventHandler(this.btniaseiptal_Click);
            // 
            // lblKaloriToplam
            // 
            this.lblKaloriToplam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKaloriToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblKaloriToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaloriToplam.ForeColor = System.Drawing.Color.White;
            this.lblKaloriToplam.Location = new System.Drawing.Point(15, 566);
            this.lblKaloriToplam.Name = "lblKaloriToplam";
            this.lblKaloriToplam.Size = new System.Drawing.Size(1121, 18);
            this.lblKaloriToplam.TabIndex = 92;
            this.lblKaloriToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbliaseTutar
            // 
            this.lbliaseTutar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbliaseTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbliaseTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbliaseTutar.ForeColor = System.Drawing.Color.White;
            this.lbliaseTutar.Location = new System.Drawing.Point(15, 548);
            this.lbliaseTutar.Name = "lbliaseTutar";
            this.lbliaseTutar.Size = new System.Drawing.Size(1121, 18);
            this.lbliaseTutar.TabIndex = 91;
            this.lbliaseTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbliasePlanKisiSayilari
            // 
            this.lbliasePlanKisiSayilari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbliasePlanKisiSayilari.AutoSize = true;
            this.lbliasePlanKisiSayilari.Location = new System.Drawing.Point(1028, 210);
            this.lbliasePlanKisiSayilari.Name = "lbliasePlanKisiSayilari";
            this.lbliasePlanKisiSayilari.Size = new System.Drawing.Size(108, 13);
            this.lbliasePlanKisiSayilari.TabIndex = 94;
            this.lbliasePlanKisiSayilari.Text = "İaşe Planı Kişi Sayıları";
            // 
            // datagridIaseIptalPlan
            // 
            this.datagridIaseIptalPlan.AllowUserToAddRows = false;
            this.datagridIaseIptalPlan.AllowUserToDeleteRows = false;
            this.datagridIaseIptalPlan.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridIaseIptalPlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.datagridIaseIptalPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridIaseIptalPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridIaseIptalPlan.BackgroundColor = System.Drawing.Color.White;
            this.datagridIaseIptalPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridIaseIptalPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridIaseIptalPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.datagridIaseIptalPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridIaseIptalPlan.DoubleBuffered = true;
            this.datagridIaseIptalPlan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridIaseIptalPlan.EnableHeadersVisualStyles = false;
            this.datagridIaseIptalPlan.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.datagridIaseIptalPlan.HeaderForeColor = System.Drawing.Color.White;
            this.datagridIaseIptalPlan.Location = new System.Drawing.Point(12, 226);
            this.datagridIaseIptalPlan.MultiSelect = false;
            this.datagridIaseIptalPlan.Name = "datagridIaseIptalPlan";
            this.datagridIaseIptalPlan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridIaseIptalPlan.RowHeadersVisible = false;
            this.datagridIaseIptalPlan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datagridIaseIptalPlan.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagridIaseIptalPlan.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridIaseIptalPlan.RowTemplate.Height = 33;
            this.datagridIaseIptalPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridIaseIptalPlan.Size = new System.Drawing.Size(1124, 114);
            this.datagridIaseIptalPlan.TabIndex = 93;
            this.datagridIaseIptalPlan.SelectionChanged += new System.EventHandler(this.datagridIaseIptalPlan_SelectionChanged);
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.White;
            this.txtAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAra.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtAra.ForeColor = System.Drawing.Color.Black;
            this.txtAra.HintForeColor = System.Drawing.Color.Black;
            this.txtAra.HintText = "Ara";
            this.txtAra.isPassword = false;
            this.txtAra.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtAra.LineIdleColor = System.Drawing.Color.Black;
            this.txtAra.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtAra.LineThickness = 3;
            this.txtAra.Location = new System.Drawing.Point(18, 20);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(242, 35);
            this.txtAra.TabIndex = 95;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1014, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Yemek Tabelası Kayıtları";
            // 
            // lblMaxRow
            // 
            this.lblMaxRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxRow.ForeColor = System.Drawing.Color.Crimson;
            this.lblMaxRow.Location = new System.Drawing.Point(949, 20);
            this.lblMaxRow.Name = "lblMaxRow";
            this.lblMaxRow.Size = new System.Drawing.Size(187, 13);
            this.lblMaxRow.TabIndex = 96;
            this.lblMaxRow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmDokumanIaseTabelaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 644);
            this.Controls.Add(this.lblMaxRow);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lbliasePlanKisiSayilari);
            this.Controls.Add(this.datagridIaseIptalPlan);
            this.Controls.Add(this.lblKaloriToplam);
            this.Controls.Add(this.btniaseiptal);
            this.Controls.Add(this.lbliaseiceregi);
            this.Controls.Add(this.lbliaseTutar);
            this.Controls.Add(this.datagridiaseicerik);
            this.Controls.Add(this.btnDokuman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridYemekTabelasi);
            this.Name = "frmDokumanIaseTabelaKayit";
            this.Text = "İaşe Tabelası Kayıtları";
            ((System.ComponentModel.ISupportInitialize)(this.datagridYemekTabelasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridiaseicerik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridIaseIptalPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnDokuman;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridYemekTabelasi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridiaseicerik;
        private System.Windows.Forms.Label lbliaseiceregi;
        private Bunifu.Framework.UI.BunifuThinButton2 btniaseiptal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblKaloriToplam;
        private Bunifu.Framework.UI.BunifuCustomLabel lbliaseTutar;
        private System.Windows.Forms.Label lbliasePlanKisiSayilari;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridIaseIptalPlan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaxRow;
    }
}