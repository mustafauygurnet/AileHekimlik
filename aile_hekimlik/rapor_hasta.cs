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
    public partial class rapor_hasta : Form
    {
        public rapor_hasta()
        {
            InitializeComponent();
        }

        private void rapor_hasta_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.tbl_hastaTableAdapter.Fill(this.ailehekimlikDataSet.tbl_hasta);

            this.rapor_hastakayit.RefreshReport();
        }
    }
}
