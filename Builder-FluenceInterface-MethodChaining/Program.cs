using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            criador
                .ParaEmpresa("Caelum Ensino e Inovação")
                .ComCnpj("23.467.789/0001-12")
                .ComItem(new ItemNota("item 1", 100.0))
                .ComItem(new ItemNota("item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("Uma obs qualquer");

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();            
        }
    }
}