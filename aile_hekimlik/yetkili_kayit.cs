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
    public partial class yetkili_kayit : Form
    {
        public yetkili_kayit()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=ailehekimlik.accdb");
        private void yetkili_kayit_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            listview_yetkilikayit.View = View.Details;
            listview_yetkilikayit.Columns.Add("Sıra", 30, HorizontalAlignment.Center);
            listview_yetkilikayit.Columns.Add("T.C. No", 90, HorizontalAlignment.Center);
            listview_yetkilikayit.Columns.Add("Ad", 90, HorizontalAlignment.Center);
            listview_yetkilikayit.Columns.Add("Soyad", 90, HorizontalAlignment.Center);
            listview_yetkilikayit.Columns.Add("E Posta", 120, HorizontalAlignment.Center);
            listview_yetkilikayit.Columns.Add("Unvan", 90, HorizontalAlignment.Center);

            int say = listview_yetkilikayit.Items.Count;
            baglan.Open();

            OleDbCommand listele = new OleDbCommand("SELECT * FROM tbl_yetkili ORDER BY TC_No asc", baglan);
            OleDbDataReader okuyucu = listele.ExecuteReader();

            ListViewItem nesne;
            int i = 1;

            while (okuyucu.Read())
            {
                nesne = new ListViewItem(i.ToString());
                nesne.SubItems.Add(okuyucu["TC_No"].ToString());
                nesne.SubItems.Add(okuyucu["Adi"].ToString());
                nesne.SubItems.Add(okuyucu["Soyadi"].ToString());
                nesne.SubItems.Add(okuyucu["e_mail"].ToString());
                nesne.SubItems.Add(okuyucu["Unvan"].ToString());
                
                listview_yetkilikayit.Items.Add(nesne);
                i++;
            }
            listele.Dispose();
            okuyucu.Close();
            baglan.Close();
        }
        private void btn_yetkilikisi_kayit_Click(object sender, EventArgs e)
        {
            this.Close();
            yetkili_kisi yetkilikisi_formu_ac = new yetkili_kisi();
            yetkilikisi_formu_ac.Show();
        }

        private void btn_yetkilikisi_sil_Click(object sender, EventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçili olan kişiyi silmek istediğinize emin misiniz?", "SİLME RİSKİ!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                ListViewItem kisi_sec = listview_yetkilikayit.FocusedItem;
                listview_yetkilikayit.Items.RemoveAt(listview_yetkilikayit.SelectedIndices[0]);
                baglan.Open();

                OleDbCommand kisi_sil = new OleDbCommand("DELETE FROM tbl_yetkili WHERE TC_No=@tc", baglan);
                kisi_sil.Parameters.AddWithValue("@tc", kisi_sec.SubItems[1].Text);
                bool kontrol = kisi_sil.ExecuteNonQuery() > 0;
            }
            baglan.Close();
        }
        public static long numara;
        private void btn_yetkilikisi_guncelle_Click(object sender, EventArgs e)
        {
            ListViewItem secilen = listview_yetkilikayit.FocusedItem;
            numara = Convert.ToInt64(secilen.SubItems[1].Text);

            this.Close();
            yetkilikisi_guncelle yetkilikisi_guncelle_formu_ac = new yetkilikisi_guncelle();
            yetkilikisi_guncelle_formu_ac.Show();
        }

        private void btn_yetkilikisi_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_yetkilikayit_rapor_Click(object sender, EventArgs e)
        {
            rapor_yetkili rapor_al = new rapor_yetkili();
            rapor_al.Show();
        }
    }
}
