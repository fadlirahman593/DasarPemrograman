using System;
using static System.Console;
namespace Enkripsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            play();
        }   
        static int invalid;
        static void play()
        {
            Write("Teks : ");
            string Teks = ReadLine();
            string Hasil = Enkripsi(Teks);
            if(string.IsNullOrEmpty(Teks) || string.IsNullOrWhiteSpace(Teks))
            {
                invalid=1;
                WriteLine("  Mohon Maaf Teks Tidak Boleh Kosong ");
                ReadKey();
                invalid=2;
            }
            if (invalid==1)
            {
                WriteLine(" Mohon Maaf Teks Harus Berisi Alfabet ");    
            }
            else if (invalid==0)
            {
                WriteLine("Hasil Enkripsi : "+Hasil);
            }
        }

        private static string Enkripsi(string Huruf)
        {
            char PecahKata;
            string Hasil = null;
            for (int i = 0; i < Huruf.Length; i++)
            {
                PecahKata = Huruf[i];
                switch(PecahKata)
                {
                    case 'a' :
                    PecahKata = 'd';
                    break;

                    case 'b' :
                    PecahKata = 'e';
                    break;

                    case 'c' :
                    PecahKata = 'f';
                    break;

                    case 'd' :
                    PecahKata = 'g';
                    break;

                    case 'e' :
                    PecahKata = 'h';
                    break;

                    case 'f' :
                    PecahKata = 'i';
                    break;

                    case 'g' :
                    PecahKata = 'j';
                    break;

                    case 'h' :
                    PecahKata = 'k';
                    break;

                    case 'i' :
                    PecahKata = 'l';
                    break;

                    case 'j' :
                    PecahKata = 'm';
                    break;

                    case 'k' :
                    PecahKata = 'n';
                    break;

                    case 'l' :
                    PecahKata = 'o';
                    break;

                    case 'm' :
                    PecahKata = 'p';
                    break;

                    case 'n' :
                    PecahKata = 'q';
                    break;

                    case 'o' :
                    PecahKata = 'r';
                    break;

                    case 'p' :
                    PecahKata = 's';
                    break;

                    case 'q' :
                    PecahKata = 't';
                    break;

                    case 'r' :
                    PecahKata = 'u';
                    break;

                    case 's' :
                    PecahKata = 'v';
                    break;

                    case 't' :
                    PecahKata = 'w';
                    break;

                    case 'u' :
                    PecahKata = 'x';
                    break;

                    case 'v' :
                    PecahKata = 'y';
                    break;

                    case 'w' :
                    PecahKata = 'z';
                    break;

                    case 'x' :
                    PecahKata = 'a';
                    break;

                    case 'y' :
                    PecahKata = 'b';
                    break;

                    case 'z' :
                    PecahKata = 'c';
                    break;

                    case 'A' :
                    PecahKata = 'D';
                    break;

                    case 'B' :
                    PecahKata = 'E';
                    break;

                    case 'C' :
                    PecahKata = 'F';
                    break;

                    case 'D' :
                    PecahKata = 'G';
                    break;

                    case 'E' :
                    PecahKata = 'H';
                    break;

                    case 'F' :
                    PecahKata = 'I';
                    break;

                    case 'G' :
                    PecahKata = 'J';
                    break;

                    case 'H' :
                    PecahKata = 'K';
                    break;

                    case 'I' :
                    PecahKata = 'L';
                    break;

                    case 'J' :
                    PecahKata = 'M';
                    break;

                    case 'K' :
                    PecahKata = 'N';
                    break;

                    case 'L' :
                    PecahKata = 'O';
                    break;

                    case 'M' :
                    PecahKata = 'P';
                    break;

                    case 'N' :
                    PecahKata = 'Q';
                    break;

                    case 'O' :
                    PecahKata = 'R';
                    break;

                    case 'P' :
                    PecahKata = 'S';
                    break;

                    case 'Q' :
                    PecahKata = 'T';
                    break;

                    case 'R' :
                    PecahKata = 'U';
                    break;

                    case 'S' :
                    PecahKata = 'V';
                    break;

                    case 'T' :
                    PecahKata = 'W';
                    break;

                    case 'U' :
                    PecahKata = 'X';
                    break;

                    case 'V' :
                    PecahKata = 'Y';
                    break;

                    case 'W' :
                    PecahKata = 'Z';
                    break;

                    case 'X' :
                    PecahKata = 'A';
                    break;

                    case 'Y' :
                    PecahKata = 'B';
                    break;

                    case 'Z' :
                    PecahKata = 'C';
                    break;

                    default:
                    invalid=1;
                    break;
                }
                if (invalid==1)
                {
                    Hasil = "input tidak valid,mohon input alfabet";
                }
                else
                {
                    Hasil = Hasil + PecahKata;   
                }
            }
            return Hasil;
        }
    } 
}