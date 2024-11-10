namespace HaliSahaOtomasyon
{
    partial class frmSahaBilgiDuzenlemeEkrani
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
            PnlUstMenu = new Panel();
            label1 = new Label();
            btn_Kapat = new Button();
            PnLogo = new Panel();
            groupBox1 = new GroupBox();
            txtSahaAdi = new TextBox();
            groupBox2 = new GroupBox();
            rBYapay = new RadioButton();
            rBDogal = new RadioButton();
            groupBox3 = new GroupBox();
            rBKapali = new RadioButton();
            rBAcik = new RadioButton();
            groupBox4 = new GroupBox();
            gBoy = new GroupBox();
            txtBoy = new TextBox();
            label2 = new Label();
            gBEn = new GroupBox();
            txtEn = new TextBox();
            rBDiger = new RadioButton();
            rBStandart = new RadioButton();
            groupBox5 = new GroupBox();
            txtAciklama = new TextBox();
            button1 = new Button();
            PnlUstMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            gBoy.SuspendLayout();
            gBEn.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // PnlUstMenu
            // 
            PnlUstMenu.BackColor = Color.FromArgb(64, 64, 64);
            PnlUstMenu.Controls.Add(label1);
            PnlUstMenu.Controls.Add(btn_Kapat);
            PnlUstMenu.Controls.Add(PnLogo);
            PnlUstMenu.Dock = DockStyle.Top;
            PnlUstMenu.Location = new Point(0, 0);
            PnlUstMenu.Name = "PnlUstMenu";
            PnlUstMenu.Size = new Size(475, 60);
            PnlUstMenu.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(268, 21);
            label1.TabIndex = 2;
            label1.Text = "(SAHA KAYIT DÜZENLEME  EKRANI)";
            // 
            // btn_Kapat
            // 
            btn_Kapat.BackColor = Color.FromArgb(229, 125, 0);
            btn_Kapat.Cursor = Cursors.Hand;
            btn_Kapat.Dock = DockStyle.Right;
            btn_Kapat.FlatAppearance.BorderSize = 0;
            btn_Kapat.FlatStyle = FlatStyle.Flat;
            btn_Kapat.ForeColor = Color.White;
            btn_Kapat.Location = new Point(435, 0);
            btn_Kapat.Name = "btn_Kapat";
            btn_Kapat.Size = new Size(40, 60);
            btn_Kapat.TabIndex = 1;
            btn_Kapat.Text = "X";
            btn_Kapat.UseVisualStyleBackColor = false;
            btn_Kapat.Click += btn_Kapat_Click;
            // 
            // PnLogo
            // 
            PnLogo.BackColor = Color.FromArgb(229, 125, 0);
            PnLogo.Dock = DockStyle.Left;
            PnLogo.Location = new Point(0, 0);
            PnLogo.Name = "PnLogo";
            PnLogo.Size = new Size(10, 60);
            PnLogo.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSahaAdi);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox1.Location = new Point(19, 95);
            groupBox1.Margin = new Padding(10, 3, 3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(200, 65);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "SAHA İSMİ";
            // 
            // txtSahaAdi
            // 
            txtSahaAdi.BorderStyle = BorderStyle.None;
            txtSahaAdi.Dock = DockStyle.Bottom;
            txtSahaAdi.ForeColor = Color.FromArgb(229, 125, 0);
            txtSahaAdi.Location = new Point(10, 44);
            txtSahaAdi.Name = "txtSahaAdi";
            txtSahaAdi.Size = new Size(187, 18);
            txtSahaAdi.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rBYapay);
            groupBox2.Controls.Add(rBDogal);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox2.Location = new Point(19, 179);
            groupBox2.Margin = new Padding(10, 3, 3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 3, 3, 3);
            groupBox2.Size = new Size(200, 65);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "ÇİM TÜRÜ";
            // 
            // rBYapay
            // 
            rBYapay.AutoSize = true;
            rBYapay.Cursor = Cursors.Hand;
            rBYapay.FlatStyle = FlatStyle.Flat;
            rBYapay.Location = new Point(122, 28);
            rBYapay.Name = "rBYapay";
            rBYapay.Size = new Size(65, 23);
            rBYapay.TabIndex = 1;
            rBYapay.Text = "YAPAY";
            rBYapay.UseVisualStyleBackColor = true;
            rBYapay.CheckedChanged += rBYapay_CheckedChanged;
            // 
            // rBDogal
            // 
            rBDogal.AutoSize = true;
            rBDogal.Checked = true;
            rBDogal.Cursor = Cursors.Hand;
            rBDogal.FlatStyle = FlatStyle.Flat;
            rBDogal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            rBDogal.ForeColor = Color.FromArgb(229, 125, 0);
            rBDogal.Location = new Point(17, 28);
            rBDogal.Name = "rBDogal";
            rBDogal.Size = new Size(73, 23);
            rBDogal.TabIndex = 0;
            rBDogal.TabStop = true;
            rBDogal.Text = "DOĞAL";
            rBDogal.UseVisualStyleBackColor = true;
            rBDogal.CheckedChanged += rBDogal_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rBKapali);
            groupBox3.Controls.Add(rBAcik);
            groupBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox3.Location = new Point(19, 267);
            groupBox3.Margin = new Padding(10, 3, 3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 3, 3);
            groupBox3.Size = new Size(200, 65);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "SAHA TÜRÜ";
            // 
            // rBKapali
            // 
            rBKapali.AutoSize = true;
            rBKapali.Cursor = Cursors.Hand;
            rBKapali.FlatStyle = FlatStyle.Flat;
            rBKapali.Location = new Point(122, 28);
            rBKapali.Name = "rBKapali";
            rBKapali.Size = new Size(71, 23);
            rBKapali.TabIndex = 1;
            rBKapali.Text = "KAPALI";
            rBKapali.UseVisualStyleBackColor = true;
            rBKapali.CheckedChanged += rBKapali_CheckedChanged;
            // 
            // rBAcik
            // 
            rBAcik.AutoSize = true;
            rBAcik.Checked = true;
            rBAcik.Cursor = Cursors.Hand;
            rBAcik.FlatStyle = FlatStyle.Flat;
            rBAcik.ForeColor = Color.FromArgb(229, 125, 0);
            rBAcik.Location = new Point(24, 28);
            rBAcik.Name = "rBAcik";
            rBAcik.Size = new Size(57, 23);
            rBAcik.TabIndex = 0;
            rBAcik.TabStop = true;
            rBAcik.Text = "AÇIK";
            rBAcik.UseVisualStyleBackColor = true;
            rBAcik.CheckedChanged += rBAcik_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(gBoy);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(gBEn);
            groupBox4.Controls.Add(rBDiger);
            groupBox4.Controls.Add(rBStandart);
            groupBox4.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox4.Location = new Point(16, 347);
            groupBox4.Margin = new Padding(10, 3, 3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 3, 3, 3);
            groupBox4.Size = new Size(200, 137);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "SAHA BOYUTU";
            // 
            // gBoy
            // 
            gBoy.Controls.Add(txtBoy);
            gBoy.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            gBoy.ForeColor = Color.FromArgb(64, 64, 64);
            gBoy.Location = new Point(143, 87);
            gBoy.Margin = new Padding(10, 3, 3, 3);
            gBoy.Name = "gBoy";
            gBoy.Padding = new Padding(10, 3, 3, 3);
            gBoy.Size = new Size(56, 36);
            gBoy.TabIndex = 7;
            gBoy.TabStop = false;
            gBoy.Text = "BOY";
            gBoy.Visible = false;
            // 
            // txtBoy
            // 
            txtBoy.BorderStyle = BorderStyle.None;
            txtBoy.Dock = DockStyle.Bottom;
            txtBoy.ForeColor = Color.FromArgb(229, 125, 0);
            txtBoy.Location = new Point(10, 18);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(43, 15);
            txtBoy.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 6;
            label2.Text = "(metre)";
            // 
            // gBEn
            // 
            gBEn.Controls.Add(txtEn);
            gBEn.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            gBEn.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Location = new Point(77, 87);
            gBEn.Margin = new Padding(10, 3, 3, 3);
            gBEn.Name = "gBEn";
            gBEn.Padding = new Padding(10, 3, 3, 3);
            gBEn.Size = new Size(56, 36);
            gBEn.TabIndex = 6;
            gBEn.TabStop = false;
            gBEn.Text = "EN";
            gBEn.Visible = false;
            // 
            // txtEn
            // 
            txtEn.BorderStyle = BorderStyle.None;
            txtEn.Dock = DockStyle.Bottom;
            txtEn.ForeColor = Color.FromArgb(229, 125, 0);
            txtEn.Location = new Point(10, 18);
            txtEn.Name = "txtEn";
            txtEn.Size = new Size(43, 15);
            txtEn.TabIndex = 0;
            // 
            // rBDiger
            // 
            rBDiger.AutoSize = true;
            rBDiger.Cursor = Cursors.Hand;
            rBDiger.FlatStyle = FlatStyle.Flat;
            rBDiger.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            rBDiger.Location = new Point(14, 92);
            rBDiger.Name = "rBDiger";
            rBDiger.Size = new Size(66, 23);
            rBDiger.TabIndex = 1;
            rBDiger.Text = "DİĞER";
            rBDiger.UseVisualStyleBackColor = true;
            rBDiger.CheckedChanged += rBDiger_CheckedChanged;
            // 
            // rBStandart
            // 
            rBStandart.AutoSize = true;
            rBStandart.Checked = true;
            rBStandart.Cursor = Cursors.Hand;
            rBStandart.FlatStyle = FlatStyle.Flat;
            rBStandart.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            rBStandart.ForeColor = Color.FromArgb(229, 125, 0);
            rBStandart.Location = new Point(24, 28);
            rBStandart.Name = "rBStandart";
            rBStandart.Size = new Size(166, 23);
            rBStandart.TabIndex = 0;
            rBStandart.TabStop = true;
            rBStandart.Text = "STANDART (200x500)";
            rBStandart.UseVisualStyleBackColor = true;
            rBStandart.CheckedChanged += rBStandart_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtAciklama);
            groupBox5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox5.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox5.Location = new Point(245, 95);
            groupBox5.Margin = new Padding(10, 3, 3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(200, 389);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "SAHA İSMİ";
            // 
            // txtAciklama
            // 
            txtAciklama.BorderStyle = BorderStyle.None;
            txtAciklama.Dock = DockStyle.Fill;
            txtAciklama.ForeColor = Color.FromArgb(229, 125, 0);
            txtAciklama.Location = new Point(10, 21);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(187, 365);
            txtAciklama.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(229, 125, 0);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 516);
            button1.Name = "button1";
            button1.Size = new Size(475, 45);
            button1.TabIndex = 9;
            button1.Text = "TAMAMLA";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmSahaBilgiDuzenlemeEkrani
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(475, 561);
            Controls.Add(button1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(PnlUstMenu);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmSahaBilgiDuzenlemeEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSahaBilgiDuzenlemeEkrani";
            Load += frmSahaBilgiDuzenlemeEkrani_Load;
            PnlUstMenu.ResumeLayout(false);
            PnlUstMenu.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            gBoy.ResumeLayout(false);
            gBoy.PerformLayout();
            gBEn.ResumeLayout(false);
            gBEn.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlUstMenu;
        private Label label1;
        private Button btn_Kapat;
        private Panel PnLogo;
        private GroupBox groupBox1;
        private TextBox txtSahaAdi;
        private GroupBox groupBox2;
        private RadioButton rBYapay;
        private RadioButton rBDogal;
        private GroupBox groupBox3;
        private RadioButton rBKapali;
        private RadioButton rBAcik;
        private GroupBox groupBox4;
        private GroupBox gBoy;
        private TextBox txtBoy;
        private Label label2;
        private GroupBox gBEn;
        private TextBox txtEn;
        private RadioButton rBDiger;
        private RadioButton rBStandart;
        private GroupBox groupBox5;
        private TextBox txtAciklama;
        private Button button1;
    }
}