using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04_Ex04_MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            int num;
            int soma = 0;
            int contaPares = 0, contaImpares = 0;
            int contador = 1;
            int max = 0, min = 0;

            do //fazer
            {
                Console.Write("Introduza o numero (zero p/ terminar) " + contador + ": ");
                num = int.Parse(Console.ReadLine());

                //não considerar o num = 0
                if (num != 0)
                {
                    soma = soma + num;

                    //par e impar
                    if (num % 2 == 0)
                    {
                        contaPares = contaPares + 1;
                    }
                    else
                    {
                        contaImpares = contaImpares + 1;
                    }

                    //max e min
                    if (contador == 1)//o 1º numero é max e min
                    {
                        max = num;
                        min = num;
                    }

                    if (num > max)
                    {
                        max = num;
                    }

                    if (num < min)
                    {
                        min = num;
                    }


                    contador = contador + 1; //contador++;
                }


            } while (num != 0); //enquanto numero diferente (!=) de zero (0)

            Console.WriteLine();
            Console.WriteLine("Qtd Numeros..: " + (contador - 1));
            Console.WriteLine("Soma.........: " + soma);
            Console.WriteLine("Qtd Pares....: " + contaPares);
            Console.WriteLine("Qtd Impares..: " + contaImpares);
            Console.WriteLine("Máximo.......: " + max);
            Console.WriteLine("Minimo.......: " + min);

            Console.ReadKey();
        }
    }
}
