using System;

namespace Observer.Acoes
{
    public class EnviadorDeSMS : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("SMS Enviado com Sucesso!");
        }
    }
}