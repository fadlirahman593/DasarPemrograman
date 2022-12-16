//Fadli Rahman
//NIM 2207112587
using System;

namespace Array2D
{
    class Program
    {
        static int[] tebakan = {0,0};
        static int tankhancur = 0;
        static bool battletank = true;
        static int truth = 0;
        static char[,] tank = {
            {' ','1','2','3','4','5'},
            {'1','~','~','~','~','~'},
            {'2','~','~','~','~','~'},
            {'3','~','~','~','~','~'},
            {'4','~','~','~','~','~'},
            {'5','~','~','~','~','~'}
        };
        static int[,] answer = {
            {3,5},
            {4,3},
            {2,2}
        };
        static int[,] ans = {
            {0,0},
            {0,0},
            {0,0}
        };
        
        static void Main(string[] args)
        {
            while(battletank)
            {
                Console.WriteLine("selamat datang di game battle tank!");
                Console.WriteLine("anda bertugas untuk menghancurkan 3 tank");
                Tank();
                try
                {
                    Console.Write("Pilih baris: "); tebakan[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Pilih kolom: "); tebakan[1] = Convert.ToInt32(Console.ReadLine());
                }catch(Exception e){
                    Console.WriteLine("Error: masukkan angka 1-5");
                }
                truth = cekjawaban();
                if(truth == 2)
                {
                    Console.WriteLine("Tempat ini sudah hancur!");
                }
                else
                if(truth == 1)
                {
                    Console.WriteLine("Boom! Tank berhasil dihancurkan!");
                    tankhancur++;
                }
                else
                {
                    Console.WriteLine("Tempat ini aman!");
                }
                if(tankhancur == 3)
                {
                    Console.WriteLine("\nMenang! Tank hancur semua!");
                    battletank=false;
                }
                Console.WriteLine();
            }
        }

        static void Tank()
        {
            for(int i=0;i<6;i++)
            {
                for(int j=0;j<6;j++)
                {
                    Console.Write(tank[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int cekjawaban()
        {
            for(int i=0;i<3;i++)
            {
                if(ans[i,0] == tebakan[0] && ans[i,1] == tebakan[1])
                {
                    return 2;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(answer[i,0] == tebakan[0] && answer[i,1] == tebakan[1])
                {
                    tank[tebakan[0],tebakan[1]] = 'X';
                    ans[i,0] = tebakan[0];
                    ans[i,1] = tebakan[1];
                    return 1;
                }
                else
                {
                    tank[tebakan[0],tebakan[1]] = '0';
                }
            }
            return 0;
        }
    }
}