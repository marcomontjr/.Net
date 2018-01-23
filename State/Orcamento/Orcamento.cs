using State.Estados;
using State.Interfaces;
using System.Collections.Generic;

namespace State
{
    class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> itens { get; private set; }
        public IEstado EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }     

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}