using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240032
{
    public abstract class Pesan
    {
        public string Isi { get; set; }
        public Pesan(string isi) { Isi = isi; }
        public abstract void Tampilkan();
    }
}