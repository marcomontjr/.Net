using ChainofResponsibility.Calculo;
using System;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calc = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Lápis", 500));
            orcamento.AdicionaItem(new Item("Caneta", 500));

            double desconto = calc.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }   
    }
}
