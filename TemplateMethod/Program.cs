using System;
using TemplateMethod.Impostos;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(1000);
            orcamento.AdiocionaItem(new Item("Mouse", 10));
            orcamento.AdiocionaItem(new Item("Mouse", 10));

            Imposto icpp = new ICPP();
            Imposto ikcv = new IKCV();
            Imposto ihit = new IHIT();

            CalculadorDeImpostos calc = new CalculadorDeImpostos();

            calc.RealizaCalculo(orcamento, ihit);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
