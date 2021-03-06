﻿using State.Interfaces;
using System;

namespace State.Estados
{
    class Aprovado : IEstado
    {
        bool descontoApenasUmaVez;
        public Aprovado()
        {
            descontoApenasUmaVez = true;
        }
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (descontoApenasUmaVez)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoApenasUmaVez = false;
            }
            else
            {
                throw new Exception("O Desconto só pode ser aplicado uma vez.");
            }      
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