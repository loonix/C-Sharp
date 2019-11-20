using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List04_Ex10_Notas_Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota = 0;
            int contador = 1;
            double max = 0, min = 0;
            double notasPositivas = 0;
            double notasNegativas = 0;
            double media = 0;
            double soma = 0;
            double mediaNotasPositivas = 0;
            double mediaNotasNegativas = 0;
            double porcentagemNegativas = 0;
            double porcentagemPositivas = 0;
            double somaPositivas = 0;
            double somaNegativas = 0;

            do
            {
                Console.Write("Introduza a nota (numero negativo p/ terminar) " + contador + ": ");
                nota = int.Parse(Console.ReadLine());

                if (nota >= 0)
                {
                    if (contador == 1)
                    {
                        max = nota;
                        min = nota;
                    }

                    soma = soma + nota;


                    if (nota > max)
                    {
                        max = nota;
                    }

                    if (nota < min)
                    {
                        min = nota;
                    }
                    if (nota >= 10)
                    {
                        notasPositivas++;
                        somaPositivas = somaPositivas + nota;
                    }
                    else
                    {
                        notasNegativas++;
                        somaNegativas = somaNegativas + nota;
                    }
                    contador = contador + 1;
                };

            } while (nota >= 0);

            contador = contador - 1;
            media = soma / contador;
            mediaNotasPositivas = somaPositivas / notasPositivas;
            mediaNotasNegativas = somaNegativas / notasNegativas;

            porcentagemNegativas = (notasNegativas / contador) * 100;
            porcentagemPositivas = (notasPositivas / contador) * 100;

            Console.WriteLine();
            Console.WriteLine("Quantidade de Notas: " + contador);
            Console.WriteLine("Nota Maxima: " + max);
            Console.WriteLine("Nota Minima: " + min);
            Console.WriteLine("Numero de Positivas (>10): " + notasPositivas);
            Console.WriteLine("Percentagem de Negativas: " + porcentagemNegativas + "%");
            Console.WriteLine("Percentagem de Positivas: " + porcentagemPositivas + "%");

            Console.WriteLine("Media das Notas: " + media);
            Console.WriteLine("Media da Notas Positivas: " + mediaNotasPositivas);
            Console.WriteLine("Media da Notas Negativas: " + mediaNotasNegativas);

            Console.ReadKey();
        }
    }
}
