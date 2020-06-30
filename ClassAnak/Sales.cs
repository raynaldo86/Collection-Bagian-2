using CollectionBagian2.ClassInduk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBagian2.ClassAnak
{
    class Sales : Karyawan
    {
        public int JumlahPenjualan {get;set;}
        public int Komisi {get;set;}
        public override double Gaji()
        {
            return JumlahPenjualan*Komisi;
        }
    }
}
