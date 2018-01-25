using System;

namespace Builder
{
    class Program
    {
        public static void Main(string[] args)
        {
            NotaFiscal nf = new NotaFiscalBuilder().ParaEmpresa("Caelum Ensino e Inovação")
                .ComCnpj("23.467.789/0001-12")
                .ComItem(new ItemNota("item 1", 100.0))
                .ComItem(new ItemNota("item 2", 200.0))                
                .ComObservacoes("Uma obs qualquer")
                .NaData(new DateTime(2008, 04, 14))
                .Constroi();

            Console.WriteLine(nf.DataEmissao);
            Console.WriteLine(nf.ValBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();
        }
    }
}