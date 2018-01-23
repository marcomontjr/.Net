using State.Interfaces;
using System;

namespace State.Estados
{
    class Finalizado : IEstado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos Finalizados não recebem descontos");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Este Orçamento está Finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Este Orçamento está Finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Este orçamento já está Finalizado");
        }
    }
}