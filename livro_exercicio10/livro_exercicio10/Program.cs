using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, area;
            Console.WriteLine("Digite o valor do lado do quadrado:");
            lado = double.Parse(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("A área do quadrado é " + area);
            Console.ReadKey();
        }
    }
}
