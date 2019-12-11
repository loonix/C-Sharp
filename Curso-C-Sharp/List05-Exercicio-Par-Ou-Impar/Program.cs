using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List05_Exercicio_Par_Ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.Write("Escreva um numero:");
            numero = int.Parse(Console.ReadLine());
            Console.Write(FuncParImpar(numero));
            Console.Write(ProcParImpar(numero));

            Console.ReadLine();
        }

        static int FuncParImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                return 1;
            }
            return -1;
        }

        static void ProcParImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("O Numero " + numero + " e par");
            }
            Console.WriteLine("O Numero " + numero + " e impar");
        }


    }
}
