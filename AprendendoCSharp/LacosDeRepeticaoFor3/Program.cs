using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosDeRepeticaoFor3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int linhas = 0; linhas < 10; linhas++)
            {
                for(int colunas = 0; colunas < 10; colunas++)
                {
                    if(colunas>linhas)
                    {
                        break;
                    }
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
