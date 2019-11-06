using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List03_Ex14_Converter_Em_Mes
{
    class Program
    {

        static void Main(string[] args)
        {
            int mes = 0;

            Console.WriteLine("             ___     ");
            Console.WriteLine("            (o o)    ");
            Console.WriteLine("        ooO--(_)--Ooo");
            Console.WriteLine("##############################");
            Console.WriteLine("#                            #");
            Console.WriteLine("#  Conversor literal em Mes  #");
            Console.WriteLine("#                            #");
            Console.WriteLine("##############################");
            Console.WriteLine();

            Console.WriteLine("==============================");
            Console.Write("Escreva um mes de 1 a 12: ");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("==============================");
            Console.WriteLine();

            Console.WriteLine("Resposta: " + GerarStringMes(mes));
            Console.WriteLine("Prima enter terminar...");
            Console.WriteLine();
            Console.ReadKey();
        }

        private static string GerarStringMes(int mes)
        {
            string resposta;
            switch (mes)
            {
                case 1:
                    resposta = "Janeiro";
                    break;
                case 2:
                    resposta = "Fevereiro";
                    break;
                case 3:
                    resposta = "Marco";
                    break;
                case 4:
                    resposta = "Abril";
                    break;
                case 5:
                    resposta = "Maio";
                    break;
                case 6:
                    resposta = "Junho";
                    break;
                case 7:
                    resposta = "Julho";
                    break;
                case 8:
                    resposta = "Agosto";
                    break;
                case 9:
                    resposta = "Setembro";
                    break;
                case 10:
                    resposta = "Outubro";
                    break;
                case 11:
                    resposta = "Novembro";
                    break;
                case 12:
                    resposta = "Dezembro";
                    break;
                default:
                    resposta = "Numero Incorreto";
                    break;
            }
            return resposta;
        }
    }
}
