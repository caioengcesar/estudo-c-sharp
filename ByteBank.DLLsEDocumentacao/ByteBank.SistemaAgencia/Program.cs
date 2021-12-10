using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(847, 489754);

            //Console.WriteLine(conta.Numero);

            //----------------------------------------------------------

            //DateTime dataFimPagamento = new DateTime(2022, 8, 17);
            //DateTime dataCorrente = DateTime.Now;

            //TimeSpan diferenca = dataFimPagamento - dataCorrente;

            //Console.WriteLine(dataCorrente);
            //Console.WriteLine(dataFimPagamento);

            //string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            ////Console.WriteLine("Vencimento em " + diferenca);
            //Console.WriteLine(mensagem);

            //---------------------String-Expressoes-Regulares-Classe-Object------------------------

            //string url = "pagina?argumentos";
            //int indiceInterrogacao = url.IndexOf('?');

            //string argumentos = url.Substring(indiceInterrogacao + 1);

            //Console.WriteLine(argumentos);

            //string palavra = "moedaOrigem=real&moedaDestino=dolar";
            //string nomeArgumento = "moedaDestino";

            //int indice = palavra.IndexOf(nomeArgumento);

            //int indiceValor = indice + nomeArgumento.Length;

            //string valorArgumento = palavra.Substring(indiceValor);

            //----------------------------------Testes---------------------------------------

            //string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            //Console.WriteLine(extrator.GetValor("moedaOrigem")); //real
            //Console.WriteLine(extrator.GetValor("moedaDestino")); //dolar
            //Console.WriteLine(extrator.GetValor("Valor")); //1500

            //--------------------------Expressões-Regulares----------------------------------

            ////string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            ////string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            ////string padrao = "[0-9]{4}[-][0-9]{4}";
            ////string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-?[0-9]{4}";

            //string texto = "Meu número é: 92342-3453";

            //Match match = Regex.Match(texto, padrao);
            //Console.WriteLine(match.Value);

            //--------------------------------Classe-Object--------------------------------------

            ContaCorrente conta = new ContaCorrente(342, 37652);
            Console.WriteLine(conta);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if(carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            Console.ReadLine();
        }

        //static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        //{
        //    if (timeSpan.Days > 30)
        //    {
        //        int quantidadeDeMeses = timeSpan.Days / 30;
        //        if (quantidadeDeMeses == 1)
        //        {
        //            return "1 mês";
        //        }
        //        return quantidadeDeMeses + " meses";
        //    }
        //    return timeSpan.Days + " dias";
        //}
    }
}
