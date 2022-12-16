using System;
using static System.Console;

namespace daspro
{
    class Program
    {
        static String NAMA,NIM,KONSEN;


        static void Main(string[] args)
        {
            Clear();
            input();
            output();
        }

        static void input()
        {
            WriteLine("Nama :");NAMA = ReadLine();
            WriteLine("Nim :");NIM = ReadLine();
            WriteLine("Konsentrasi :");KONSEN = ReadLine();
        }
        static void output()
        {
            WriteLine("|**********************|");
            WriteLine($"|Nama :           {NAMA}|");
            WriteLine($"|                {NIM}|");
            WriteLine("|----------------------|");
            WriteLine($"|                   {KONSEN}|");
            WriteLine("|**********************|");
        }
    }
}