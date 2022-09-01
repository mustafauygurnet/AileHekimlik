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
    public partial class yeni_hekim_girisi : Form
    {
        public yeni_hekim_girisi()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=ailehekimlik.accdb");
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

        void tc_kontrol_metod()
        {
            if(baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            OleDbCommand comand = new OleDbCommand("SELECT * FROM tbl_hekim", baglan);
            comand.ExecuteNonQuery();
            OleDbDataReader oku = comand.ExecuteReader();
            while (oku.Read())
            {
                if (oku["Sicil_No"].ToString() == tb_yenihekim_sicil.Text || oku["TC_No"].ToString() == tb_yenihekim_tc.Text)
                {
                    MessageBox.Show("Hata Mesajı Aldınız! \nMuhtemel Çözümler:\n1. Sicil No ya da T.C. No alanını boş girdiniz.\n2. Bu Sicil No ya da T.C. numaralı kişi sistemde kayıtlı.\nGirdileri gözden geçirin.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            baglan.Close();
        }

        private void yeni_hekim_girisi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            ToolTip tooltip = new ToolTip();
            tooltip.ShowAlways = true;
            tooltip.SetToolTip(lbl_hata, "Lütfen boş alan bırakmayınız, istenilen uzunlukta giriniz ve girdilerinizi kontrol ediniz!");
            tooltip.SetToolTip(lbl_okey, "Kişi başarılı bir şekilde kaydedildi.");
            tooltip.IsBalloon = true;
            tooltip.ToolTipIcon = ToolTipIcon.Warning;
            tooltip.ToolTipTitle = "Uyarı";
        }

        private void btn_yenihekim_kaydet_Click(object sender, EventArgs e)
        {
            tc_kontrol_metod();
            if(nesne_kontrol())
            {
                baglan.Open();
                OleDbCommand kaydet = new OleDbCommand("INSERT INTO tbl_hekim(TC_No, Adi, Dogum_Tarihi, Dogum_Yeri, Sicil_No, Goreve_Baslama,GSM_No, eposta, Cinsiyet) VALUES (@tc, @ad, @dogumtarih, @dogumyer, @sicil, @gorev, @gsm, @eposta, @cinsiyet)", baglan);
                kaydet.Parameters.AddWithValue("@tc", tb_yenihekim_tc.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@ad", tb_yenihekim_ad.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@dogumtarih", tb_yenihekim_dogumtarih.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@dogumyer", tb_yenihekim_dogumyer.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@sicil", tb_yenihekim_sicil.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@gorev", tb_yenihekim_gorev.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@gsm", tb_yenihekim_gsm.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@eposta", tb_yenihekim_eposta.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@cinsiyet", cb_yenihekim_cinsiyet.Text.Trim().ToString());
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

        private void btn_yenihekim_temizle_Click(object sender, EventArgs e)
        {
            nesne_sil();
            lbl_okey.Visible = false;
        }

        private void btn_yenihekim_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            form_gecisleri.hekim_gecis();
        }

        private void nesne_sil()
        {
            tb_yenihekim_tc.Clear();
            tb_yenihekim_ad.Clear();
            tb_yenihekim_dogumtarih.Clear();
            tb_yenihekim_dogumyer.Clear();
            tb_yenihekim_sicil.Clear();
            tb_yenihekim_gorev.Clear();
            tb_yenihekim_gsm.Clear();
            tb_yenihekim_eposta.Clear();
            cb_yenihekim_cinsiyet.Items.Clear();
            cb_yenihekim_cinsiyet.Text = "Lütfen Cinsiyet Seçin";
            lbl_hata.Visible = false;
        }
    }
}
