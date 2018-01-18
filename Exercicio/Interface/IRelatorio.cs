using System.Collections.Generic;

namespace Exercicio.Interface
{
    public interface IRelatorio
    {
        void Imprime(IList<Conta> contas);
    }
}
