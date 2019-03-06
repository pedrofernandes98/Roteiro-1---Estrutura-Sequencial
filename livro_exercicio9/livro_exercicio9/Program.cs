using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double base_maior, base_menor, altura, area;
            Console.WriteLine("Digite o valor da base maior do trapézio:");
            base_maior = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da base menor do trapézio:");
            base_menor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do trapézio:");
            altura = double.Parse(Console.ReadLine());
            area = ((base_maior + base_menor) * altura) / 2.0;
            Console.WriteLine("A área do trapézio é de " + area);
            Console.ReadKey();
        }
    }
}
