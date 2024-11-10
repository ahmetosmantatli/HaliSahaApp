using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliSahaOtomasyon
{
    public partial class frmSahaBilgiDuzenlemeEkrani : Form
    {
        public frmSahaBilgiDuzenlemeEkrani()
        {
            InitializeComponent();
        }

        private void frmSahaBilgiDuzenlemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void rBDogal_CheckedChanged(object sender, EventArgs e)
        {

            rBDogal.ForeColor = Color.FromArgb(229,125,0);
            rBYapay.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBYapay_CheckedChanged(object sender, EventArgs e)
        {

            rBYapay.ForeColor = Color.FromArgb(229, 125, 0);
            rBDogal.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBAcik_CheckedChanged(object sender, EventArgs e)
        {

            rBAcik.ForeColor = Color.FromArgb(229, 125, 0);
            rBKapali.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBKapali_CheckedChanged(object sender, EventArgs e)
        {

            rBKapali.ForeColor = Color.FromArgb(229, 125, 0);
            rBAcik.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBStandart_CheckedChanged(object sender, EventArgs e)
        {

            rBStandart.ForeColor = Color.FromArgb(229, 125, 0);
            rBDiger.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = false;
            gBoy.Visible = false;
            txtBoy.Text = "";
            txtEn.Text = "";
        }

        private void rBDiger_CheckedChanged(object sender, EventArgs e)
        {
            //degistiricem

            rBDiger.ForeColor = Color.FromArgb(229, 125, 0);
            rBStandart.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = true;
            gBoy.Visible = true;
            txtBoy.Text = "";
            txtEn.Text = "";
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
