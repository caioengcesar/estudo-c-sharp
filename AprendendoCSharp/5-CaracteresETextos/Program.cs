using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 Caracteres e Textos");

            char PrimeiraLetra = 'a';
            Console.WriteLine(PrimeiraLetra);

            PrimeiraLetra = (char)61;
            Console.WriteLine(PrimeiraLetra);

            PrimeiraLetra = (char)(PrimeiraLetra + 1);
            Console.WriteLine(PrimeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            string cursosProgramacao = @" - .NET
 - Java
 - JavaScript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("O projeto foi executado! Pressione enter para finalizar...");
            Console.ReadLine();
        }
    }
}
