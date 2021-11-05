using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsbocoIR
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.00;

            if(salario >= 1900.00 && salario <= 2800.00)
            {
                Console.WriteLine("A sua aliquota é 7,5%");
                Console.WriteLine("Você pode deduzir até R$ 142");
            }

            else if (salario >= 2800.01 && salario <= 3751.00)
            {
                Console.WriteLine("A sua aliquota é 15%");
                Console.WriteLine("Você pode deduzir até R$ 350");
            }

            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("A sua aliquota é 22,5%");
                Console.WriteLine("Você pode deduzir até R$ 636");
            }

            Console.ReadLine();
        }
    }
}
