using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp
{
    public class Product2
    {
        public int Id { get; set; }

        public string? Urun_Turu { get; set; }
        public int Satis_Fiyati { get; set; }
        public string Urunun_Satildigi_Bolge { get; set; }
        public int Satilan_Miktar { get; set; }

        public DateTime Satis_Tarihi { get; set; }


    }
}

