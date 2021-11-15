using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------Primeiro Estudo-----------------------------------------

            //ContaCorrente conta = new ContaCorrente(7480, 874150);

            //Console.WriteLine(ContaCorrente.TaxaOperacao);
            //Console.WriteLine(conta.Agencia);
            //Console.WriteLine(conta.Numero);

            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //-------------------------Segundo Estudo-----------------------------------------

            //try
            //{
            //Metodo();
            //}


            //catch (DivideByZeroException e)
            //{
            //Console.WriteLine(excecao.Message);-
            //Console.WriteLine(excecao.StackTrace);-
            //Console.WriteLine("Não é possível divisão por zero!");
            //}


            //catch (NullReferenceException excecao)-
            //{-
            //Console.WriteLine(excecao.Message);-
            //Console.WriteLine(excecao.StackTrace);-
            //}-


            //catch (Exception e)
            //{
            //Console.WriteLine(e.Message);
            //Console.WriteLine(e.StackTrace);
            //}

            //-------------------------Terceiro Estudo-----------------------------------------

            //try
            //{
            //ContaCorrente conta = new ContaCorrente(0, 0);
            //}
            //catch (ArgumentException e)
            //{
            //Console.WriteLine(e.Message);
            //Console.WriteLine(e.ParamName);
            //}

            //-------------------------Quarto Estudo-------------------------------------------

            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(456, 4578420);
            //    ContaCorrente conta2 = new ContaCorrente(485, 455478);

            //    conta2.Transferir(10000, conta);

            //    conta.Depositar(50);
            //    Console.WriteLine(conta.Saldo);
            //    conta.Sacar(-500);
            //    Console.WriteLine(conta.Saldo);
            //}
            //catch (ArgumentException ex)
            //{
            //    if(ex.ParamName == "numero")
            //    {

            //    }

            //    Console.WriteLine("Argumento com problema: " + ex.ParamName);
            //    Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (SaldoInsuficienteException ex)
            //{
            //    Console.WriteLine(ex.Saldo);
            //    Console.WriteLine(ex.ValorSaque);

            //    Console.WriteLine(ex.StackTrace);

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            //}

            //-------------------------Quinto Estudo-------------------------------------------

            //try
            //{
            //    ContaCorrente conta1 = new ContaCorrente(4564, 789684);
            //    ContaCorrente conta2 = new ContaCorrente(7891, 456794);

            //    //conta1.Transferir(10000, conta2);
            //    conta1.Sacar(10000);
            //}
            //catch(OperacaoFinanceiraException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);

            //    //Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

            //    //Console.WriteLine(e.InnerException.Message);
            //    //Console.WriteLine(e.InnerException.StackTrace);
            //}

            //----------------------------Sexto Estudo-------------------------------------------



            try
            {
                CarregarContas();
            }
            catch
            {
                Console.WriteLine("CATCH NO MÉTODO MAIN.");
            }
            Console.ReadLine();
        }

        public static void CarregarContas()
        {
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }


            //--------------------------------------------------------------------------------
            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas1.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch(IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o Finally.");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
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
