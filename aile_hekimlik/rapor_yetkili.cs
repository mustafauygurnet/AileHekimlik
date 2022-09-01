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
    public partial class rapor_yetkili : Form
    {
        public rapor_yetkili()
        {
            InitializeComponent();
        }

        private void rapor_yetkili_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.tbl_yetkiliTableAdapter.Fill(this.ailehekimlikDataSet.tbl_yetkili);

            this.rapor_yetkilikayit.RefreshReport();
        }
    }
}
