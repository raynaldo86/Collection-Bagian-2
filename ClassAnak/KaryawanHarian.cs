using CollectionBagian2.ClassInduk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBagian2.ClassAnak
{
    class KaryawanHarian : Karyawan
    {
        public int UpahPerJam {get;set;}
        public int JumlahJamKerja {get;set;}
        public override double Gaji()
        {
            return UpahPerJam*JumlahJamKerja;
        }
    }
}
