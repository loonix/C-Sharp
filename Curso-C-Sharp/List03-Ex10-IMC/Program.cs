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
            string diagnostico = "";

            Console.Write("Introduza o peso (kg): ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Introduza a altura (m): ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / Math.Pow(altura, 2);

            if (imc < 20)
            {
                diagnostico = "Baixo Peso";
            }
            else if (imc < 25)
            {
                diagnostico = "Normal";
            }
            else if (imc < 30)
            {
                diagnostico = "Excesso de peso";
            }
            else if (imc < 35)
            {
                diagnostico = "Obesidade";
            }
            else
            {
                diagnostico = "Obesidade Morbida";
            }
            Console.WriteLine("IMC: " + imc);
            Console.WriteLine("Diagnostico: " + diagnostico);

            Console.WriteLine("Prima enter para sair...");
            Console.ReadKey();

        }
    }
}
