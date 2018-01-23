using System;

namespace ExercicioDecorator
{
    public class Conta
    {
        public Double Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public String NumConta { get; private set; }

        public Conta(Double saldo, DateTime dataAbertura, String numConta)
        {
            Saldo = saldo;
            DataAbertura = dataAbertura;
            NumConta = numConta;
        }   
    }
}