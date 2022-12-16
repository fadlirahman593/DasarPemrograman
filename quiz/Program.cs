// fadli rahman NIM : 2207112587

using System;

namespace daspro
{
    class Program
    {
        // deklarasi
        static int ronde,nilaiuser,nilaicomp,skoruser,skorcomp,hasiluser,hasilcomp;
        static bool dadugame;

        static void Main(string[] args)
        {
            dadugame = true;
            while (dadugame)
            {
                ronde++;
                if (ronde <= 10)
                {
                    PlayGame();
                }
                else
                {
                    showhasil();
                    break;
                }
            }
            Console.WriteLine("\ntekan enter untuk keluar");
        }
        static void Init()
        {
            Console.Clear();
            Random rnd = new Random();
            nilaiuser = rnd.Next(1,7);
            nilaicomp = rnd.Next(1,7);
        }

        static void intro()
        {
            Console.WriteLine("pada game ini anda dan komputer akan bermain 10 ronde");
            Console.WriteLine("setiap putaran dadu dilempar akan menghasilkan nilai tertentu");
            Console.WriteLine("nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("siapa yang akan menang?semoga beruntung");
            Console.WriteLine("\nmulai main...\n");Console.ReadKey();
        }
        static void PlayGame()
        {
            Init();
            intro();
            Console.WriteLine("ronde "+ronde);
            Console.WriteLine("nilai komputer : "+nilaicomp);Console.ReadKey();
            Console.WriteLine("lempar dadu anda");Console.ReadKey();
            Console.WriteLine("nilai Anda : "+nilaiuser);

            if (nilaicomp > nilaiuser )
            {
                hasilcomp++;
                Console.WriteLine("anda kurang beruntung");Console.ReadKey();
            }
            else if (nilaicomp < nilaiuser)
            {
                hasiluser++;
                Console.WriteLine("selamat nilai anda lebih tinggi !");Console.ReadKey();
            }
            else if (nilaicomp == nilaiuser)
            {
                Console.WriteLine("ronde ini seri!");Console.ReadKey();
            }
        Console.WriteLine("Skor - Anda : "+hasiluser+" komputer : "+hasilcomp+"\nlanjutkan ke ronde selanjutnya...");Console.ReadKey();
        }
        static void showhasil()
        {
            if (hasiluser > hasilcomp)
            {
                Console.WriteLine("selamat anda menang!!!");
            }
            else if (hasiluser < hasilcomp)
            {
                Console.WriteLine("anda kalah");
            }
            else if (hasiluser == hasilcomp)
            {
                Console.WriteLine("game berakhir seri");
            }
        }
    }
    
}