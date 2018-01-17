namespace ChainofResponsibility.Descontos
{
    public class DescontoPor5Itens : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.itens.Count >= 5) 
                return orcamento.Valor * 0.1;

            return Proximo.Desconta(orcamento);           
        }        
    }
}
