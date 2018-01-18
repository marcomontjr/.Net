using Exercicio.Interface;
using Exercicio.Relatorios;
using System.Collections.Generic;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Conta> contas = new List<Conta>()
            {
                new Conta {Titular = "Marco Jr.",  Saldo = 200, Agencia = "123", NumConta = "1234"},
                new Conta {Titular = "João da Silva",  Saldo = 4400, Agencia = "123", NumConta = "4321"},
                new Conta {Titular = "Maria da Silva",  Saldo = 100, Agencia = "123", NumConta = "5678"}              
            };

            IRelatorio simples = new Simples();
            IRelatorio complexo = new Complexo();

            MontaRelatorio monta = new MontaRelatorio();
            monta.Monta(contas, complexo);

        }
    }
}
