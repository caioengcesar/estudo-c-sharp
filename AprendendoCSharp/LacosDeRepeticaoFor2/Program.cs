using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosDeRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for(int contador = 0; contador <=10; contador++)
                {
                    Console.WriteLine(multiplicador + " * " + contador + " = " + contador * multiplicador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
