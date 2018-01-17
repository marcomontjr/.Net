using System;

namespace Exercicios.ContaBancaria
{
    class EscolhaFormatoXML : IEscolhaFormato
    {
        public IEscolhaFormato Proximo { get; set; }
        public String RetornaFormatacao(ContaFormato conta, Requisicao req)
        {
            if (req.Formato == Formato.XML)
                return ("Numero da Conta: " + conta.NumConta + "\n" +
                        "Nome do Titular: " + conta.NomeTitular + "\n" +
                        "Formato Escolhido: XML");
            else
                return Proximo.RetornaFormatacao(conta, req);
        }
    }
}
