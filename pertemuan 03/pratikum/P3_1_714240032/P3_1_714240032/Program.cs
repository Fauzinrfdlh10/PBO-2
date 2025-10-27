using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_714240032
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("MENENTUKAN INDEKS PRESTASI MAHASISWA");
                Console.WriteLine("\nMasukan Nama Mahasiswa: ");

                string nama = Console.ReadLine();

                Console.WriteLine("Masukan Nilai: ");

                int nilai = Convert.ToInt16(Console.ReadLine());

                String[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("Indeks Nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 75)
                {
                    Console.WriteLine("Indeks Nilai {0} adalah {1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("Indeks Nilai {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("Indeks Nilai {0} adalah {1}", nama, grade[3]);
                }

                Console.WriteLine("Masukan Indeks Yang ditampilkan:");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Indeks prestasi {0} adalah:", nama);

                prestasi(indeks);

                Console.WriteLine("ingin mengulang kembali tekan (Y/T)?");
            }
            while (Console.ReadLine() == "Y");
        }

            
                private static void prestasi(char indeks)
                {
                    switch (indeks)
                    {
                        case 'A':
                            Console.WriteLine("Sangat Baik");
                            break;
                        case 'B':
                            Console.WriteLine("baik");
                            break;
                        case 'C':
                            Console.WriteLine("Cukup");
                            break;
                        case 'D':
                            Console.WriteLine("Buruk");
                            break;
                        default:
                            Console.WriteLine("invalid indeks prestasi");
                            break;
                    }
            }
        }
    }



        
