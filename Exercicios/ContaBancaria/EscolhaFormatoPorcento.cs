using System;

namespace Exercicios.ContaBancaria
{
    class EscolhaFormatoPorcento : IEscolhaFormato
    {
        public IEscolhaFormato Proximo { get; set; }
        public String RetornaFormatacao(ContaFormato conta, Requisicao req)
        {
            if (req.Formato == Formato.Porcento)
                return ("Numero da Conta: " + conta.NumConta + "\n" +
                        "Nome do Titular: " + conta.NomeTitular + "\n" +
                        "Formato Escolhido: %");
            else
                return "Formato Inválido";
        }
    }
}