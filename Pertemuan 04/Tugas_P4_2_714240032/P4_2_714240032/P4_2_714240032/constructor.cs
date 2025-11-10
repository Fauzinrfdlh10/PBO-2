using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240032
{
    public class PesanMotivasi : Pesan
    {
        public PesanMotivasi(string isi) : base(isi) { }
        public override void Tampilkan()
        {
            Console.WriteLine("Pesan Motivasi: \"" + Isi + "\" Tetap semangat!");
        }
    }
    public class PesanCurhat : Pesan
    {
        public PesanCurhat(string isi) : base(isi) { }
        public override void Tampilkan()
        {
            Console.WriteLine("Pesan Curhat: \"" + Isi + "\" Duh, hidup memang berat.");
        }
    }
}

