using CollectionBagian2.ClassAnak;
using CollectionBagian2.ClassInduk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBagian2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan;
            List<Karyawan> listKaryawan = new List<Karyawan>();

            do
            {
                Console.WriteLine(" Pilih Menu Aplikasi :");
                Console.WriteLine();
                Console.WriteLine(" 1. Tambah Data Karyawan");
                Console.WriteLine(" 2. Hapus Data Karyawan");
                Console.WriteLine(" 3. Tampilkan Data Karyawan");
                Console.WriteLine(" 4. Keluar");
                Console.WriteLine();
                Console.Write(" Pilih Menu : ");
                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                switch (pilihan)
                {
                    // Menambahkan Data Karyawan
                    case 1:
                        Console.WriteLine(" Tambah Data Karyawan");
                        Console.WriteLine();
                        Console.WriteLine(" 1. Karyawan Tetap");
                        Console.WriteLine(" 2. Karyawan Harian");
                        Console.WriteLine(" 3. Sales");
                        Console.WriteLine();
                        Console.Write(" Pilih Karyawan : ");
                        int menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (menu)
                        {
                            case 1:
                                KaryawanTetap karyawanTetap = new KaryawanTetap();
                                Console.Write(" NIK          : ");
                                karyawanTetap.Nik = Console.ReadLine();
                                Console.Write(" NAMA         : ");
                                karyawanTetap.Nama = Console.ReadLine();
                                Console.Write(" GAJI BULANAN : ");
                                karyawanTetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(karyawanTetap);
                                break;

                            case 2:
                                KaryawanHarian karyawanHarian = new KaryawanHarian();
                                Console.Write(" NIK              : ");
                                karyawanHarian.Nik = Console.ReadLine();
                                Console.Write(" NAMA             : ");
                                karyawanHarian.Nama = Console.ReadLine();
                                Console.Write(" JUMLAH JAM KERJA : ");
                                karyawanHarian.JumlahJamKerja = int.Parse(Console.ReadLine());
                                Console.Write(" UPAH PER JAM     : ");
                                karyawanHarian.UpahPerJam = int.Parse(Console.ReadLine());
                                listKaryawan.Add(karyawanHarian);
                                break;

                            case 3:
                                Sales sales = new Sales();
                                Console.Write(" NIK              : ");
                                sales.Nik = Console.ReadLine();
                                Console.Write(" NAMA             : ");
                                sales.Nama = Console.ReadLine();
                                Console.Write(" JUMLAH PENJUALAN : ");
                                sales.JumlahPenjualan = int.Parse(Console.ReadLine());
                                Console.Write(" KOMISI           : ");
                                sales.Komisi = int.Parse(Console.ReadLine());
                                listKaryawan.Add(sales);
                                break;

                            default:
                                Console.WriteLine(" Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                                break;
                        }
                        Console.WriteLine();                        
                        Console.WriteLine(" Tekan Enter Untuk Kembali ke Menu");
                        break;

                    // Menghapus Data Karyawan
                    case 2:
                        int urutan = 1, hapus = -1;
                        
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            Console.WriteLine(" {0}. NIK: {1}", urutan, karyawan.Nik);
                            urutan++;
                            hapus += 1;
                        }

                        Console.WriteLine();
                        Console.Write(" Pilih NIK Yang Ingin Dihapus : ");
                        int urutanNIK = int.Parse(Console.ReadLine());
                        urutanNIK = urutanNIK - 1;

                        listKaryawan.RemoveAt(hapus);
                        Console.WriteLine();
                        Console.WriteLine(" Data Karyawan Berhasil Dihapus");
                        Console.WriteLine();
                        Console.WriteLine(" Tekan Enter Untuk Kembali ke Menu");
                        break;

                    // Menampilkan Data Karyawan
                    case 3:
                        int nomor = 0;
                        string Golongan = " ";
                        Console.WriteLine(" Data Karyawan\n");
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            if (karyawan is KaryawanTetap)
                            {
                                Golongan = "Karyawan Tetap";
                            }

                            else if (karyawan is KaryawanHarian)
                            {
                                Golongan = "Karyawan Harian";
                            }

                            else
                            {
                                Golongan = "Sales";
                            }

                            nomor++;
                            Console.WriteLine(" {0}. NIK: {1}, NAMA: {2}, GAJI: {3}, {4}", nomor, karyawan.Nik, karyawan.Nama, karyawan.Gaji(), Golongan);
                        }

                        if (nomor < 1)
                        {
                            Console.WriteLine(" Maaf, Data Karyawan Kosong");
                        }

                        else if (nomor > 4)
                        {
                            Console.WriteLine(" Maaf, Data Karyawan Kosong");
                        }
                        Console.WriteLine();
                        Console.WriteLine(" Tekan Enter Untuk Kembali ke Menu");
                        break;

                    // Keluar Dari Menu
                    case 4:
                        break;

                    default:
                        Console.WriteLine(" Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                        Console.WriteLine();
                        Console.WriteLine(" Tekan Enter Untuk Kembali ke Menu");
                        break;
                }
                Console.ReadKey();
            }
            while (pilihan != 4);
        }
    }
}
