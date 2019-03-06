using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, comprimento_esfera, area_esfera, volume_esfera;
            Console.WriteLine("Digite o valor do raio da esfera:");
            raio = double.Parse(Console.ReadLine());
            comprimento_esfera = 2 * Math.PI * raio;
            area_esfera = Math.PI * Math.Pow(raio, 2);
            volume_esfera = 3 * Math.PI * Math.Pow(raio, 3) / 4;
            Console.WriteLine("Comprimento da Esfera: " + comprimento_esfera + "\nÁrea da Esfera: " + area_esfera + "\nVolume da Esfera: " + volume_esfera);
            Console.ReadKey();
        }
    }
}
