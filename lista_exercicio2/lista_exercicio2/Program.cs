using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cateto_oposto, cateto_adjascente, hipotenusa;
            Console.WriteLine("Digite o valor do cateto oposto do triângulo:");
            cateto_oposto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do cateto adjascente do triângulo:");
            cateto_adjascente = double.Parse(Console.ReadLine());
            hipotenusa = Math.Sqrt(Math.Pow(cateto_oposto, 2) + Math.Pow(cateto_adjascente, 2));
            Console.WriteLine("O Cateto Oposto vale " + cateto_oposto + "\nO Cateto Adjascente vale " + cateto_adjascente + "\nA hipotenusa vale " + hipotenusa);
            Console.ReadKey();
        }
    }
}
