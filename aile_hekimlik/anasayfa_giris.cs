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
    public partial class anasayfa_giris : Form
    {
        

        public anasayfa_giris()
        {
            InitializeComponent();
        }
            public static String ad = "";
            public static String soyad = "";

       public static OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=ailehekimlik.accdb");

        private void anasayfa_giris_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            ToolTip tooltip = new ToolTip();
            tooltip.ShowAlways = true;
            tooltip.SetToolTip(lbl_girishata, "Lütfen boş alan bırakmayınız ve istenilen uzunlukta giriniz!");
            tooltip.SetToolTip(lbl_hata, "Kullanıcı Adı veya Şifre Hatalı");
            tooltip.IsBalloon = true;
            tooltip.ToolTipIcon = ToolTipIcon.Warning;
            tooltip.ToolTipTitle = "Uyarı";
        }

        private void btn_anasayfagiris_giris_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            OleDbCommand giris = new OleDbCommand("SELECT * FROM tbl_yetkili WHERE TC_No=@tc AND Parola=@parola", baglan);
            giris.Parameters.AddWithValue("@tc", tb_anasayfagiris_tc.Text.Trim().ToString());
            giris.Parameters.AddWithValue("@parola", tb_anasayfagiris_sifre.Text.Trim().ToString());

           

            DataTable table = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(giris);
            adapter.Fill(table);

            giris.Dispose();

            if (table.Rows.Count > 0)
            {
                lbl_hata.Visible = false;
                lbl_girishata.Visible = false;
                MessageBox.Show("Hoşgeldiniz Sayın " + ad + " " + soyad, "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                anasayfa anasayfa_formu_ac = new anasayfa();
                anasayfa_formu_ac.Show();
            }
            else if (tb_anasayfagiris_tc.Text =="" || tb_anasayfagiris_sifre.Text == "")
            {
                lbl_girishata.Visible = true;
                lbl_hata.Visible = false;
            }
                
            else
            {
                lbl_hata.Visible = true;
                lbl_girishata.Visible = false;
            }
            baglan.Close();
        }
        private void btn_anasayfagiris_temizle_Click(object sender, EventArgs e)
        {
            tb_anasayfagiris_tc.Clear();
            tb_anasayfagiris_sifre.Clear();
            lbl_girishata.Visible = false;
            lbl_hata.Visible = false;
        }
    }
}
