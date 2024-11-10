namespace HaliSahaOtomasyon
{
    partial class frmSecimEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecimEkrani));
            PnlUstMenu = new Panel();
            label1 = new Label();
            btn_Kapat = new Button();
            PnLogo = new Panel();
            button1 = new Button();
            button2 = new Button();
            PnlUstMenu.SuspendLayout();
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
            PnlUstMenu.Size = new Size(605, 60);
            PnlUstMenu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 2;
            label1.Text = "(İŞLEM TERCİH EKRANI)";
            // 
            // btn_Kapat
            // 
            btn_Kapat.BackColor = Color.MediumPurple;
            btn_Kapat.Cursor = Cursors.Hand;
            btn_Kapat.Dock = DockStyle.Right;
            btn_Kapat.FlatAppearance.BorderSize = 0;
            btn_Kapat.FlatStyle = FlatStyle.Flat;
            btn_Kapat.ForeColor = Color.White;
            btn_Kapat.Location = new Point(565, 0);
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
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(37, 103);
            button1.Name = "button1";
            button1.Size = new Size(211, 92);
            button1.TabIndex = 2;
            button1.Text = "YENİ KAYIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(331, 103);
            button2.Name = "button2";
            button2.Size = new Size(214, 92);
            button2.TabIndex = 3;
            button2.Text = "KAYIT DUZENLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmSecimEkrani
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(605, 245);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PnlUstMenu);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmSecimEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSecimEkrani";
            PnlUstMenu.ResumeLayout(false);
            PnlUstMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlUstMenu;
        private Button btn_Kapat;
        private Panel PnLogo;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}