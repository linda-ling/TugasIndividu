using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramBioskop
{
    class Film
    {
        public int Kode { get; set; }
        public string JudulFilm { get; set; }
        public int Harga { get; set; }
        public void Intro()
        {
            Console.WriteLine("BERHASIL!");

        }
    }
}
