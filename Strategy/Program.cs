using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500);
            CalculadorDeImpostos calc = new CalculadorDeImpostos();

            //Neste ponto posso passar c/ qual imposto desejo trabalhar.
            calc.RealizaCalculo(orcamento, icms);
            calc.RealizaCalculo(orcamento, iss);

            Console.ReadKey();
        }
    }
}
