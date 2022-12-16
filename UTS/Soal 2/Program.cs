using System;
using static System.Console;

namespace daspro
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            double Rate = 15.36;
            WriteLine("Rate USD ke RP:"+Rate);
            WriteLine("Jumlah USD :");double USD = Convert.ToDouble(ReadLine());
            double hasil = Rate * USD;
            WriteLine("Hasil Konversi: "+hasil);
        }
    }
}