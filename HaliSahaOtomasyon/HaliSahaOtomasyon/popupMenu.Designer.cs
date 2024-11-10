namespace HaliSahaOtomasyon
{
    partial class popupMenu
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
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // lblMesaj
            // 
            lblMesaj.BackColor = Color.White;
            lblMesaj.Dock = DockStyle.Fill;
            lblMesaj.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMesaj.Location = new Point(0, 0);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(519, 243);
            lblMesaj.TabIndex = 0;
            lblMesaj.Text = "label1";
            lblMesaj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // popupMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(519, 243);
            Controls.Add(lblMesaj);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "popupMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "popupMenu";
            ResumeLayout(false);
        }

        #endregion

        public Label lblMesaj;
    }
}