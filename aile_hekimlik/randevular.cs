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
    public partial class randevular : Form
    {
        public randevular()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=ailehekimlik.accdb");
        private void randevular_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            listview_randevukayit.View = View.Details;
            listview_randevukayit.Columns.Add("Sıra", 30, HorizontalAlignment.Center);
            listview_randevukayit.Columns.Add("T.C. No", 110, HorizontalAlignment.Center);
            listview_randevukayit.Columns.Add("Doktor Adı", 160, HorizontalAlignment.Center);
            listview_randevukayit.Columns.Add("Randevu Tarihi", 160, HorizontalAlignment.Center);
            listview_randevukayit.Columns.Add("Randevu Saati", 160, HorizontalAlignment.Center);

            int say = listview_randevukayit.Items.Count;
            baglan.Open();

            OleDbCommand listele = new OleDbCommand("SELECT * FROM tbl_randevu ORDER BY TC_No asc", baglan);
            OleDbDataReader okuyucu = listele.ExecuteReader();
            ListViewItem nesne;
            int i = 1;

            while (okuyucu.Read())
            {
                nesne = new ListViewItem(i.ToString());
                nesne.SubItems.Add(okuyucu["TC_No"].ToString());
                nesne.SubItems.Add(okuyucu["Doktor_Adi"].ToString());
                nesne.SubItems.Add(okuyucu["Randevu_Tarihi"].ToString());
                nesne.SubItems.Add(okuyucu["Randevu_Saati"].ToString());

                listview_randevukayit.Items.Add(nesne);
                i++;
            }
            listele.Dispose();
            okuyucu.Close();
            baglan.Close();

        }
        private void btn_randevukayit_Click(object sender, EventArgs e)
        {
            this.Close();
            yeni_randevu_girisi randevu_girisi_formu_ac = new yeni_randevu_girisi();
            randevu_girisi_formu_ac.Show();
        }
        private void btn_randevukayit_sil_Click(object sender, EventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçili olan randevuyu silmek istediğinize emin misiniz?", "SİLME RİSKİ!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                ListViewItem kisi_sec = listview_randevukayit.FocusedItem;
                listview_randevukayit.Items.RemoveAt(listview_randevukayit.SelectedIndices[0]);
                baglan.Open();

                OleDbCommand kisi_sil = new OleDbCommand("DELETE FROM tbl_randevu WHERE TC_No=@tc", baglan);
                kisi_sil.Parameters.AddWithValue("@tc", kisi_sec.SubItems[1].Text);
                bool kontrol = kisi_sil.ExecuteNonQuery() > 0;
            }
            baglan.Close();
        }
        
        private void btn_randevukayit_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_randevukayit_rapor_Click(object sender, EventArgs e)
        {
            rapor_randevu rapor_al = new rapor_randevu();
            rapor_al.Show();
        }
    }
}
