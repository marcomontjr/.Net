using System.Collections.Generic;

namespace ChainofResponsibility
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            itens = new List<Item>();
        }       
        
        public void AdicionaItem(Item item)
        {
            itens.Add(item);
        }
    }
}
