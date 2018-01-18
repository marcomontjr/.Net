using Exercicio.Interface;
using System.Collections.Generic;

namespace Exercicio
{
    public class MontaRelatorio
    {
        public void Monta(IList<Conta> conta, IRelatorio relatorio)
        {
            relatorio.Imprime(conta);
        }
    }
}
