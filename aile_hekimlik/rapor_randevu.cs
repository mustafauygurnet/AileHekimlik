using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aile_hekimlik
{
    public partial class rapor_randevu : Form
    {
        public rapor_randevu()
        {
            InitializeComponent();
        }

        private void rapor_randevu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.tbl_randevuTableAdapter.Fill(this.ailehekimlikDataSet.tbl_randevu);

            this.rapor_randevukayit.RefreshReport();
        }
    }
}
