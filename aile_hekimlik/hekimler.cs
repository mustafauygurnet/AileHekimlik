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
    public partial class hekimler : Form
    {
        public hekimler()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=ailehekimlik.accdb");
        private void hekimler_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            listview_hekimkayit.View = View.Details;
            listview_hekimkayit.Columns.Add("Sıra", 30, HorizontalAlignment.Center);
            listview_hekimkayit.Columns.Add("T.C. No", 90, HorizontalAlignment.Center);
            listview_hekimkayit.Columns.Add("Adı Soyadı", 120, HorizontalAlignment.Center);
            listview_hekimkayit.Columns.Add("Doğum Tarihi", 90, HorizontalAlignment.Center);
            listview_hekimkayit.Columns.Add("Doğum Yeri", 90, HorizontalAlignment.Center);
            listview_hekimkayit.Columns.Add("Sicil No", 60, HorizontalAlignment.Center);
            listview_hekimkayit.Columns.Add("Göreve Başlama Tarihi", 90, HorizontalAlignment.Center);
            listview_hekimkayit.Columns.Add("GSM No", 90, HorizontalAlignment.Center);
            listview_hekimkayit.Columns.Add("E Posta", 120, HorizontalAlignment.Center);
            listview_hekimkayit.Columns.Add("Cinsiyet", 80, HorizontalAlignment.Center);

            int say = listview_hekimkayit.Items.Count;
            baglan.Open();

            OleDbCommand listele = new OleDbCommand("SELECT * FROM tbl_hekim ORDER BY TC_No asc", baglan);
            OleDbDataReader okuyucu = listele.ExecuteReader();

            ListViewItem nesne;
            int i = 1;

            while (okuyucu.Read())
            {
                nesne = new ListViewItem(i.ToString());
                nesne.SubItems.Add(okuyucu["TC_No"].ToString());
                nesne.SubItems.Add(okuyucu["Adi"].ToString());
                nesne.SubItems.Add(okuyucu["Dogum_Tarihi"].ToString());
                nesne.SubItems.Add(okuyucu["Dogum_Yeri"].ToString());
                nesne.SubItems.Add(okuyucu["Sicil_No"].ToString());
                nesne.SubItems.Add(okuyucu["Goreve_Baslama"].ToString());
                nesne.SubItems.Add(okuyucu["GSM_No"].ToString());
                nesne.SubItems.Add(okuyucu["eposta"].ToString());
                nesne.SubItems.Add(okuyucu["Cinsiyet"].ToString());

                listview_hekimkayit.Items.Add(nesne);
                i++;
            }

            listele.Dispose();
            okuyucu.Close();
            baglan.Close();
        }
        private void btn_hekimkayit_Click(object sender, EventArgs e)
        {
            this.Close();
            yeni_hekim_girisi hekim_girisi_formu_ac = new yeni_hekim_girisi();
            hekim_girisi_formu_ac.Show();
        }
        private void btn_hekimkayit_sil_Click(object sender, EventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçili olan kişiyi silmek istediğinize emin misiniz?", "SİLME RİSKİ!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                ListViewItem kisi_sec = listview_hekimkayit.FocusedItem;
                listview_hekimkayit.Items.RemoveAt(listview_hekimkayit.SelectedIndices[0]);
                baglan.Open();

                OleDbCommand kisi_sil = new OleDbCommand("DELETE FROM tbl_hekim WHERE TC_No=@tc", baglan);
                kisi_sil.Parameters.AddWithValue("@tc", kisi_sec.SubItems[1].Text);
                bool kontrol = kisi_sil.ExecuteNonQuery() > 0;
            }
            baglan.Close();
        }
        public static long numara;
        private void btn_hekimkayit_güncelle_Click(object sender, EventArgs e)
        {
            ListViewItem secilen = listview_hekimkayit.FocusedItem;
            numara = Convert.ToInt64(secilen.SubItems[1].Text);


            this.Close();
            hekim_guncelle hekim_guncelle_formu_ac = new hekim_guncelle();
            hekim_guncelle_formu_ac.Show();
        }

        private void btn_hekimkayit_sorgula_Click(object sender, EventArgs e)
        {
            hekim_sorgula hekimsorgula_formu_ac = new hekim_sorgula();
            hekimsorgula_formu_ac.Show();
        }

        private void btn_hekimkayit_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hekimkayit_rapor_Click(object sender, EventArgs e)
        {
            rapor_hekim rapor_al = new rapor_hekim();
            rapor_al.Show();
        }
    }
}
