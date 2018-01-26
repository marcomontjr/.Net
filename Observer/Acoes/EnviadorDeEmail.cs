using System;

namespace Observer.Acoes
{
    public class EnviadorDeEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("E-mail de Nota Fiscal Enviado com Sucesso!");
        }
    }
}