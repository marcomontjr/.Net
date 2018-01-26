using Observer.Acoes;
using System;

namespace Observer
{
    class Program
    {
        public static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new EnviadorDeSMS());
            criador.AdicionaAcao(new NotaFiscalDao());

            NotaFiscal nf = criador.ParaEmpresa("Caelum Ensino e Inovação")
                .ComCnpj("23.467.789/0001-12")
                .ComItem(new ItemNota("item 1", 100.0))
                .ComItem(new ItemNota("item 2", 200.0))
                .ComObservacoes("Uma obs qualquer")
                .NaData(new DateTime(2008, 04, 14))
                .Constroi();           

            Console.ReadKey();
        }
    }
}