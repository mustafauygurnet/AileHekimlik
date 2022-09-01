using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace aile_hekimlik
{
    public partial class yeni_hasta_girisi : Form
    {
        public yeni_hasta_girisi()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=ailehekimlik.accdb");
        void hekim()
        {
            baglan.Open();
            OleDbCommand ekle = new OleDbCommand();
            DataSet ds = new DataSet();
   
            OleDbDataAdapter da = new OleDbDataAdapter("Select Adi from tbl_hekim", baglan);
            da.Fill(ds, "tbl_hekim");

            foreach (DataRow satir in ds.Tables["tbl_hekim"].Rows)
            {
                string deger = satir[0].ToString();
                bool durum = cb_yenihasta_hekimadi.Items.Contains(deger);
                if (!durum)
                {
                    cb_yenihasta_hekimadi.Items.Add(deger).ToString();
                }
                baglan.Close();
            }
        }
        private bool nesne_kontrol()
        {
            bool bos_kontrol = false;
            foreach (Control nesne in this.Controls)
            {
                if (nesne is TextBox)
                {
                    if (!String.IsNullOrEmpty(nesne.Text))
                    {
                        bos_kontrol = true;
                    }
                }
            }
            return bos_kontrol;
        }
        private void yeni_hasta_girisi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            hekim();
            ToolTip tooltip = new ToolTip();
            tooltip.ShowAlways = true;
            tooltip.SetToolTip(lbl_hata, "Lütfen boş alan bırakmayınız, istenilen uzunlukta giriniz ve girdilerinizi kontrol ediniz!");
            tooltip.SetToolTip(lbl_okey,"Kişi başarılı bir şekilde kaydedildi.");
            tooltip.IsBalloon = true;
            tooltip.ToolTipIcon = ToolTipIcon.Warning;
            tooltip.ToolTipTitle = "Uyarı";
        }

        void tc_kontrol_metod()
        {
            anasayfa_giris.baglan.Open();
            OleDbCommand comand = new OleDbCommand("SELECT * FROM tbl_hasta", anasayfa_giris.baglan);
            comand.ExecuteNonQuery();
            OleDbDataReader oku = comand.ExecuteReader();
            while (oku.Read())
            {
                if (oku["TC_No"].ToString() == tb_yenihasta_tc.Text)
                {
                    MessageBox.Show("Hata Mesajı Aldınız! \nMuhtemel Çözümler:\n1. T.C. No alanını boş girdiniz.\n2. Bu T.C. numaralı kişi sistemde kayıtlı.\nGirdileri gözden geçirin.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            anasayfa_giris.baglan.Close();
        }
        private void btn_yenihasta_kaydet_Click(object sender, EventArgs e)
        {
            tc_kontrol_metod();
            if (nesne_kontrol())
            {
                baglan.Open();
                OleDbCommand kaydet = new OleDbCommand("INSERT INTO tbl_hasta(TC_No, Adi, Soyadi, Dogum_Tarihi,Dogum_Yeri, Anne_Adi, Baba_Adi, GSM_No, eposta, Hekim_Adi, Cinsiyet) VALUES (@tc, @ad, @soyad, @dogum_tarih, @dogum_yer, @anne_adi, @baba_adi, @gsm, @eposta, @hekim, @cinsiyet)", baglan);
                kaydet.Parameters.AddWithValue("@tc", tb_yenihasta_tc.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@ad", tb_yenihasta_ad.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@soyad", tb_yenihasta_soyad.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@dogum_tarih", tb_yenihasta_dogumtarih.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@dogum_yer", tb_yenihasta_dogumyer.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@anne_adi", tb_yenihasta_anne.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@baba_adi", tb_yenihasta_baba.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@gsm", tb_yenihasta_gsm.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@eposta", tb_yenihasta_eposta.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@hekim", cb_yenihasta_hekimadi.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@cinsiyet", cb_yenihasta_cinsiyet.Text.Trim().ToString());
                kaydet.ExecuteNonQuery();

                kaydet.Dispose();
                baglan.Close();

                nesne_sil();
                lbl_okey.Visible = true;
            }
            else
            {
                lbl_hata.Visible = true;
                lbl_okey.Visible = false;
            }
        }
        private void btn_yenihasta_temizle_Click(object sender, EventArgs e)
        {
            nesne_sil();
            lbl_okey.Visible = false;
        }

        private void btn_yenihasta_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            form_gecisleri.hasta_gecis();
        }

        private void nesne_sil()
        {
            tb_yenihasta_tc.Clear();
            tb_yenihasta_ad.Clear();
            tb_yenihasta_soyad.Clear();
            tb_yenihasta_dogumtarih.Clear();
            tb_yenihasta_dogumyer.Clear();
            tb_yenihasta_anne.Clear();
            tb_yenihasta_baba.Clear();
            tb_yenihasta_gsm.Clear();
            tb_yenihasta_eposta.Clear();
            cb_yenihasta_cinsiyet.Text = "Lütfen Cinsiyet Seçin";
            cb_yenihasta_hekimadi.Text = "Lütfen Hekim Seçin";
            lbl_hata.Visible = false;
        }
    }
}
