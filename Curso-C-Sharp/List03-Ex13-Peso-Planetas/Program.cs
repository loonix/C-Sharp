using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List03_Ex13_Peso_Planetas
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoTerra, calculo;
            double gravidade = 0;
            int planeta = 0;

            Console.WriteLine("##############################");
            Console.WriteLine("#                            #");
            Console.WriteLine("#        Peso Planetas       #");
            Console.WriteLine("#                            #");
            Console.WriteLine("##############################");
            Console.WriteLine();
            Console.WriteLine("==============================");

            Console.Write("Introduza o peso na terra: ");
            pesoTerra = double.Parse(Console.ReadLine());
            Console.WriteLine("==============================");
            Console.WriteLine();

            Console.WriteLine("##############################");
            Console.WriteLine("#          Planetas          #");
            Console.WriteLine("#       ===============      #");
            Console.WriteLine("#        1. Mercurio         #");
            Console.WriteLine("#        2. Venus            #");
            Console.WriteLine("#        3. Marte            #");
            Console.WriteLine("#        4. Jupiter          #");
            Console.WriteLine("#        5. Saturno          #");
            Console.WriteLine("#        6. Urano            #");
            Console.WriteLine("##############################");
            Console.WriteLine();
            Console.WriteLine("==============================");
                Console.Write("Escolha um planeta: ");
            planeta = int.Parse(Console.ReadLine());
            Console.WriteLine("==============================");
            Console.WriteLine();

            switch (planeta)
            {
                case 1:
                    gravidade = 0.37;
                    break;
                case 2:
                    gravidade = 0.88;
                    break;
                case 3:
                    gravidade = 0.38;
                    break;
                case 4:
                    gravidade = 2.64;
                    break;
                case 5:
                    gravidade = 1.15;
                    break;
                case 6:
                    gravidade = 1.17;
                    break;
                default:
                    break;
            }
       
            calculo = (pesoTerra / 10) * gravidade;

            Console.Write("Peso no planeta:" + calculo + " kg");
            Console.WriteLine();
            Console.WriteLine("Prima enter reiniciar...");
            Console.WriteLine();
            Console.ReadKey();

            var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
            System.Diagnostics.Process.Start(info);
        }
    }
}
