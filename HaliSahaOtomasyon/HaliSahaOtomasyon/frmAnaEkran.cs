using System.Runtime.Versioning;
using System.Security.Policy;

namespace HaliSahaOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {

            Application.Exit(); //dialog result ?? uygulamayý kapatmak istiyormusunuz yes or no ?

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.file;
            button1.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.file;
            button1.ForeColor = Color.MediumPurple;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.file__1_;
            button2.ForeColor = Color.MediumPurple;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.file__1_;
            button2.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Image = Properties.Resources.ball;
            button3.ForeColor = Color.MediumPurple;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.ball;
            button3.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSecimEkrani frm = new frmSecimEkrani();
            frm.ShowDialog();
        }
    }
}
