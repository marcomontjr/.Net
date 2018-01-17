using System;

namespace Exercicios.ContaBancaria
{
    class EscolhaFormatoCSV : IEscolhaFormato
    {
        public IEscolhaFormato Proximo { get; set; }
        public String RetornaFormatacao(ContaFormato conta, Requisicao req)
        {
            if (req.Formato == Formato.CSV)
                return ("Numero da Conta: " + conta.NumConta + "\n" +
                        "Nome do Titular: " + conta.NomeTitular + "\n" +
                        "Formato Escolhido: CSV");
            else
                return Proximo.RetornaFormatacao(conta, req);
        }
    }
}