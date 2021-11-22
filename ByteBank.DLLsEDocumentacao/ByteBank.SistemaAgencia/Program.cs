using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            DateTime dataFimPagamento = new DateTime(2022, 8, 17);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            //Console.WriteLine("Vencimento em " + diferenca);
            Console.WriteLine(mensagem);

            Console.ReadLine();
        }

        //static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        //{
        //    if (timeSpan.Days > 30)
        //    {
        //        int quantidadeDeMeses = timeSpan.Days / 30;
        //        if (quantidadeDeMeses == 1)
        //        {
        //            return "1 mês"
        //        }
        //        return quantidadeDeMeses + " meses";
        //    }
        //    return timeSpan.Days + " dias";
        //}
    }
}
