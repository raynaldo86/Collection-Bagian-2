using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBagian2.ClassInduk
{
    abstract class Karyawan
    {
        public string Nik {get;set;}
        public string Nama {get;set;}
        public string Golongan {get;set;}
        public abstract double Gaji();
    }
}
