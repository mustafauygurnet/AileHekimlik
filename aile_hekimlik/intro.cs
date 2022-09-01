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
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void timer_yukleniyor_Tick(object sender, EventArgs e)
        {
            yukleniyor.Increment(8);
            if(yukleniyor.Value == 100)
            {
                timer_yukleniyor.Stop();
                this.Close();
                anasayfa_giris gir = new anasayfa_giris();
                gir.Show();

            }
        }
    }
}
