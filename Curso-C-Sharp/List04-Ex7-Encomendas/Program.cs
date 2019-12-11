using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List04_Ex7_Encomendas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroProdutos;
            do
            {
                Console.Write("Numero de Produtos: ");
                numeroProdutos = int.Parse(Console.ReadLine());
            } while (numeroProdutos < 2);

            string descricao;
            double preco, qtd;
            double soma = 0;
            double subTotal = 0;
            string descricaomaior = "";
            double maiorPreco = 0;

            for (int i = 1; i <= numeroProdutos; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Produto " + i);
                Console.Write("  Descricao.:");
                descricao = Console.ReadLine();
                Console.Write("  Preco.....:");
                preco = int.Parse(Console.ReadLine());
                Console.Write("  Quantidade:");
                qtd = int.Parse(Console.ReadLine());
                subTotal = (preco * qtd);
                Console.WriteLine("  Subtotal do Produto " + subTotal);
                soma = subTotal + soma;
                if(preco > maiorPreco)
                {
                    maiorPreco = preco;
                    descricaomaior = descricao;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Maior Preco: ");
            Console.WriteLine("  Descricao: " + descricaomaior);
            Console.WriteLine("  Preco....: " + maiorPreco);


            Console.WriteLine("Total Encomenda: " + soma + " euros");
            Console.ReadKey();
           
        }
    }
}
