using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List05_Funcoes_e_Procedimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes, mesAtual, mesPreferido;

            Console.Write("Mes numerico nascimento:");
            mes = int.Parse(Console.ReadLine());
            string mesExtenso = "";
            mesExtenso = gerarMesString(mes);
            Console.WriteLine(mesExtenso);

            Console.Write("Mes numerico atual:");
            mesAtual = int.Parse(Console.ReadLine());
            mesExtenso = gerarMesString(mesAtual);
            Console.WriteLine(mesExtenso);


            Console.Write("Mes numerico atual:");
            mesPreferido = int.Parse(Console.ReadLine());
            mesExtenso = gerarMesString(mes);
            Console.WriteLine(mesExtenso);

            Console.ReadKey();
        }
    private static string gerarMesString(int mes)
        {
            string mesExtenso = "";

            switch (mes)
            {
                case 1:
                    mesExtenso = "Janeiro";
                    break;
                case 2:
                    mesExtenso = "Fevereiro";
                    break;
                case 3:
                    mesExtenso = "Marco";
                    break;
                case 4:
                    mesExtenso = "Abril";
                    break;
                case 5:
                    mesExtenso = "Maio";
                    break;
                case 6:
                    mesExtenso = "Junho";
                    break;
                case 7:
                    mesExtenso = "Julho";
                    break;
                case 8:
                    mesExtenso = "Agosto";
                    break;
                case 9:
                    mesExtenso = "Setembro";
                    break;
                case 10:
                    mesExtenso = "Outubro";
                    break;
                case 11:
                    mesExtenso = "Novembro";
                    break;
                case 12:
                    mesExtenso = "Dezembro";
                    break;
                default:
                    mesExtenso = "Mes invalido";
                    break;
            }
            return mesExtenso;

        }
    }
}
