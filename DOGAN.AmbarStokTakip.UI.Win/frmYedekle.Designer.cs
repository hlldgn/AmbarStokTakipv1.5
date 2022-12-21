namespace DOGAN.AmbarStokTakip.UI.Win
{
    partial class frmYedekle
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageYedekle = new System.Windows.Forms.TabPage();
            this.btnGozatYedekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathYedekle = new System.Windows.Forms.TextBox();
            this.pageYedektenAl = new System.Windows.Forms.TabPage();
            this.btnGozatAl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathAl = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUygula = new System.Windows.Forms.Button();
            this.lblTanim = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.pageYedekle.SuspendLayout();
            this.pageYedektenAl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageYedekle);
            this.tabControl1.Controls.Add(this.pageYedektenAl);
            this.tabControl1.Location = new System.Drawing.Point(5, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 170);
            this.tabControl1.TabIndex = 0;
            // 
            // pageYedekle
            // 
            this.pageYedekle.Controls.Add(this.btnGozatYedekle);
            this.pageYedekle.Controls.Add(this.label1);
            this.pageYedekle.Controls.Add(this.txtPathYedekle);
            this.pageYedekle.Location = new System.Drawing.Point(4, 22);
            this.pageYedekle.Name = "pageYedekle";
            this.pageYedekle.Padding = new System.Windows.Forms.Padding(3);
            this.pageYedekle.Size = new System.Drawing.Size(359, 144);
            this.pageYedekle.TabIndex = 0;
            this.pageYedekle.Text = "Verileri Yedekle";
            this.pageYedekle.UseVisualStyleBackColor = true;
            // 
            // btnGozatYedekle
            // 
            this.btnGozatYedekle.Location = new System.Drawing.Point(265, 82);
            this.btnGozatYedekle.Name = "btnGozatYedekle";
            this.btnGozatYedekle.Size = new System.Drawing.Size(75, 23);
            this.btnGozatYedekle.TabIndex = 2;
            this.btnGozatYedekle.Text = "Gözat";
            this.btnGozatYedekle.UseVisualStyleBackColor = true;
            this.btnGozatYedekle.Click += new System.EventHandler(this.btnGozatYedekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yedekleme Yapılacak Konumu Seçiniz.";
            // 
            // txtPathYedekle
            // 
            this.txtPathYedekle.Location = new System.Drawing.Point(20, 56);
            this.txtPathYedekle.Name = "txtPathYedekle";
            this.txtPathYedekle.Size = new System.Drawing.Size(320, 20);
            this.txtPathYedekle.TabIndex = 0;
            // 
            // pageYedektenAl
            // 
            this.pageYedektenAl.Controls.Add(this.btnGozatAl);
            this.pageYedektenAl.Controls.Add(this.label2);
            this.pageYedektenAl.Controls.Add(this.txtPathAl);
            this.pageYedektenAl.Location = new System.Drawing.Point(4, 22);
            this.pageYedektenAl.Name = "pageYedektenAl";
            this.pageYedektenAl.Padding = new System.Windows.Forms.Padding(3);
            this.pageYedektenAl.Size = new System.Drawing.Size(359, 144);
            this.pageYedektenAl.TabIndex = 1;
            this.pageYedektenAl.Text = "Yedekten Veri Al";
            this.pageYedektenAl.UseVisualStyleBackColor = true;
            // 
            // btnGozatAl
            // 
            this.btnGozatAl.Location = new System.Drawing.Point(266, 82);
            this.btnGozatAl.Name = "btnGozatAl";
            this.btnGozatAl.Size = new System.Drawing.Size(75, 23);
            this.btnGozatAl.TabIndex = 5;
            this.btnGozatAl.Text = "Gözat";
            this.btnGozatAl.UseVisualStyleBackColor = true;
            this.btnGozatAl.Click += new System.EventHandler(this.btnGozatAl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alınacak Verinin Konumunu Seçiniz.";
            // 
            // txtPathAl
            // 
            this.txtPathAl.Location = new System.Drawing.Point(21, 56);
            this.txtPathAl.Name = "txtPathAl";
            this.txtPathAl.Size = new System.Drawing.Size(320, 20);
            this.txtPathAl.TabIndex = 3;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(212, 273);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnUygula
            // 
            this.btnUygula.Location = new System.Drawing.Point(293, 273);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(75, 23);
            this.btnUygula.TabIndex = 3;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // lblTanim
            // 
            this.lblTanim.Location = new System.Drawing.Point(9, 18);
            this.lblTanim.Name = "lblTanim";
            this.lblTanim.Size = new System.Drawing.Size(363, 53);
            this.lblTanim.TabIndex = 4;
            this.lblTanim.Text = "Uygulama üzerinde oluşturduğunuz verilerin yedeklemesini belirli sabit aralıklarl" +
    "a yapmanız önerilir.\r\nYedekleme yapılacak alanın güvenliği olduğundan emin olunu" +
    "z.";
            // 
            // frmYedekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.ControlBox = false;
            this.Controls.Add(this.lblTanim);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmYedekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Yedekleme | Veri Alma";
            this.tabControl1.ResumeLayout(false);
            this.pageYedekle.ResumeLayout(false);
            this.pageYedekle.PerformLayout();
            this.pageYedektenAl.ResumeLayout(false);
            this.pageYedektenAl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageYedektenAl;
        private System.Windows.Forms.TabPage pageYedekle;
        private System.Windows.Forms.Button btnGozatYedekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathYedekle;
        private System.Windows.Forms.Button btnGozatAl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathAl;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.Label lblTanim;
    }
}