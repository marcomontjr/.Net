using Exercicio.Template;
using System;
using System.Collections.Generic;

namespace Exercicio
{
    class Simples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Banco Alura");
            Console.WriteLine("-----------------------------------\n");
        }

        protected override void Rodape()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("(12) 3456-7890");
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (var item in contas)
            {
                Console.WriteLine("Titular: " + item.Titular);
                Console.WriteLine("Saldo: " + item.Saldo + "\n");
            }
        }
    }
}