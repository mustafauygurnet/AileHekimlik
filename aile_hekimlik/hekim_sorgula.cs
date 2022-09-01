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
    public partial class hekim_sorgula : Form
    {
        public hekim_sorgula()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=ailehekimlik.accdb");
        private void hekim_sorgula_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void btn_hekimsorgula_sorgu_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand sorgu = new OleDbCommand("SELECT * FROM tbl_hekim WHERE TC_No=@tc", baglan);
            sorgu.Parameters.AddWithValue("@tc", tb_hekimsorgula_tc.Text);

            OleDbDataReader yazdir = sorgu.ExecuteReader();
            while (yazdir.Read())
            {
                lbl_hekimsorgula_ad.Text = yazdir["Adi"].ToString();
                lbl_hekimsorgula_dogumtarih.Text = yazdir["Dogum_Tarihi"].ToString();
                lbl_hekimsorgula_dogumyeri.Text = yazdir["Dogum_Yeri"].ToString();
                lbl_hekimsorgula_sicil.Text = yazdir["Sicil_No"].ToString();
                lbl_hekimsorgula_gorev.Text = yazdir["Goreve_Baslama"].ToString();
                lbl_hekimsorgula_gsm.Text = yazdir["GSM_No"].ToString();
                lbl_hekimsorgula_eposta.Text = yazdir["eposta"].ToString();
                lbl_hekimsorgula_cinsiyet.Text = yazdir["Cinsiyet"].ToString();
            }
            yazdir.Close();
            baglan.Close();


        }
        private void btn_hekimsorgula_temizle_Click(object sender, EventArgs e)
        {
            tb_hekimsorgula_tc.Clear();
            tb_hekimsorgula_tc.Clear();
            lbl_hekimsorgula_ad.Text = "-";
            lbl_hekimsorgula_dogumtarih.Text = "-";
            lbl_hekimsorgula_dogumyeri.Text = "-";
            lbl_hekimsorgula_sicil.Text = "-";
            lbl_hekimsorgula_gorev.Text = "-";
            lbl_hekimsorgula_gsm.Text = "-";
            lbl_hekimsorgula_eposta.Text = "-";
            lbl_hekimsorgula_cinsiyet.Text = "-";
        }

        private void btn_hekimsorgula_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
