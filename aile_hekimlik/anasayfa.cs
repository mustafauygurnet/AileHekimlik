using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aile_hekimlik
{
    public partial class anasayfa : Form
    {
        private void anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public static String hour = DateTime.Now.Hour.ToString();
        public static int saat = Convert.ToInt32(hour);
        public static String sabah = "Günaydın";
        public static String gunduz = "İyi Günler";
        public static String aksam = "İyi Akşamlar";
        public static String gece = "İyi Geceler";
        public static String giris_zaman = DateTime.Now.ToLongTimeString();
        DateTime giris_saat = Convert.ToDateTime(giris_zaman);

        public anasayfa()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.anasayfa_FormClosed);
        }
        private void saatim_Tick(object sender, EventArgs e)
        {
            int sistem_saat = DateTime.Now.Hour;
            int sistem_dakika = DateTime.Now.Minute;
            int sistem_saniye = DateTime.Now.Second;
            string sistem_zaman = "";
           
            if (sistem_saat < 10)
            {
                sistem_zaman += "0" + sistem_saat;
            }

            else
            {
                sistem_zaman += sistem_saat;
            }

            sistem_zaman += ":";

            if (sistem_dakika < 10)
            {
                sistem_zaman += "0" + sistem_dakika;
            }
            else
            {
                sistem_zaman += sistem_dakika;
            }

            sistem_zaman += ":";

            if (sistem_saniye < 10)
            {
                sistem_zaman += "0" + sistem_saniye;
            }
            else
            {
                sistem_zaman += sistem_saniye;
            }
            lbl_saat.Text = "Saatiniz: " + sistem_zaman;
        }
        private void anasayfa_Load(object sender, EventArgs e)
        {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;

            saatim.Start();
            if (saat >= 6 && saat < 12)
                sayin.Text = sabah + " Sayın " + anasayfa_giris.ad + " " + anasayfa_giris.soyad + " Sisteme Giriş Saatiniz: " + giris_zaman;
            else if (saat >= 12 && saat < 17)
                sayin.Text = gunduz + " Sayın " + anasayfa_giris.ad + " " + anasayfa_giris.soyad + " Sisteme Giriş Saatiniz: " + giris_zaman;
            else if (saat >= 17 && saat < 24)
                sayin.Text = aksam + " Sayın " + anasayfa_giris.ad + " " + anasayfa_giris.soyad + " Sisteme Giriş Saatiniz: " + giris_zaman;
            else if (saat >= 0 && saat < 6)
                sayin.Text = gece + " Sayın " + anasayfa_giris.ad + " " + anasayfa_giris.soyad + " Sisteme Giriş Saatiniz: " + giris_zaman;

        }
        private void btn_hastakayit_Click(object sender, EventArgs e)
        {
            form_gecisleri.hasta_gecis();
        }

        private void btn_hekimkayit_Click(object sender, EventArgs e)
        {
            form_gecisleri.hekim_gecis();
        }

        private void btn_randevukayit_Click(object sender, EventArgs e)
        {
            form_gecisleri.randevu_gecis();
        }

       

        private void btn_rapor_Click(object sender, EventArgs e)
        {

        }

        private void btn_yetkiliekle_Click(object sender, EventArgs e)
        {
            form_gecisleri.yetkiliekle_gecis();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            String cikis_zaman = DateTime.Now.ToLongTimeString();
            DateTime cikis_saat = Convert.ToDateTime(cikis_zaman);
            TimeSpan hesapla = (cikis_saat) - (giris_saat);
            
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Sistemden çıkmak istiyormusunuz? ","UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(cikis == DialogResult.Yes)
            {
                MessageBox.Show( "Güle Güle Sayın "+ anasayfa_giris.ad + " " + anasayfa_giris.soyad + "\nSistemden çıkıldı. \nÇıkış Saatiniz: " + cikis_zaman + "\n" + "Açık Kalma Süreniz: " + hesapla.Hours.ToString() + " Saat " + hesapla.Minutes.ToString() + " Dakika " + hesapla.Seconds.ToString() + " Saniye", "Güle Güle...",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void anasayfa_MouseLeave(object sender, EventArgs e)
        {
            say.Start();
        }
        private void anasayfa_MouseMove(object sender, MouseEventArgs e)
        {
            say.Stop();
        }
        int atilma = 900;
        private void say_Tick(object sender, EventArgs e)
        {
            int sayim = atilma / 60;
            atilma--;
            if (atilma == 0)
            {
                MessageBox.Show(sayim + " Dakika Boyunca İşlem Yapmadığınız İçin Sistemden Otomatik Atıldınız!","ÇIKIŞINIZ YAPILDI!", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkinda hakkinda_sayfa = new hakkinda();
            hakkinda_sayfa.Show();
        }

        private void kullanımŞartlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sartlar sartlar_sayfa = new sartlar();
            sartlar_sayfa.Show();
        }

        private void güncellemeKontrolüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelleme guncelle = new guncelleme();
            guncelle.Show();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iletisim iletisim_ac = new iletisim();
            iletisim_ac.Show();
        }
    }

}
