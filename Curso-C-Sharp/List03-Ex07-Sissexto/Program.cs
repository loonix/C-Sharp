using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, resto4, resto100, resto400;

            Console.Write("Introduza ano: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine(ano);

            resto4 = ano % 4;
            resto100 = ano % 100;
            resto400 = ano % 400;

            if((resto4 == 0 && resto100 != 0) || (resto400 == 0)) {
                Console.WriteLine("E bissexto");
            } else
            {
                Console.WriteLine("Nao bissexto");
            }
            Console.Write("ENTER para terminar");
            Console.ReadKey();
        }
    }
}
