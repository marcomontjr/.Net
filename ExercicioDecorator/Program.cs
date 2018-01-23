using ExercicioDecorator.Filtros;
using System;
using System.Collections.Generic;

namespace ExercicioDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Filtro filtros = new SaldoMenor100(new SaldoMaior500Mil(new MesCorrente()));
            IList<Conta> contas = new List<Conta>();

            Conta conta1 = new Conta(200, new DateTime(2017, 1, 18), "123456"); //Não vai entrar em nenhuma regra.
            Conta conta2 = new Conta(99, new DateTime(2017, 1, 18), "654321"); //Vai entrar na regra SaldoMenor100.
            Conta conta3 = new Conta(1000000, new DateTime(2017, 1, 18), "789012"); //Vai entrar na regra SaldoMaior500Mil.
            Conta conta4 = new Conta(200, DateTime.Now, "210987"); //Vai entrar na regra MesCorrente.
            Conta conta5 = new Conta(20, DateTime.Now, "895623"); //Vai entrar na regra de SaldoMenor100 e mês corrente.
            Conta conta6 = new Conta(50000000, DateTime.Now, "235689"); //Vai entrar na regra de SaldoMaior500Mil e mês corrente.

            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);
            contas.Add(conta4);
            contas.Add(conta5);
            contas.Add(conta6);

            IList<Conta> contasFiltradas = filtros.Filtra(contas);
            Console.WriteLine(contasFiltradas);
            Console.ReadKey();
        }
    }
}