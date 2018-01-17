using System;

namespace Exercicios.ContaBancaria
{
    public class Formatador
    {
        public String Formata(ContaFormato conta, Requisicao req)
        {
            IEscolhaFormato xml = new EscolhaFormatoXML();
            IEscolhaFormato csv = new EscolhaFormatoCSV();
            IEscolhaFormato porcento = new EscolhaFormatoPorcento();

            xml.Proximo = csv;
            csv.Proximo = porcento;

            return xml.RetornaFormatacao(conta, req);
        }
    }
}