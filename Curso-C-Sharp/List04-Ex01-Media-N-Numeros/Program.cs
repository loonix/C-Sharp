using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List04_Ex01_Media_N_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantidade = 0;
            Console.WriteLine("==============================");
                Console.Write("Quantidade de numeros: ");
            quantidade = double.Parse(Console.ReadLine());
            Console.WriteLine("==============================");

            double soma = 0;
            Console.WriteLine("==============================");
            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write("Numero " + i + ": ");
                soma = soma + double.Parse(Console.ReadLine());
            }
            double media = soma / quantidade;
            Console.WriteLine("==============================");
            Console.WriteLine("");
            Console.WriteLine("Media :" + media);
            Console.WriteLine("Soma :" + soma);
            Console.WriteLine("");
            Console.WriteLine("Prima enter para sair...");

            Console.ReadKey();

        }
    }
}
