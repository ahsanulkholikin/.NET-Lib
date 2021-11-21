using System;
using System.Collections.Generic;
using System.Text;

namespace Lat4_3
{
    class Barang
    {
        public double sum;

        public string Hitung(int buku, int pensil, int pulpen)
        {
            sum = buku + pensil + pulpen;
            return "Anda membeli total " + sum + " Barang.";
        }

        public string Hitung(string buku, string pensil, string pulpen)
        {
            string a = buku == "y" ? "Anda membeli buku." : "Anda tidak membeli buku.";
            string b = pensil == "y" ? "\nAnda membeli pensil." : "\nAnda tidak membeli pensil.";
            string c = pulpen == "y" ? "\nAnda membeli pulpen." : "\nAnda tidak membeli pulpen.";
            return a + b + c;
        }
    }
}
