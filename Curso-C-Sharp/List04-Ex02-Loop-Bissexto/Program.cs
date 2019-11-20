using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List04_Ex02_Loop_Bissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, resto4, resto100, resto400;

            Console.Write("Introduza ano de inicio: ");
            inicio = int.Parse(Console.ReadLine());
            Console.Write("Introduza ano de fim...: ");
            fim = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = inicio; i <= fim; i++)
            {
                resto4 = i % 4;
                resto100 = i % 100;
                resto400 = i % 400;

                if ((resto4 == 0 && resto100 != 0) || (resto400 == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("|   "+i+" - E bissexto    |");
                    Console.WriteLine("--------------------------");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    Console.WriteLine(i + " - Nao bissexto");
                }
            }
            Console.Write("ENTER para terminar");
            Console.ReadKey();
        }
    }
}
