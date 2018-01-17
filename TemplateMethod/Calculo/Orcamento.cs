using System.Collections.Generic;

namespace TemplateMethod
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }   
        
        public void AdiocionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
