using System;

namespace DasPro
{
    class Program
    {
            //Deklarasi variabel
        static int kodeA,kodeB,kodeC,hasilTambah,hasilKurang,hasilKali,hasilBagi,jumlahKode;
        static int kesempatan = 3;
        static int level = 1;
        static String tebakanA,tebakanB,tebakanC;
        static bool bGameStart;

        //main method   
        static void Main(string[] args)
        {
            bGameStart = true;
            while (bGameStart)
            {
                if (kesempatan >= 1 && level <= 5)
                {
                    PlayGame();
                }
                else
                {
                    ShowEnd(true);
                } 
            }
            Console.Write("\n tekan enter untuk keluar..."); Console.ReadKey();
        }
        static void Init()
        {
            //inisialisasi variabel
            Random rnd = new Random();
            kodeA = rnd.Next(1,level + 1);
            kodeB = rnd.Next(1,level + 1);
            kodeC = rnd.Next(1,level + 1);
            
            jumlahKode = 3;
            //operasi aritmatika
            hasilTambah = kodeA + kodeB + kodeC;
            hasilKali = kodeA * kodeB * kodeC;
            hasilKurang = kodeA - kodeB - kodeC;
            hasilBagi = kodeA / kodeB / kodeC;
        }
        static void introductionplaygame()
        {
            Init();
            if (bGameStart && kesempatan == 3 && level == 1)
            {
                Console.WriteLine("selamat datang agent");
            }
        }
        static void intro()
        {
            Init();
            if (bGameStart && kesempatan !=3 )
            {
                TryAgain();
            }
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- Password terdiri dari 3 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + hasilTambah);
            Console.WriteLine("- Jika dikalikan hasilnya " + hasilKali);
            Console.WriteLine("- Jika dikurangkan hasilnya " + hasilKurang);
            Console.WriteLine("- Jika dibagikan hasilnya " + hasilBagi);
        }

        static void PlayGame()
        {
            introductionplaygame();
            Console.WriteLine("anda berada di level "+level);
        
            intro();
            Console.Write("\nmasukkan kode pertama : ");tebakanA = Console.ReadLine();
            Console.Write("masukkan kode kedua : ");tebakanB = Console.ReadLine();
            Console.Write("masukkan kode ketiga : ");tebakanC = Console.ReadLine();

            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
            {
                level++;
                LevelUp(true);
            }
            else
            {
                kesempatan--;
                Console.Clear();
                Console.WriteLine("Maaf,tebakan anda salah!");Console.ReadKey();
            }
        }
        static void LevelUp(bool b)
        {
            Console.Clear();
            if (b && kesempatan >= 1 && level <= 5 )
            {
                Console.WriteLine("LEVEL UP!!!");Console.ReadKey();
            }
            else if (b && kesempatan >= 1 && level > 5);
            {
                ShowEnd(true);
            }
        }
        static void ShowEnd(bool b)
        {
            Console.Clear();
            if (b && kesempatan == 0)
            {
                Console.WriteLine("kesempatan anda habis");
                bGameStart = false;
            }
            else if (b && kesempatan > 0 && level > 5)
            {
                Console.WriteLine("selamat anda telah menamatkan game ini!!!");
                bGameStart = false;
            }
        }
        static void TryAgain()
        {
            Console.WriteLine("kesempatan menjawab sisa " + kesempatan + "\n");
        }
    }    
}