using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco_inicial, novo_preco;
            Console.WriteLine("Digite o preço inicial do produto:");
            preco_inicial = double.Parse(Console.ReadLine());
            novo_preco = preco_inicial * 0.9;
            Console.WriteLine("O novo preço do produto é R$" + novo_preco);
            Console.ReadKey();
        }
    }
}
