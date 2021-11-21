using System;
using System.Collections.Generic;
using System.Text;

namespace Lat4_2
{
    class Mahasiswa
    {
        public string nama, nim;
        public int nilaiInggris, nilaiManajemen, nilaiBahasa, totalNilai;
        public double rataRata;

        public void hitungTotalNilai()
        {
            totalNilai = nilaiInggris + nilaiManajemen + nilaiBahasa;
        }

        public void hitungRatarata()
        {
            rataRata = (double)totalNilai / 3;
        }
    }
}
