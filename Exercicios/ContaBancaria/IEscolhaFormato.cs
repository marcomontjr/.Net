using System;

namespace Exercicios.ContaBancaria
{
    interface IEscolhaFormato
    {
        String RetornaFormatacao(ContaFormato conta, Requisicao req);
        IEscolhaFormato Proximo { get; set; }
    }
}
