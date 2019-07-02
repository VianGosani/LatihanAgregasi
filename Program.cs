using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAgregasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan();
            karyawan1.Nama = "Paijo";

            Karyawan karyawan2 = new Karyawan();
            karyawan2.Nama = "Jhono";

            Karyawan karyawan3 = new Karyawan();
            karyawan3.Nama = "Park";

            Perusahaan perusahaan = new Perusahaan();
            perusahaan.DaftarKaryawan.Add(karyawan1);
            perusahaan.DaftarKaryawan.Add(karyawan2);
            perusahaan.DaftarKaryawan.Add(karyawan3);

            int noUrut = 1;
            Console.WriteLine("Daftar Karyawan : ");
            foreach (Karyawan karyawan in perusahaan.DaftarKaryawan)
            {
                Console.WriteLine("{0}. {1}", noUrut, karyawan.Nama);
                noUrut++;
            }
            //Hapus
            Karyawan karyawanDeleted = perusahaan.DaftarKaryawan.SingleOrDefault(f => f.Nama == "Paijo");
            perusahaan.DaftarKaryawan.Remove(karyawanDeleted);
            perusahaan.DaftarKaryawan.Remove(karyawan3);
            noUrut = 1;
            Console.WriteLine();
            Console.WriteLine("Daftar Karyawan Setelah Remove: ");
            foreach (Karyawan karyawan in perusahaan.DaftarKaryawan)
            {
                Console.WriteLine("{0}. {1}", noUrut, karyawan.Nama);
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
