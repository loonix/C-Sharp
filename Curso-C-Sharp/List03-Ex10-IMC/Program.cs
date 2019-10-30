using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List03_Ex10_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double peso;
            double imc;

            Console.Write("Introduza o peso (kg): ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Introduza a altura (m): ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / Math.Pow(altura, 2);

            if (imc < 20)
            {
                Console.WriteLine("Diagnostico: Baixo Peso");
            }
            else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("Diagnostico: Normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Diagnostico: Excesso de peso");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Diagnostico: Obesidade");
            }
            else if (imc >= 35)
            {
                Console.WriteLine("Diagnostico: Obesidade Morbida");
            }
            Console.WriteLine("IMC: " + imc);
            Console.WriteLine("Prima enter para sair...");
            Console.ReadKey();

        }
    }
}
