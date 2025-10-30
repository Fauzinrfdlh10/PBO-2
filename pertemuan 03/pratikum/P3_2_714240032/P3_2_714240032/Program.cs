using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ulang = true;
            while (ulang)
            {
                Console.Clear();
                Console.WriteLine("MENU PERSEGI PANJANG");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.Write("Masukkan panjang: ");
                        int panjang = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        int lebar = Convert.ToInt32(Console.ReadLine());
                        int luas = panjang * lebar;
                        Console.WriteLine($"Luas Persegi Panjang: {luas}");
                        break;
                    case "2":
                        Console.Write("Masukkan panjang: ");
                        int p = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        int l = Convert.ToInt32(Console.ReadLine());
                        int keliling = 2 * (p + l);
                        Console.WriteLine($"Keliling Persegi Panjang: {keliling}");
                        break;
                    case "3":
                        Console.WriteLine("Program selesai. Terima kasih!");
                        ulang = false;
                        break;
                    default:
                        Console.WriteLine("Menu tidak tersedia. Silakan pilih menu yang valid.");
                        break;
                }

                if (ulang)
                {
                    Console.Write("Ingin mengulang kembali (Y/T)? ");
                    string lagi = Console.ReadLine();
                    if (lagi.ToUpper() == "T")
                    {
                        Console.WriteLine("Terima kasih!");
                        ulang = false;
                    }
                }
            }
        }
    }
}