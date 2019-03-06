using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media_p;
            Console.WriteLine("Digite a primeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            media_p = ((nota1 * 2) + (nota2 * 3)) / 5.0;
            Console.WriteLine("A média ponderada entre as duas notas é: " + media_p);
            Console.ReadKey();
        }
    }
}
