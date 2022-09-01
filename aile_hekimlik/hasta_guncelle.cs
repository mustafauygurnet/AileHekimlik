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
    public partial class hasta_guncelle : Form
    {
        public hasta_guncelle()
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
        private void hasta_guncelle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            anasayfa_giris.baglan.Open();
            OleDbCommand kisi_getir = new OleDbCommand("SELECT * FROM tbl_hasta WHERE TC_No=@tc", anasayfa_giris.baglan);
            kisi_getir.Parameters.AddWithValue("@tc",hastalar.numara);
            OleDbDataReader oku = kisi_getir.ExecuteReader();

            oku.Read();
            tb_hastaguncelle_tc.Text = oku["TC_No"].ToString();
            tb_hastaguncelle_ad.Text = oku["Adi"].ToString();
            tb_hastaguncelle_soyad.Text = oku["Soyadi"].ToString();
            tb_hastaguncelle_dogumtarih.Text = oku["Dogum_Tarihi"].ToString();
            tb_hastaguncelle_dogumyeri.Text = oku["Dogum_Yeri"].ToString();
            tb_hastaguncelle_anne.Text = oku["Anne_Adi"].ToString();
            tb_hastaguncelle_baba.Text = oku["Baba_Adi"].ToString();
            tb_hastaguncelle_gsm.Text = oku["GSM_No"].ToString();
            tb_hastaguncelle_eposta.Text = oku["eposta"].ToString();
            cb_hastaguncelle_hekimadi.Text = oku["Hekim_Adi"].ToString();
            cb_hastaguncelle_cinsiyet.Text = oku["Cinsiyet"].ToString();

            oku.Close();
            anasayfa_giris.baglan.Close();

        }

        private void btn_hastaguncelle_kaydet_Click(object sender, EventArgs e)
        {
            if (nesne_kontrol())
            {
                anasayfa_giris.baglan.Open();
                OleDbCommand degistir = new OleDbCommand("UPDATE tbl_hasta SET  TC_No=@tc, Adi=@ad, Soyadi=@soyad, Dogum_Tarihi=@dogum_tarih, Dogum_Yeri=@dogum_yer, Anne_Adi=@anne, Baba_Adi=@baba, GSM_No=@gsm, eposta=@eposta, Hekim_Adi=@hekim, Cinsiyet=@cinsiyet WHERE TC_No=@tc", anasayfa_giris.baglan);
                degistir.Parameters.AddWithValue("@tc", tb_hastaguncelle_tc.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@ad", tb_hastaguncelle_ad.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@soyad", tb_hastaguncelle_soyad.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@dogum_tarih", tb_hastaguncelle_dogumtarih.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@dogum_yer", tb_hastaguncelle_dogumyeri.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@anne", tb_hastaguncelle_anne.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@baba", tb_hastaguncelle_baba.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("gsm", tb_hastaguncelle_gsm.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@eposta", tb_hastaguncelle_eposta.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@hekim", cb_hastaguncelle_hekimadi.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@cinsiyet", cb_hastaguncelle_cinsiyet.Text.ToString().Trim());

                degistir.ExecuteNonQuery();
                anasayfa_giris.baglan.Close();
                lbl_okey.Visible = true;
                lbl_hata.Visible = false;
            }
            else
            {
                lbl_hata.Visible = true;
                lbl_okey.Visible = false;
            }            
        }

        private void btn_hastaguncelle_temizle_Click(object sender, EventArgs e)
        {
            tb_hastaguncelle_ad.Clear();
            tb_hastaguncelle_soyad.Clear();
            tb_hastaguncelle_dogumtarih.Clear();
            tb_hastaguncelle_dogumyeri.Clear();
            tb_hastaguncelle_anne.Clear();
            tb_hastaguncelle_baba.Clear();
            tb_hastaguncelle_gsm.Clear();
            tb_hastaguncelle_eposta.Clear();
            lbl_hata.Visible = false;
            lbl_okey.Visible = false;
        }

        private void btn_hastaguncelle_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            form_gecisleri.hasta_gecis();
        }
    }
}
