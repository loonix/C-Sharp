using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List05_Pontos
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(calculaPontos(10, 2));
            Console.ReadKey();
        }

        static int calculaPontos(int vitorias , int empates)
        {     
            return (vitorias * 3) + empates;
        }

        static int calculaPontos2(int vitorias, int empates)
        {
            int pontos = 0;
            pontos = (vitorias * 3) + empates;
            return pontos;
        }
    }
}
