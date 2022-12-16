using System;
using static System.Console;

namespace daspro
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            WriteLine("== SELAMAT DATANG DI ADVENTURE GAME UNRI ==");
            WriteLine("Siapa Nama Anda Wahai Pahlawan?");
            Novice Pemain = new Novice();Pemain.Name = ReadLine();
            WriteLine($"Hi {Pemain.Name}, Siap Untuk memulai Petualangan?[y/n]");string GameReady = ReadLine();
            if(GameReady == "y" || GameReady == "Y")
            {
                WriteLine($"{Pemain.Name} Memasuki Game...");Enemy Musuh1 = new Enemy("ButterFly");
                WriteLine($"{Pemain.Name} Menghadang {Musuh1.Name}");
                WriteLine($"{Musuh1.Name} Menyerangmu...");
                WriteLine("Pilih Aksi...");
                WriteLine("1. Basic Attack");
                WriteLine("2. Special Attack");
                WriteLine("3. Defend");
                WriteLine("4. Lari");
                WriteLine("Pilih Serangan :");

                while (!Pemain.IsDead && !Musuh1.IsDead) 
                {
                    string PemainAction = ReadLine();
                    switch(PemainAction){
                        case "1" :
                        WriteLine($"{Pemain.Name} Melakukan Basic Attack");
                        Musuh1.GetHit(Pemain.KekuatanSerangan);
                        Pemain.keahlian += 0.3f;
                        Musuh1.Attack(Musuh1.KekuatanSerangan);
                        Pemain.GetHit(Musuh1.KekuatanSerangan);
                        Write($"Darah Pemain : {Pemain.nyawa} | Darah {Musuh1.Name} : {Musuh1.nyawa}\n");
                        break;
                        case "2" :
                        Pemain.Swing();
                        Pemain.keahlian += 0.3f;
                        Musuh1.GetHit(Pemain.KekuatanSerangan);
                        Write($"Darah Pemain : {Pemain.nyawa} | Darah {Musuh1.Name} : {Musuh1.nyawa}\n");
                        break; 
                        case "3" :
                        Pemain.Rest();
                        WriteLine("Energi Diisi... ");
                        Musuh1.Attack(Musuh1.KekuatanSerangan);
                        Pemain.GetHit(Musuh1.KekuatanSerangan);
                        break;
                        case "4" :
                        WriteLine($"{Pemain.Name} is running away...");
                        break;
                    }
                    continue;
                }
                
                WriteLine($"{Pemain.Name} mendapat {Pemain.keahlian} Poin keahlian.");
            }
            else if(GameReady == "n" || GameReady == "N")
            {
                WriteLine("Sampai Jumpa di Petualngan Berikutnya..."); 
                Read();
            }
        }
    }

    class Novice
    {
        public int nyawa { get; set; }
        public string Name { get; set; }
        public int KekuatanSerangan { get; set; }
        public int Energi { get; set; }
        public bool IsDead { get; set; }
        public float keahlian { get; set; }
        Random rnd = new Random();

        public Novice(){
            nyawa = 100;
            Energi = 0;
            KekuatanSerangan = 1;
            IsDead = false;
            keahlian = 0f;
            Name = "Newbie";
        }

        public void Swing()
        {
            if(Energi > 0){
                WriteLine("SWINGG!!!");
                KekuatanSerangan = KekuatanSerangan + rnd.Next(3,11);
                Energi--;
            }else{
                WriteLine("Kamu Tidak memiliki cukup energi,gunakan skill lain untuk mengisi energi");
                
            }
        }

        public void GetHit(int PointSerangan)
        {
            WriteLine($"{Name} terkena serangan sebanyak {PointSerangan}");
            nyawa = nyawa - PointSerangan;

            if(nyawa <= 0){
                nyawa = 0;
                dead();
            }
        }

        public void Rest()
        {
            Energi = 3;
            KekuatanSerangan = 1;
        }

        public void dead()
        {
            WriteLine("Kamu Meninggal. Game Over!");
            IsDead = true;
        }      
    }

    class Enemy
    {
        public string Name { get; set; }
        public int nyawa { get; set; }
        public int KekuatanSerangan { get; set; }
        public int Energi { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            nyawa = 50;
            Name = name;
        }

        public void Attack(int damage)
        {
            KekuatanSerangan = rnd.Next(1,10);
        }
        
        public void GetHit(int PointSerangan)
        {
            WriteLine($"{Name} Terkena Serangan Sebanyak {PointSerangan}");
            nyawa = nyawa - PointSerangan;

            if(nyawa <= 0)
            {
                nyawa = 0;
                dead();
            }
        }

        public void dead()
        {
            WriteLine($"{Name} is mati");
            IsDead = true;
        }
    }
}