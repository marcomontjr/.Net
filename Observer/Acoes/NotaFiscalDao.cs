using System;

namespace Observer.Acoes
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal ng)
        {
            Console.WriteLine("Salvo No Banco de Dados com Sucesso!");
        }
    }
}
