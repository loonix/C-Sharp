using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List06_Ex5_Lista_notas
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 0;
            do
            {
                Console.Write("Quantidade de notas (1 a 100): ");
                numero = int.Parse(Console.ReadLine());

            } while (numero < 1 || numero > 100);

            int[] vector = new int[numero];
            double[] vectorNotas = new double[numero];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Escreva a nota " + (i+1) + ":");
                vectorNotas[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Notas:");
            for (int i = 0; i < vectorNotas.Length; i++)
            {
                Console.WriteLine(vectorNotas[i]);
            }

            double med = MediaNotas(vectorNotas);
            Console.WriteLine("Media de notas: " + med);
            double notaMaxima = NotaMaxima(vectorNotas);
            Console.WriteLine("Nota Maxima: " + notaMaxima);
            Console.ReadLine();


        }

        /// <summary>
        /// Esta funcao recebe um vector e a dimensao e retorna a media
        /// </summary>
        /// <param name="vetor"></param>
        /// <returns></returns>
        static double MediaNotas(double[] vetor)
        {
            double soma = 0, media = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma = soma + vetor[i];
            }
            media = soma / vetor.Length;
            return media;
        }

        static double NotaMaxima(double[] vetor)
        {
            double notaMax = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] > notaMax)
                {
                    notaMax = vetor[i];
                }
            }
            return notaMax;
        }
    }
}
