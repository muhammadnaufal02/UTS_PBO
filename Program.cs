// Muhammad Naufal Fadhlurrahman Suriadireja
// 20/456847/TK/50671

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gajikaryawan
{
    class Peogram
    {
        static void Main(string[] args)
        {
            string nama, nip, ststus;
            int masa, tunjangannikah = 0, gaji, tunjanganmasa = 0, gajiakhir;
            Console.WriteLine("\t\t\tMENGHITUNG GAJI KARYAWAN\t\t\t");
            Console.WriteLine("")
            Console.Write("Masukan Nama                          :");
            nama = Console.ReadLine();
            Console.Write("Masukan Nip                           :");
            nip = Console.ReadLine();
            Console.Write("Masukan Gaji Pokok                    :");
            gaji = int.Parse(Console.ReadLine());
            Console.Write("Masukan Lama Masa Kerja               :");
            masa = int.Parse(Console.ReadLine());
            if (masa >= 5)
            {
                tunjanganmasa = 20 * gaji / 100;
            }
            Console.Write("Apakah Anda Sudah Menikah (iya/tidak) :");
            status =Console.ReadLine();
            status.ToLower();

            if (TaskStatus == "iya")
            {
                tunjangannikah = 10 * gaji / 100;
            }

            gajiakhir = gaji + tunjanganmasa + tunjangannikah;

            Console.WriteLine("--------------");
            Console.WriteLine("Nama                 : "+nama);
            Console.WriteLine("Gaji Pokok           : " + gaji);
            Console.WriteLine("Tunjangan Nikah      : " + tunjangannikah);
            Console.WriteLine("Tunjangan Masa Kerja : " + tunjanganmasa);
            Console.WriteLine("Gaji Bersih          : " + gajiakhir);
            Console.Read();
         }
    }
}