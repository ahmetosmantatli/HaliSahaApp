using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliSahaOtomasyon
{
    public partial class frmSecimEkrani : Form
    {
        public frmSecimEkrani()
        {
            InitializeComponent();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSahaKayitEkrani frm = new frmSahaKayitEkrani();
            frm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //önce bir liste ekranına gitmemiz gerekecek neden ?? -> saha idsini almak ve bu idye gore verileri cekmek
            frmSahaBilgiDuzenlemeEkrani frm = new frmSahaBilgiDuzenlemeEkrani();
            frm.ShowDialog();
            
        }
    }
}
