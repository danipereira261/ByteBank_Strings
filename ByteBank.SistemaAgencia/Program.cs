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
        public static object ContaCorrente { get; private set; }

        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 7, 16);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataCorrente - dataFimPagamento;

            string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
