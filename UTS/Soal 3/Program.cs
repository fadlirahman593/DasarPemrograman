using System;
using static System.Console;

namespace daspro
{
    class Program
    {
        static String NAMA;
        static int Tahun,UMUR;


        static void Main(string[] args)
        {
            Clear();
            input();
            output();
        }

        static void input()
        {
            WriteLine("Nama :");NAMA = ReadLine();
            WriteLine("Tahun Kelahiran :");Tahun = Convert.ToInt32(ReadLine());
            UMUR = 2022 - Tahun;
        }
        static void output()
        {
            WriteLine("|******************|");
            WriteLine($"|  -- Studio 1 --  |");
            WriteLine($"|Nama :       {NAMA}|");
            if (UMUR < 10 || UMUR >60)
            {
                WriteLine($"|Harga :  Rp 10.000|");   
            }
            else
            {
                WriteLine($"|Harga :  Rp 25.000|");
            }
            WriteLine("|------------------|");
        }
    }
}