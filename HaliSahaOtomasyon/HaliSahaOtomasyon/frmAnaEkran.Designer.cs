
namespace HaliSahaOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlUstMenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btn_Kapat = new Button();
            PnLogo = new Panel();
            label1 = new Label();
            PnlUstMenu.SuspendLayout();
            PnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // PnlUstMenu
            // 
            PnlUstMenu.BackColor = Color.White;
            PnlUstMenu.Controls.Add(button3);
            PnlUstMenu.Controls.Add(button2);
            PnlUstMenu.Controls.Add(button1);
            PnlUstMenu.Controls.Add(btn_Kapat);
            PnlUstMenu.Controls.Add(PnLogo);
            PnlUstMenu.Dock = DockStyle.Top;
            PnlUstMenu.Location = new Point(0, 0);
            PnlUstMenu.Name = "PnlUstMenu";
            PnlUstMenu.Size = new Size(1029, 60);
            PnlUstMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.ball;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(666, 0);
            button3.Name = "button3";
            button3.Size = new Size(241, 60);
            button3.TabIndex = 4;
            button3.Text = "KARŞILAŞMA";
            button3.UseVisualStyleBackColor = true;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseMove += button3_MouseMove;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.file__1_;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(433, 0);
            button2.Name = "button2";
            button2.Size = new Size(233, 60);
            button2.TabIndex = 3;
            button2.Text = "SAHA LİSTE";
            button2.UseVisualStyleBackColor = true;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseMove += button2_MouseMove;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.file;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(200, 0);
            button1.Name = "button1";
            button1.Size = new Size(233, 60);
            button1.TabIndex = 2;
            button1.Text = "SAHA KAYIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseMove += button1_MouseMove;
            // 
            // btn_Kapat
            // 
            btn_Kapat.BackColor = Color.FromArgb(64, 64, 64);
            btn_Kapat.Cursor = Cursors.Hand;
            btn_Kapat.Dock = DockStyle.Right;
            btn_Kapat.FlatAppearance.BorderSize = 0;
            btn_Kapat.FlatStyle = FlatStyle.Flat;
            btn_Kapat.ForeColor = Color.White;
            btn_Kapat.Location = new Point(989, 0);
            btn_Kapat.Name = "btn_Kapat";
            btn_Kapat.Size = new Size(40, 60);
            btn_Kapat.TabIndex = 1;
            btn_Kapat.Text = "X";
            btn_Kapat.UseVisualStyleBackColor = false;
            btn_Kapat.Click += btn_Kapat_Click;
            // 
            // PnLogo
            // 
            PnLogo.BackColor = Color.White;
            PnLogo.Controls.Add(label1);
            PnLogo.Dock = DockStyle.Left;
            PnLogo.Location = new Point(0, 0);
            PnLogo.Name = "PnLogo";
            PnLogo.Size = new Size(200, 60);
            PnLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.MediumPurple;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 60);
            label1.TabIndex = 1;
            label1.Text = "HaliSahaOtomasyon";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1029, 630);
            Controls.Add(PnlUstMenu);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            PnlUstMenu.ResumeLayout(false);
            PnLogo.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel PnlUstMenu;
        private Panel PnLogo;
        private Label label1;
        private Button btn_Kapat;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}
