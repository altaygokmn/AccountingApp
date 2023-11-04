using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    public class ProductResults
    {
        public int Id { get; set; }
        public string Urun_Turu { get; set; }
        public int Alis_Fiyati_Toplam { get; set; }
        public int Satin_Alinan_Miktar_Toplam { get; set; }
        public int Satis_Fiyati_Toplam { get; set; }
        public int Satilan_Miktar_Toplam { get; set; }
        public int Satis_Nakliye_Maliyeti { get; set; }
        public int Satin_Alma_Nakliye_Maliyeti { get; set; }
        public int Nakliye_Maliyeti_Toplam { get; set; }
        public int Kar_veya_Zarar { get; set; }
    }
}
