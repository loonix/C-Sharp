using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List03_Ex9_PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
       Segundo uma tabela médica, o peso ideal está relacionado com a altura e sexo. Criar um
      programa que receba a altura e o sexo de uma pessoa, calcular e apresentar o peso ideal,
      utilizado as seguinte formulas:
       Homens: (72.7 * Altura) - 58
       Mulheres: (62.1 * Altura) - 44.7
      */
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            double altura;
            //int sexo; // alternativa
            string sexo;

            Console.Write("Introduza a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Introduza o sexo (M/F): ");
            //Console.Write("Introduza o sexo (1 - Homem | 2 - Mulher): ");
            //sexo = int.Parse(Console.ReadLine());
            sexo = Console.ReadLine();

            if (sexo == "M" || sexo == "m")
            //if (sexo == 1)
            {
                Console.WriteLine("O peso ideal e: " + ((72.7 * altura) - 58));
            }
            else
            {
                Console.WriteLine("O peso ideal e: " + ((62.1 * altura) - 44.7));
            }
            Console.WriteLine("Prima enter para sair...");
            Console.ReadKey();
        }
    }
}
