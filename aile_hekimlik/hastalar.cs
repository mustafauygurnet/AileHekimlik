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
    public partial class hastalar : Form
    {
        public hastalar()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=ailehekimlik.accdb");
        private void hastalar_Load(object sender, EventArgs e)
        {
            listview_hastakayit.View = View.Details;
            listview_hastakayit.Columns.Add("Sıra", 30, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("T.C. No", 90, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("Ad", 90, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("Soyad", 90, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("Doğum Tarihi", 90, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("Doğum Yeri", 90, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("Anne Adı", 120, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("Baba Adı", 120, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("GSM No", 90, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("E Posta", 120, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("Hekim Adı", 120, HorizontalAlignment.Center);
            listview_hastakayit.Columns.Add("Cinsiyet", 72, HorizontalAlignment.Center);

            int say = listview_hastakayit.Items.Count;
            baglan.Open();

            OleDbCommand listele = new OleDbCommand("SELECT * FROM tbl_hasta ORDER BY TC_No asc", baglan);
            OleDbDataReader okuyucu = listele.ExecuteReader();

            ListViewItem nesne;
            int i = 1;

            while(okuyucu.Read())
            {
                nesne = new ListViewItem(i.ToString());
                nesne.SubItems.Add(okuyucu["TC_No"].ToString());
                nesne.SubItems.Add(okuyucu["Adi"].ToString());
                nesne.SubItems.Add(okuyucu["Soyadi"].ToString());
                nesne.SubItems.Add(okuyucu["Dogum_Tarihi"].ToString());
                nesne.SubItems.Add(okuyucu["Dogum_Yeri"].ToString());
                nesne.SubItems.Add(okuyucu["Anne_Adi"].ToString());
                nesne.SubItems.Add(okuyucu["Baba_Adi"].ToString());
                nesne.SubItems.Add(okuyucu["GSM_No"].ToString());
                nesne.SubItems.Add(okuyucu["eposta"].ToString());
                nesne.SubItems.Add(okuyucu["Hekim_Adi"].ToString());
                nesne.SubItems.Add(okuyucu["Cinsiyet"].ToString());

                listview_hastakayit.Items.Add(nesne);
                i++;
            }
            listele.Dispose();
            okuyucu.Close();
            baglan.Close();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void btn_hastakayit_Click(object sender, EventArgs e)
        {
            this.Close();
            yeni_hasta_girisi hasta_girisi_formu_ac = new yeni_hasta_girisi();
            hasta_girisi_formu_ac.Show();
        }
        private void btn_hastakayit_sil_Click(object sender, EventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçili olan kişiyi silmek istediğinize emin misiniz?", "SİLME RİSKİ!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                ListViewItem kisi_sec = listview_hastakayit.FocusedItem;
                long numara2 = Convert.ToInt64(kisi_sec.SubItems[1].Text);
                listview_hastakayit.Items.RemoveAt(listview_hastakayit.SelectedIndices[0]);
                baglan.Open();

                OleDbCommand kisi_sil = new OleDbCommand("DELETE FROM tbl_hasta where TC_No=@tc", baglan);
                kisi_sil.Parameters.AddWithValue("@tc", numara2);

                bool kontrol = kisi_sil.ExecuteNonQuery() > 0;
            }
            baglan.Close();
        }
        public static long numara;
        private void btn_hastakayit_guncelle_Click(object sender, EventArgs e)
        {
            ListViewItem secilen = listview_hastakayit.FocusedItem;
            numara = Convert.ToInt64(secilen.SubItems[1].Text);

            this.Close();
            hasta_guncelle hasta_guncelle_formu_ac = new hasta_guncelle();
            hasta_guncelle_formu_ac.Show();
        }

        private void btn_hastakayit_sorgula_Click(object sender, EventArgs e)
        {
            hasta_sorgula hasta_sorgula_formu_ac = new hasta_sorgula();
            hasta_sorgula_formu_ac.Show();
        }

        private void btn_hastakayit_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hastakayit_rapor_Click(object sender, EventArgs e)
        {
            rapor_hasta rapor_al = new rapor_hasta();
            rapor_al.Show();
        }
    }
}
