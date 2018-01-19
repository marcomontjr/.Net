using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto impostoComplexo = new ISS();
            Orcamento orcamento = new Orcamento(500.0);
            double valor = impostoComplexo.Calcula(orcamento);
            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}