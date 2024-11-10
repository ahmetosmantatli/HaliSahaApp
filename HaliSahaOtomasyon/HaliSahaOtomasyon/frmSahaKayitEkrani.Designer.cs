namespace HaliSahaOtomasyon
{
    partial class frmSahaKayitEkrani
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
            lblSahaKod = new Label();
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
            textBox1 = new TextBox();
            BtnTamamla = new Button();
            lblCimTuru = new Label();
            lblSahaTuru = new Label();
            lblEn = new Label();
            lblBoy = new Label();
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
            PnlUstMenu.Controls.Add(lblSahaKod);
            PnlUstMenu.Controls.Add(label1);
            PnlUstMenu.Controls.Add(btn_Kapat);
            PnlUstMenu.Controls.Add(PnLogo);
            PnlUstMenu.Dock = DockStyle.Top;
            PnlUstMenu.Location = new Point(0, 0);
            PnlUstMenu.Name = "PnlUstMenu";
            PnlUstMenu.Size = new Size(475, 60);
            PnlUstMenu.TabIndex = 2;
            // 
            // lblSahaKod
            // 
            lblSahaKod.AutoSize = true;
            lblSahaKod.ForeColor = Color.Coral;
            lblSahaKod.Location = new Point(347, 24);
            lblSahaKod.Name = "lblSahaKod";
            lblSahaKod.Size = new Size(0, 21);
            lblSahaKod.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(170, 21);
            label1.TabIndex = 2;
            label1.Text = "(SAHA KAYIT EKRANI)";
            // 
            // btn_Kapat
            // 
            btn_Kapat.BackColor = Color.MediumPurple;
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
            PnLogo.BackColor = Color.MediumPurple;
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
            groupBox1.Location = new Point(13, 91);
            groupBox1.Margin = new Padding(10, 3, 3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(200, 65);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "SAHA İSMİ";
            // 
            // txtSahaAdi
            // 
            txtSahaAdi.BorderStyle = BorderStyle.None;
            txtSahaAdi.Dock = DockStyle.Bottom;
            txtSahaAdi.ForeColor = Color.MediumPurple;
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
            groupBox2.Location = new Point(13, 179);
            groupBox2.Margin = new Padding(10, 3, 3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 3, 3, 3);
            groupBox2.Size = new Size(200, 65);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "ÇİM TÜRÜ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rBYapay
            // 
            rBYapay.AutoSize = true;
            rBYapay.Cursor = Cursors.Hand;
            rBYapay.FlatStyle = FlatStyle.Flat;
            rBYapay.Location = new Point(115, 28);
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
            rBDogal.ForeColor = Color.MediumPurple;
            rBDogal.Location = new Point(10, 28);
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
            groupBox3.Location = new Point(13, 265);
            groupBox3.Margin = new Padding(10, 3, 3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 3, 3);
            groupBox3.Size = new Size(200, 65);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "SAHA TÜRÜ";
            // 
            // rBKapali
            // 
            rBKapali.AutoSize = true;
            rBKapali.Cursor = Cursors.Hand;
            rBKapali.FlatStyle = FlatStyle.Flat;
            rBKapali.Location = new Point(115, 28);
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
            rBAcik.ForeColor = Color.MediumPurple;
            rBAcik.Location = new Point(17, 28);
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
            groupBox4.Location = new Point(13, 356);
            groupBox4.Margin = new Padding(10, 3, 3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 3, 3, 3);
            groupBox4.Size = new Size(200, 137);
            groupBox4.TabIndex = 5;
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
            txtBoy.ForeColor = Color.MediumPurple;
            txtBoy.Location = new Point(10, 18);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(43, 15);
            txtBoy.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 0);
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
            gBEn.Enter += groupBox5_Enter;
            // 
            // txtEn
            // 
            txtEn.BorderStyle = BorderStyle.None;
            txtEn.Dock = DockStyle.Bottom;
            txtEn.ForeColor = Color.MediumPurple;
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
            rBDiger.Location = new Point(7, 92);
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
            rBStandart.ForeColor = Color.MediumPurple;
            rBStandart.Location = new Point(17, 28);
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
            groupBox5.Controls.Add(textBox1);
            groupBox5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox5.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox5.Location = new Point(235, 91);
            groupBox5.Margin = new Padding(10, 3, 3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(200, 402);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "SAHA İSMİ";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.ForeColor = Color.MediumPurple;
            textBox1.Location = new Point(10, 21);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 378);
            textBox1.TabIndex = 0;
            // 
            // BtnTamamla
            // 
            BtnTamamla.BackColor = Color.MediumPurple;
            BtnTamamla.Cursor = Cursors.Hand;
            BtnTamamla.Dock = DockStyle.Bottom;
            BtnTamamla.FlatAppearance.BorderSize = 0;
            BtnTamamla.FlatStyle = FlatStyle.Flat;
            BtnTamamla.ForeColor = Color.White;
            BtnTamamla.Location = new Point(0, 503);
            BtnTamamla.Name = "BtnTamamla";
            BtnTamamla.Size = new Size(475, 45);
            BtnTamamla.TabIndex = 7;
            BtnTamamla.Text = "TAMAMLA";
            BtnTamamla.UseVisualStyleBackColor = false;
            BtnTamamla.Click += BtnTamamla_Click;
            // 
            // lblCimTuru
            // 
            lblCimTuru.AutoSize = true;
            lblCimTuru.Location = new Point(472, 121);
            lblCimTuru.Name = "lblCimTuru";
            lblCimTuru.Size = new Size(16, 21);
            lblCimTuru.TabIndex = 8;
            lblCimTuru.Text = "1";
            lblCimTuru.Click += label3_Click;
            // 
            // lblSahaTuru
            // 
            lblSahaTuru.AutoSize = true;
            lblSahaTuru.Location = new Point(472, 179);
            lblSahaTuru.Name = "lblSahaTuru";
            lblSahaTuru.Size = new Size(16, 21);
            lblSahaTuru.TabIndex = 9;
            lblSahaTuru.Text = "1";
            // 
            // lblEn
            // 
            lblEn.AutoSize = true;
            lblEn.Location = new Point(472, 322);
            lblEn.Name = "lblEn";
            lblEn.Size = new Size(37, 21);
            lblEn.TabIndex = 10;
            lblEn.Text = "200";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(515, 322);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(37, 21);
            lblBoy.TabIndex = 11;
            lblBoy.Text = "500";
            // 
            // frmSahaKayitEkrani
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(475, 548);
            Controls.Add(lblBoy);
            Controls.Add(lblEn);
            Controls.Add(lblSahaTuru);
            Controls.Add(lblCimTuru);
            Controls.Add(BtnTamamla);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(PnlUstMenu);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmSahaKayitEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSahaKayitEkrani";
            Load += frmSahaKayitEkrani_Load;
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
            PerformLayout();
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
        private Label label2;
        private RadioButton rBDiger;
        private RadioButton rBStandart;
        private GroupBox gBoy;
        private TextBox txtBoy;
        private GroupBox gBEn;
        private TextBox txtEn;
        private GroupBox groupBox5;
        private TextBox textBox1;
        private Button BtnTamamla;
        private Label lblCimTuru;
        private Label lblSahaTuru;
        private Label lblEn;
        private Label lblBoy;
        private Label lblSahaKod;
    }
}