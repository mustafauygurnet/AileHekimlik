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
    public partial class yetkili_kisi : Form
    {
        public yetkili_kisi()
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

        private void btn_yetkilikisi_kaydet_Click(object sender, EventArgs e)
        {
            if(nesne_kontrol())
            {
                baglan.Open();
                OleDbCommand kaydet = new OleDbCommand("INSERT INTO tbl_yetkili (TC_No, Adi, Soyadi, Parola, e_mail, Unvan) VALUES (@tc, @ad, @soyad, @parola, @eposta, @unvan)", baglan);
                kaydet.Parameters.AddWithValue("@tc", tb_yetkilikisi_tc.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@ad", tb_yetkilikisi_ad.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@soyad", tb_yetkilikisi_soyad.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@parola", tb_yetkilikisi_parola.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@eposta", tb_yetkilikisi_eposta.Text.Trim().ToString());
                kaydet.Parameters.AddWithValue("@unvan", cb_yetkilikisi_unvan.Text.Trim().ToString());
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

        private void btn_yetkilikisi_temizle_Click(object sender, EventArgs e)
        {
            nesne_sil();
            lbl_okey.Visible = false;
        }

        private void btn_yetkilikisi_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            form_gecisleri.yetkiliekle_gecis();
        }

        private void nesne_sil()
        {
            tb_yetkilikisi_tc.Clear();
            tb_yetkilikisi_ad.Clear();
            tb_yetkilikisi_soyad.Clear();
            tb_yetkilikisi_parola.Clear();
            tb_yetkilikisi_eposta.Clear();
            lbl_hata.Visible = false;
        }

        private void yetkili_kisi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
    }
}
