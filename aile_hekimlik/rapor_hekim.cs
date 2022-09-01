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
    public partial class rapor_hekim : Form
    {
        public rapor_hekim()
        {
            InitializeComponent();
        }

        private void rapor_hekim_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.tbl_hekimTableAdapter.Fill(this.ailehekimlikDataSet.tbl_hekim);

            this.rapor_hekimkayit.RefreshReport();
        }
    }
}
