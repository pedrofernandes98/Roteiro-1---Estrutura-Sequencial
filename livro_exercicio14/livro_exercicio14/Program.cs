using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano_nascimento, ano_atual, idade_dias, idade_anos, idade_semanas, idade_meses;
            Console.WriteLine("Digite o ano de nascimento:");
            ano_nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual:");
            ano_atual = int.Parse(Console.ReadLine());
            idade_anos = ano_atual - ano_nascimento;
            idade_meses = idade_anos * 12;
            idade_semanas = idade_anos * (365 / 7);
            idade_dias = idade_anos * 365;
            Console.WriteLine("Idade em Anos: " + idade_anos + "\nIdade em Meses: " + idade_meses + "\nIdade em Semanas: " + idade_semanas + "\nIdade em Dias: " + idade_dias);
            Console.ReadKey();
        }
    }
}
