using System;
using static System.Console;
namespace daspro
{
    class Program
    {
        static int jumlahsalah = 0; 
        static String jawaban = ""; 
        static bool salah = false, menang = false, kalah = false, benar = false;
        static void Main(string[] args)
        {
             
            Clear(); 
            string[] kata = new string[10];
            kata[0] = "informatika";
            kata[1] = "universitas";
            kata[2] = "riau";
            kata[3] = "teknik";
            kata[4] = "fakultas";
            kata[5] = "program";
            kata[6] = "studi";
            kata[7] = "jurusan";
            kata[8] = "sarjan";
            kata[9] = "diploma";
            Random rnd = new Random(); 
            var random = rnd.Next(0, 9); 
            string katamisteri = kata[random]; 
            char[] tebakan = new char[katamisteri.Length];
 
            for (int i = 0; i < katamisteri.Length; i++) 
            { 
                tebakan[i] = '_'; 
            }
 
            while (menang == false && kalah == false) 
            {
                Write("Huruf tebakan : ");
                char cektebakan = char.Parse(ReadLine()); 
                for (int j = 0; j < katamisteri.Length; j++) 
                {
                    if (cektebakan == katamisteri[j]) { 
                        benar = true; 
                        tebakan[j] = cektebakan; 
                    } else if (j == katamisteri.Length - 1 && benar == false){ 
                        salah = true; 
                    }
                }
                Clear();
                jawaban = new String(tebakan); 
                if (salah == true) { 
                    WriteLine("Tebakan anda salah!"); 
                    jumlahsalah++; 
                    salah = false;
                }
                benar = false; 
                WriteLine(tebakan); 
                WriteLine();
                switch (jumlahsalah) 
                {
                    case 1: 
                        WriteLine("_|__");
                        break;
                    case 2: 
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine("_|__");
                        break;
                    case 3: 
                        WriteLine(" |/");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine("_|__");
                        break;
                    case 4:
                        WriteLine("__________");
                        WriteLine(" |/");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine("_|__");
                        break;
                    case 5:
                        WriteLine("__________");
                        WriteLine(" |/      |");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine("_|__");
                        break;
                    case 6:
                        WriteLine("__________");
                        WriteLine(" |/      |");
                        WriteLine(" |      (_)");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine("_|__");
                        break;
                    case 7:
                        WriteLine("__________");
                        WriteLine(" |/      |");
                        WriteLine(" |      (_)");
                        WriteLine(" |      \\|/");
                        WriteLine(" |");
                        WriteLine(" |");
                        WriteLine("_|__");
                        break;
                    case 8:
                        WriteLine("__________");
                        WriteLine(" |/      |");
                        WriteLine(" |      (_)");
                        WriteLine(" |      \\|/");
                        WriteLine(" |       |");
                        WriteLine(" |");
                        WriteLine("_|__");
                        break;
                    case 9:
                        WriteLine("__________");
                        WriteLine(" |/      |");
                        WriteLine(" |      (_)");
                        WriteLine(" |      \\|/");
                        WriteLine(" |       |");
                        WriteLine(" |      / \\");
                        WriteLine("_|__");
                        break;
                    case 10:
                        WriteLine("__________");
                        WriteLine(" |/      |");
                        WriteLine(" |      (_)");
                        WriteLine(" |      \\|/");
                        WriteLine(" |       |");
                        WriteLine(" |      / \\");
                        WriteLine("_|__");
                        break;

                    default:
                        break;
                }

                if (jawaban == katamisteri) { 
                    WriteLine("Selamat, anda menang!"); 
                    menang = true; 
                } else if (jumlahsalah == 10 && jawaban != katamisteri) { 
                    WriteLine("Anda kurang beruntung!"); 
                    kalah = true; 
                }
            }
        }
    }
}