using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(7480, 874150);

            //Console.WriteLine(ContaCorrente.TaxaOperacao);
            //Console.WriteLine(conta.Agencia);
            //Console.WriteLine(conta.Numero);


            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
            {
                //Console.WriteLine(excecao.Message);
                //Console.WriteLine(excecao.StackTrace);
                Console.WriteLine("Não é possível divisão por zero!");
            }
            //catch (NullReferenceException excecao)
            //{
                //Console.WriteLine(excecao.Message);
                //Console.WriteLine(excecao.StackTrace);
            //}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadLine();

        }

        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);
            try
            {
                return numero / divisor;
            }
            catch(Exception)
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
        }

        public static void Metodo()
        {
                TestaDivisao(0);
        }

        public static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
