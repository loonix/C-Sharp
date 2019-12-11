using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List06_Ex1_Sequencia_10_numeros_Vector_Divisivel_por_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] todosOsNumeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Numero " + (i + 1) + ":");
                todosOsNumeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Numeros DIV 3");
            for (int i = 0; i < 10; i++)
            {
                if (todosOsNumeros[i] % 3 == 0)
                {
                    Console.WriteLine(todosOsNumeros[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Numeros Nao DIV 3");
            for (int i = 0; i < 10; i++)
            {
                if (todosOsNumeros[i] % 3 != 0)
                {
                    Console.WriteLine(todosOsNumeros[i]);
                }
            }

            Console.ReadKey();

        }

    }
}
