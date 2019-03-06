using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distancia;
            Console.WriteLine("Digite o valor de x do Ponto 1:");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y no Ponto 1 ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de x no Ponto 2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y no Ponto 2");
            y2 = double.Parse(Console.ReadLine());
            distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("A distância entre os pontos (" + x1 + ", " + y1 + ") e (" + x2 + ", " + y2 + ") é " + distancia);
            Console.ReadKey();
        }
    }
}
