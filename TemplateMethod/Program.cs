using System;
using TemplateMethod.Impostos;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(1500);
            orcamento.AdiocionaItem(new Item("Mouse", 10));

            Imposto icpp = new ICPP();
            Imposto ikcv = new IKCV();

            CalculadorDeImpostos calc = new CalculadorDeImpostos();

            calc.RealizaCalculo(orcamento, icpp);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
