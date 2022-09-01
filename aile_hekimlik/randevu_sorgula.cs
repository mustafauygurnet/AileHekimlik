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
    public partial class randevu_sorgula : Form
    {
        public randevu_sorgula()
        {
            InitializeComponent();
        }

        private void btn_randevusorgula_temizle_Click(object sender, EventArgs e)
        {
            tb_randevusorgula_tc.Clear();
        }

        private void btn_randevusorgula_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
