using State.Interfaces;
using System;

namespace State.Estados
{
    class EmAnalise : IEstado
    {
        bool descontoApenasUmaVez;
        public EmAnalise()
        {
            descontoApenasUmaVez = true;
        }
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (descontoApenasUmaVez)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                descontoApenasUmaVez = false;
            }
            else
            {
                throw new Exception("O Desconto só pode ser aplicado uma vez.");
            }            
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em Análise não poder ser Finalizado.");
        }

    }
}