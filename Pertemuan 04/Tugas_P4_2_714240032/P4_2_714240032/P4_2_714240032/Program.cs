using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pesan motivasi = new PesanMotivasi("Jangan mudah menyerah walau susah");
            Pesan curhat = new PesanCurhat("Sudah berusaha, kadang hasil tidak sesuai");
            Console.WriteLine("Dari class PesanMotivasi");
            motivasi.Tampilkan();
            Console.WriteLine("Dari class PesanCurhat");
            curhat.Tampilkan();
            Console.WriteLine("\nPress any key to close this window . . .");
            Console.ReadKey();
        }
    }
}
