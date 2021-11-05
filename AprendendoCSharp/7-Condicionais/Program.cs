using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 Concicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if(idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhasdo. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18, não pode entrar.");
                }
            }

            Console.WriteLine("Seu projeto foi executado. Pressione enter para finalizar...");
            Console.ReadLine();
        }
    }
}
