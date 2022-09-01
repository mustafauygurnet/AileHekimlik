using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aile_hekimlik
{
    class form_gecisleri
    {
        public static void hasta_gecis()
        {
            hastalar hasta_formu_ac = new hastalar();
            hasta_formu_ac.Show();
        }

        public static void hekim_gecis()
        {
            hekimler hekim_formu_ac = new hekimler();
            hekim_formu_ac.Show();
        }

        public static void randevu_gecis()
        {
            randevular randevu_formu_ac = new randevular();
            randevu_formu_ac.Show();
        }

       
        
        public static void yetkiliekle_gecis()
        {
            yetkili_kayit yetkili_kayit_formu_ac = new yetkili_kayit();
            yetkili_kayit_formu_ac.Show();
        }

    }
}
