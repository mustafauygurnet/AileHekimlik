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
    public partial class guncelleme : Form
    {
        public guncelleme()
        {
            InitializeComponent();
        }
        private void guncelleme_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            sayac.Start();
        }
        private void sayac_Tick(object sender, EventArgs e)
        {
            kontrol.Increment(80);
            if (kontrol.Value == 100)
            {
                sayac.Stop();
                belge.Visible = false;
                mercek.Visible = false;
                smile.Visible = true;
                tebrikler.Visible = true;
                like.Visible = true;
            }
        }
    }
}
