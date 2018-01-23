using State.Interfaces;
using System;

namespace State.Estados
{
    class Reprovado : IEstado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem descontos");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está Reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}