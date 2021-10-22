using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace povtor
{
    class Program
    {

        public static int Saali_suurus()
        {
            Console.WriteLine("Razmer Zala [1,2,3]");
            int a = int.Parse(Console.ReadLine());
            return a;
        }
        static int[,] saal = new int[,] { };
        static int kohad, read;
        public static void Saali_taitmine(int a)
        {
            Random rnd = new Random();
            if (a==1)
            {
                kohad = 30;
                read = 20;

            }
            else if (a==2)
            {
                kohad = 40;
                read = 30;
            }
            else
            {
                kohad = 50;
                read = 38;
            }
            saal = new int[read, kohad];

            for (int rida = 0; rida < read; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {
                    saal[rida, koht] = rnd.Next(0, 2);
                }
            }
            
        }
        public static void Saal_ekraanile()
        {
            Console.Write(" ");
            for (int koht = 0; koht < kohad; koht++)
            {
                if (koht.ToString().Length == 2)
                {
                    Console.Write(" {0}", koht + 1);
                }
                else
                {
                    Console.Write("{0}", koht + 1);
                }
            }

            Console.WriteLine();

            for (int rida = 0; rida < read; rida++)
            {
                Console.Write("Rida " + (rida + 1).ToString() + ": ");
                for (int koht = 0; koht < kohad; koht++)
                {
                    Console.Write(saal[rida, koht]);
                }
                Console.WriteLine();
            }
        }
        static bool Muuk()
        {
            Console.WriteLine();
            Console.WriteLine("sisesta rida");
            int rida1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Mitu piletid: ");
            int mitu = int.Parse(Console.ReadLine());
            int[] ost = new int[] { };
            int p = kohad / 2; 
            if (saal[rida1-1, p-1]==0)

            {
                Console.WriteLine($"Koht {p} on vaba.");
                return true;
            }
            else
            {
                Console.WriteLine($"Koht {p} on kinni.");
                return false;

            }


        }
        static void Main(string[] args)
        {
            int suurus = Saali_suurus();

            Saali_taitmine(suurus);
            while (true)
            {
                Saal_ekraanile();
                bool ost = Muuk();
                Console.WriteLine(ost);
            }
        }
    }
}
