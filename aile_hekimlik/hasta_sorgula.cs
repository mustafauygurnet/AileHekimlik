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
    public partial class hasta_sorgula : Form
    {
        public hasta_sorgula()
        {
            InitializeComponent();
        }
        private void hasta_sorgula_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void btn_hastasorgula_sorgu_Click(object sender, EventArgs e)
        {
            anasayfa_giris.baglan.Open();
            OleDbCommand sorgu = new OleDbCommand("SELECT * FROM tbl_hasta WHERE TC_No=@tc", anasayfa_giris.baglan);
            sorgu.Parameters.AddWithValue("@tc", tb_hastasorgula_tc.Text);

            OleDbDataReader yazdir = sorgu.ExecuteReader();
            while(yazdir.Read())
            {
                lbl_hastasorgula_ad.Text = yazdir["Adi"].ToString();
                lbl_hastasorgula_soyad.Text = yazdir["Soyadi"].ToString();
                lbl_hastasorgula_dogumtarih.Text = yazdir["Dogum_Tarihi"].ToString();
                lbl_hastasorgula_dogumyeri.Text = yazdir["Dogum_Yeri"].ToString();
                lbl_hastasorgula_anne.Text = yazdir["Anne_Adi"].ToString();
                lbl_hastasorgula_baba.Text = yazdir["Baba_Adi"].ToString();
                lbl_hastasorgula_gsm.Text = yazdir["GSM_No"].ToString();
                lbl_hastasorgula_eposta.Text = yazdir["eposta"].ToString();
                lbl_hastasorgula_hekim.Text = yazdir["Hekim_Adi"].ToString();
                lbl_hastasorgula_cinsiyet.Text = yazdir["Cinsiyet"].ToString();
            }
            yazdir.Close();
            anasayfa_giris.baglan.Close();
            }

        private void btn_hastasorgula_temizle_Click(object sender, EventArgs e)
        {
            tb_hastasorgula_tc.Clear();
            lbl_hastasorgula_ad.Text = "-";
            lbl_hastasorgula_soyad.Text = "-";
            lbl_hastasorgula_dogumtarih.Text = "-";
            lbl_hastasorgula_dogumyeri.Text = "-";
            lbl_hastasorgula_anne.Text = "-";
            lbl_hastasorgula_baba.Text = "-";
            lbl_hastasorgula_gsm.Text = "-";
            lbl_hastasorgula_eposta.Text = "-";
            lbl_hastasorgula_hekim.Text = "-";
            lbl_hastasorgula_cinsiyet.Text = "-";
        }

        private void btn_hastasorgula_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
