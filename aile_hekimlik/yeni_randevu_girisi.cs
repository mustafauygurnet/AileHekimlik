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
    public partial class yeni_randevu_girisi : Form
    {
        public yeni_randevu_girisi()
        {
            InitializeComponent();
            ToolTip tooltip = new ToolTip();
            tooltip.ShowAlways = true;
            tooltip.SetToolTip(lbl_hata, "Lütfen boş alan bırakmayınız ya da randevu zaman dilimini kontrol ediniz!");
            tooltip.SetToolTip(lbl_okey, "Randevu başarılı bir şekilde kaydedildi.");
            tooltip.IsBalloon = true;
            tooltip.ToolTipIcon = ToolTipIcon.Warning;
            tooltip.ToolTipTitle = "Uyarı";

        }
        DateTime tarih = DateTime.Now;
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=ailehekimlik.accdb");

        private void tb_yenirandevu_tc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                baglan.Open();
                OleDbCommand sorgu = new OleDbCommand("SELECT * FROM tbl_hasta WHERE TC_No=@tc", baglan);
                sorgu.Parameters.AddWithValue("@tc", tb_yenirandevu_tc.Text);

                OleDbDataReader yazdir = sorgu.ExecuteReader();
                while (yazdir.Read())
                {
                    lbl_yenirandevu_ad.Text = yazdir["Adi"].ToString();
                    lbl_yenirandevu_soyad.Text = yazdir["Soyadi"].ToString();
                    lbl_yenirandevu_dogumtarih.Text = yazdir["Dogum_Tarihi"].ToString();
                    lbl_yenirandevu_dogumyeri.Text = yazdir["Dogum_Yeri"].ToString();
                    lbl_yenirandevu_anne.Text = yazdir["Anne_Adi"].ToString();
                    lbl_yenirandevu_baba.Text = yazdir["Baba_Adi"].ToString();
                    lbl_yenirandevu_gsm.Text = yazdir["GSM_No"].ToString();
                    lbl_yenirandevu_eposta.Text = yazdir["eposta"].ToString();
                    lbl_yenirandevu_hekim.Text = yazdir["Hekim_Adi"].ToString();
                    lbl_yenirandevu_cinsiyet.Text = yazdir["Cinsiyet"].ToString();
                }
                yazdir.Close();
                baglan.Close();
            }
        }
        void gun_sec()
        {
            int i = 0;
            while (tb_yenirandevu_randevu.Items.Count != 5)
            {
                if (tarih.AddDays(i).DayOfWeek.ToString() != "Saturday" && tarih.AddDays(i).DayOfWeek.ToString() != "Sunday")
                {
                    tb_yenirandevu_randevu.Items.Add(tarih.AddDays(i).ToShortDateString());
                }
                i++;
            }
        }
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
                bool durum = cb_yenirandevu_doktor.Items.Contains(deger);
                if (!durum)
                {
                    cb_yenirandevu_doktor.Items.Add(deger).ToString();
                }
                baglan.Close();
            }
        }
        private void yeni_randevu_girisi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            hekim();
            gun_sec();
        }
        private void btn_yenirandevu_kaydet_Click(object sender, EventArgs e)
        {
            if (kontrol())
            {
                baglan.Open();
                OleDbCommand kaydet = new OleDbCommand("INSERT INTO tbl_randevu(TC_No, Doktor_Adi, Randevu_Tarihi, Randevu_Saati, Hekime_Not) VALUES (@tc, @doktor, @tarih, @saat, @not)", baglan);
                kaydet.Parameters.AddWithValue("@tc", tb_yenirandevu_tc.Text.ToString().Trim());
                kaydet.Parameters.AddWithValue("@doktor", cb_yenirandevu_doktor.Text.ToString().Trim());
                kaydet.Parameters.AddWithValue("@tarih", tb_yenirandevu_randevu.Text.ToString().Trim());
                kaydet.Parameters.AddWithValue("@saat", cb_yenirandevu_saat.Text.ToString().Trim());
                kaydet.Parameters.AddWithValue("@not", rtb_yenirandevu_not.Text.ToString().Trim());
                kaydet.ExecuteNonQuery();

                kaydet.Dispose();
                baglan.Close();

                MessageBox.Show(tb_yenirandevu_tc.Text.ToString() + " T.C. No'lu " + lbl_yenirandevu_ad.Text + " " + lbl_yenirandevu_soyad.Text+ " adlı kişiye " + tb_yenirandevu_randevu.Text + " sat " + cb_yenirandevu_saat.Text + " zaman dilimine randevu verilmiştir.", "Randevu Onaylama", MessageBoxButtons.OK,MessageBoxIcon.Information);
                nesne_sil();
                lbl_okey.Visible = true;
            }
            else
            {
                MessageBox.Show("Seçtiğiniz zaman dilimine randevu veremiyoruz. Lütfen farklı bir zaman dilimi seçin.", "Randevu Uyarı!", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                lbl_hata.Visible = true;
                lbl_okey.Visible = false;
            }
        }

        private void btn_yenirandevu_temizle_Click(object sender, EventArgs e)
        {
            nesne_sil();
            lbl_okey.Visible = false;
        }

        private void btn_yenirandevu_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            form_gecisleri.randevu_gecis();
        }
        bool kontrol()
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM tbl_randevu WHERE Doktor_Adi=@doktor AND Randevu_Tarihi=@tarih AND Randevu_Saati=@saat", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@doktor", cb_yenirandevu_doktor.Text.ToString().Trim());
            adaptor.SelectCommand.Parameters.AddWithValue("@tarih", tb_yenirandevu_randevu.Text.ToString().Trim());
            adaptor.SelectCommand.Parameters.AddWithValue("@saat", cb_yenirandevu_saat.Text.ToString().Trim());

            DataTable table = new DataTable();
            adaptor.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void nesne_sil()
        {
            tb_yenirandevu_tc.Clear();
            rtb_yenirandevu_not.Clear();
            tb_yenirandevu_randevu.Text = "Lütfen Randevu Tarihi Seçiniz";
            cb_yenirandevu_doktor.Text = "Lütfen Hekim Seçiniz";
            cb_yenirandevu_saat.Text = "Lütfen Randevu Saati Seçiniz";

            lbl_yenirandevu_ad.Text = "-";
            lbl_yenirandevu_soyad.Text = "-";
            lbl_yenirandevu_dogumtarih.Text = "-";
            lbl_yenirandevu_dogumyeri.Text = "-";
            lbl_yenirandevu_anne.Text = "-";
            lbl_yenirandevu_baba.Text = "-";
            lbl_yenirandevu_gsm.Text = "-";
            lbl_yenirandevu_eposta.Text = "-";
            lbl_yenirandevu_hekim.Text = "-";
            lbl_yenirandevu_cinsiyet.Text = "-";
            lbl_hata.Visible = false;
        }
    }
}
