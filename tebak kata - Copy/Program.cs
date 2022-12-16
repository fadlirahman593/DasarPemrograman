// fadli rahman

using System;
using System.Collections.Generic;
using static System.Console;

namespace tebakkata
{
    class Program
    {
        static int kesempatan=5,jumlahtebak;
        static String katamisteri = "beruang";
        static List<string> listtebakan = new List<string>{};
        static void Main(string[] args)
        {
            Clear();
            intro();
            playgame();
        }
        static void jumlahnebak()
        {
            if (jumlahtebak == 0)
            {
                Write("apa huruf tebakanmu?(pilih a - z) :");
                jumlahtebak++;
            }
            else
            {
                Write("apa huruf tebakanmu selanjutnya?(pilih a - z) :");
            }
        }
        static void intro()
        {
            WriteLine("selamat datang,hari ini kita akan bermain tebak kata");
            WriteLine($"kamu punya {kesempatan} kesempatan untuk menebak kata misteri hari ini");
            WriteLine("petunjuknya adalah kata ini merupakan hewan");
            WriteLine($"kata tersebut terdiri dari {katamisteri.Length} huruf");
            WriteLine("apakah yang dimaksud?");
            Thread.Sleep(2000);
            WriteLine();
        }
        static void playgame()
        {
            while (kesempatan>0)
            {
                Thread.Sleep(1000);
                jumlahnebak();string input = ReadLine();
                Thread.Sleep(1000);
                listtebakan.Add(input);
                if (cekjawaban(katamisteri, listtebakan))
                {
                    WriteLine("selamat anda berhasil");
                    WriteLine($"kata misteri hari ini adalah {katamisteri}");
                    break;
                }
                else if (katamisteri.Contains(input))
                {
                    WriteLine("huruf itu ada didalam kata ini");
                    WriteLine("silahkan tebak huruf lainnya...");
                    WriteLine(cekhuruf(katamisteri, listtebakan));
                }
                else
                {
                    WriteLine("huruf itu tidak ada dalam kata ini");
                    kesempatan--;
                    WriteLine($"kesempatan anda tinggal {kesempatan}");
                }

                if (kesempatan==0)
                {
                    showend();
                    break;
                }
            }
        }
        static bool cekjawaban(string katarahasia, List<string> list)
    {bool status = false;
        for (int i = 0; i < katarahasia.Length; i++)
        {
            string c = Convert.ToString(katarahasia[i]);
            if (list.Contains(c))
            {
                status = true;
            }
            else
            {
                return status = false;
            }
        }
        return status;
    }
        static string cekhuruf(string katarahasia, List<string> list)
        {string x = "";

        for (int i = 0; i < katarahasia.Length; i++)
        {
            string c = Convert.ToString(katarahasia[i]);
            if (list.Contains(c))
            {
                x = x + c;
            }
            else
            {
                x =  x + "_";
            }
        }
            return x;
        }
        static void showend()
        {
            if (kesempatan == 0)
            {
            WriteLine("Permainan berakhir");
            WriteLine($"kata misteri sebenarnya adalah {katamisteri}");
            }
        }
    }

}