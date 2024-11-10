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
    public partial class frmSahaKayitEkrani : Form
    {
        public frmSahaKayitEkrani()
        {
            InitializeComponent();
        }


        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }//ignore

        private void label3_Click(object sender, EventArgs e)
        {

        }//ignore

        private void rBDogal_CheckedChanged(object sender, EventArgs e)
        {
            lblCimTuru.Text = "1";
            rBDogal.ForeColor = Color.MediumPurple;
            rBYapay.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBYapay_CheckedChanged(object sender, EventArgs e)
        {
            lblCimTuru.Text = "2";
            rBYapay.ForeColor = Color.MediumPurple;
            rBDogal.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBAcik_CheckedChanged(object sender, EventArgs e)
        {
            lblSahaTuru.Text = "1";
            rBAcik.ForeColor = Color.MediumPurple;
            rBKapali.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBKapali_CheckedChanged(object sender, EventArgs e)
        {
            lblSahaTuru.Text = "2";
            rBKapali.ForeColor = Color.MediumPurple;
            rBAcik.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBStandart_CheckedChanged(object sender, EventArgs e)
        {
            lblEn.Text = "200";
            lblBoy.Text = "500";
            rBStandart.ForeColor = Color.MediumPurple;
            rBDiger.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = false;
            gBoy.Visible = false;
            txtBoy.Text = "";
            txtEn.Text = "";
        }

        private void rBDiger_CheckedChanged(object sender, EventArgs e)
        {
            //degistiricem
            lblEn.Text = "800";
            lblBoy.Text = "400";
            rBDiger.ForeColor = Color.MediumPurple;
            rBStandart.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = true;
            gBoy.Visible = true;
            txtBoy.Text = "";
            txtEn.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }//ignore

        private void frmSahaKayitEkrani_Load(object sender, EventArgs e)
        {
            sahaKoduOlustur();
        }
        //id-no kod
        void sahaKoduOlustur()
        {
            Random rnd = new Random();
            string semboller = "0123456789876543211273452";
            string olusanKod = "";
            for (int i = 1; i < 6; i++)
            {

                olusanKod += semboller[rnd.Next(semboller.Length)];
            }
            lblSahaKod.Text = olusanKod.ToString();
        }

        private void BtnTamamla_Click(object sender, EventArgs e)
        {
            if (txtSahaAdi.Text != "")
            {
                
                if (rBDiger.Checked==true)
                {
                    if (txtEn.Text!="" && txtBoy.Text!="")
                    {
                        //degerler girilmistir || İSLEMLER YAPILABILIR
                       
                    }
                    else
                    {
                        //lutfen degerleri giriniz
                        //MessageBox.Show("SECİLİ VE BOS");
                        popupMenu menu = new popupMenu();
                        menu.lblMesaj.BackColor = Color.FromArgb(229, 125, 0);
                        menu.lblMesaj.Text = "LUTFEN SAHAYA AIT EN VE BOY DEGERLERINI GIRIN!!";
                        menu.Show();
                    }
                }
            }
            else {
                //saha adi bos ise ne olmalı ??
                //MessageBox.Show("İSİM BOS");
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb(229,125,0);
                menu.lblMesaj.Text = "SAHA ISIM ALANI BOS GECILEMEZ!!";
                menu.Show();

            }
        }
    }
}
