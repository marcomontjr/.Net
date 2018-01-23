using State.Interfaces;
using System;

namespace State.Estados
{
    class Aprovado : IEstado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está Aprovado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}