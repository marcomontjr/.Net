namespace ChainofResponsibility.Descontos
{
    public class DecontoLapisCaneta : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {           
            foreach (var item in orcamento.itens)
            {
                if (item.Nome.Equals("Lápis"))
                {
                    foreach (var item2 in orcamento.itens)
                    {
                        if (item2.Nome.Equals("Caneta"))
                        {
                            return orcamento.Valor * 0.05;
                        }
                    }
                }            
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
