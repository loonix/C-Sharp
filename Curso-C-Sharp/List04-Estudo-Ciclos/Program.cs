using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List04_Estudo_Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrever 10 vezes a palavra ISLA -n

            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine("Isla - " + contador + " - While");
                contador = contador + 1;
            }

            contador = 1;

            do
            {
                Console.WriteLine("Isla - " + contador + " - Do...While");
                contador = contador + 1;
            } while (contador < 11);


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Isla - " + i + " - for");
            }




            Console.ReadKey();
        }
    }
}
