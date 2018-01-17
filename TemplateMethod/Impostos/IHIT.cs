using System.Collections.Generic;
using TemplateMethod.Templates;

namespace TemplateMethod.Impostos
{
    public class IHIT :  TImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {        
            var myList = new List<string>();
            var duplicates = new List<string>();            

            foreach (var item in orcamento.Itens)
            {
                if (!myList.Contains(item.ToString()))
                    myList.Add(item.ToString());
                else
                    duplicates.Add(item.ToString());
            }

            return duplicates.Count > 0;                       
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count;
        }
    }
}