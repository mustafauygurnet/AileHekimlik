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
    public partial class hekim_guncelle : Form
    {
        public hekim_guncelle()
        {
            InitializeComponent();
            ToolTip tooltip = new ToolTip();
            tooltip.ShowAlways = true;
            tooltip.SetToolTip(lbl_hata, "Lütfen boş alan bırakmayınız, istenilen uzunlukta giriniz ve girdilerinizi kontrol ediniz!");
            tooltip.SetToolTip(lbl_okey, "Kişi başarılı bir şekilde kaydedildi.");
            tooltip.IsBalloon = true;
            tooltip.ToolTipIcon = ToolTipIcon.Warning;
            tooltip.ToolTipTitle = "Uyarı";
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
        private void hekim_guncelle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            baglan.Open();
            OleDbCommand kisi_getir = new OleDbCommand("SELECT * FROM tbl_hekim WHERE TC_No=@tc", baglan);
            kisi_getir.Parameters.AddWithValue("@tc", hekimler.numara);
            OleDbDataReader oku = kisi_getir.ExecuteReader();

            oku.Read();
            tb_hekimguncelle_tc.Text = oku["TC_No"].ToString();
            tb_hekimguncelle_ad.Text = oku["Adi"].ToString();
            tb_hekimguncelle_dogumtarih.Text = oku["Dogum_Tarihi"].ToString();
            tb_hekimguncelle_dogumyeri.Text = oku["Dogum_Yeri"].ToString();
            tb_hekimguncelle_sicil.Text = oku["Sicil_No"].ToString();
            tb_hekimguncelle_gorev.Text = oku["Goreve_Baslama"].ToString();
            tb_hekimguncelle_gsm.Text = oku["GSM_No"].ToString();
            tb_hekimguncelle_eposta.Text = oku["eposta"].ToString();
            cb_hekimguncelle_cinsiyet.Text = oku["Cinsiyet"].ToString();

            oku.Close();
            baglan.Close();
        }

        private void btn_hekimguncelle_kaydet_Click(object sender, EventArgs e)
        {
            if (nesne_kontrol())
            {
                baglan.Open();
                OleDbCommand degistir = new OleDbCommand("UPDATE tbl_hekim SET  TC_No=@tc, Adi=@ad, Dogum_Tarihi=@dogum_tarih, Dogum_Yeri=@dogum_yer, Sicil_No=@sicil, Goreve_Baslama=@gorev, GSM_No=@gsm, eposta=@eposta, Cinsiyet=@cinsiyet WHERE TC_No=@tc", baglan);
                degistir.Parameters.AddWithValue("@tc", tb_hekimguncelle_tc.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@ad", tb_hekimguncelle_ad.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@dogum_tarih", tb_hekimguncelle_dogumtarih.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@dogum_yer", tb_hekimguncelle_dogumyeri.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@sicil", tb_hekimguncelle_sicil.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@gorev", tb_hekimguncelle_gorev.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("gsm", tb_hekimguncelle_gsm.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@eposta", tb_hekimguncelle_eposta.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@cinsiyet", cb_hekimguncelle_cinsiyet.Text.ToString().Trim());

                degistir.ExecuteNonQuery();
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

        private void btn_hekimguncelle_temizle_Click(object sender, EventArgs e)
        {
            nesne_sil();
            lbl_hata.Visible = false;
            lbl_okey.Visible = false;
        }

        private void btn_hekimguncelle_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            form_gecisleri.hekim_gecis();
        }
        private void nesne_sil()
        {
            tb_hekimguncelle_ad.Clear();
            tb_hekimguncelle_dogumtarih.Clear();
            tb_hekimguncelle_dogumyeri.Clear();
            tb_hekimguncelle_gorev.Clear();
            tb_hekimguncelle_gsm.Clear();
            tb_hekimguncelle_eposta.Clear();
        }
    }
}
