using Exercicios.ContaBancaria;
using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaFormato conta = new ContaFormato();

            conta.NomeTitular = "Marco Jr.";
            conta.NumConta = "1234567890";
            
            Requisicao req = new Requisicao(Formato.FormatoInvalido);
            Formatador formato = new Formatador();

            var saida = formato.Formata(conta, req);            

            Console.WriteLine(saida);
            Console.ReadKey();
        }
    }
}
