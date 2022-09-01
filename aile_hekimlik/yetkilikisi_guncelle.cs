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
    public partial class yetkilikisi_guncelle : Form
    {
        public yetkilikisi_guncelle()
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
        private void yetkilikisi_guncelle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            baglan.Open();
            OleDbCommand kisi_getir = new OleDbCommand("SELECT * FROM tbl_yetkili WHERE TC_No=@tc", baglan);
            kisi_getir.Parameters.AddWithValue("@tc", yetkili_kayit.numara);
            OleDbDataReader oku = kisi_getir.ExecuteReader();

            oku.Read();
            tb_yetkiliguncelle_tc.Text = oku["TC_No"].ToString();
            tb_yetkiliguncelle_ad.Text = oku["Adi"].ToString();
            tb_yetkiliguncelle_soyad.Text = oku["Soyadi"].ToString();
            tb_yetkiliguncelle_parola.Text = oku["Parola"].ToString();
            tb_yetkiliguncelle_eposta.Text = oku["e_mail"].ToString();
            cb_yetkiliguncelle_unvan.Text = oku["Unvan"].ToString();
            oku.Close();
            baglan.Close();
        }
        private void btn_yetkiliguncelle_kaydet_Click(object sender, EventArgs e)
        {
            if (nesne_kontrol())
            {
                baglan.Open();
                OleDbCommand degistir = new OleDbCommand("UPDATE tbl_yetkili SET  TC_No=@tc, Adi=@ad, Soyadi=@soyad, Parola=@parola, e_mail=@eposta, Unvan=@unvan WHERE TC_No=@tc", baglan);
                degistir.Parameters.AddWithValue("@tc", tb_yetkiliguncelle_tc.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@ad", tb_yetkiliguncelle_ad.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@soyad", tb_yetkiliguncelle_soyad.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@parola", tb_yetkiliguncelle_parola.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@eposta", tb_yetkiliguncelle_eposta.Text.ToString().Trim());
                degistir.Parameters.AddWithValue("@unvan", cb_yetkiliguncelle_unvan.Text.ToString().Trim());

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

        private void btn_yetkiliguncelle_temizle_Click(object sender, EventArgs e)
        {
            nesne_sil();
            lbl_hata.Visible = false;
            lbl_okey.Visible = false;
        }

        private void btn_yetkiliguncelle_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            form_gecisleri.yetkiliekle_gecis();
        }
        private void nesne_sil()
        {
            tb_yetkiliguncelle_ad.Clear();
            tb_yetkiliguncelle_soyad.Clear();
            tb_yetkiliguncelle_parola.Clear();
            tb_yetkiliguncelle_eposta.Clear();
        }
    }
}
