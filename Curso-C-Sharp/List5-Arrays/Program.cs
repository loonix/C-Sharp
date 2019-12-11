using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List5_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int[] vectorA = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.Write((i + 1) + " numero");
                vectorA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(vectorA[i]);
            }
        }
    }
}
