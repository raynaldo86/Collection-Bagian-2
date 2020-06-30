using CollectionBagian2.ClassInduk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBagian2.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan {get;set;}
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
