using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numero = 1; numero <= 100; numero++)
            {
                if(numero % 3 == 0)
                {
                    Console.WriteLine(numero + " é múltiplo de 3.");
                }
                else
                {
                    Console.WriteLine(numero + " não é múltiplo de 3.");
                }
            }
            Console.ReadLine();
        }
    }
}
