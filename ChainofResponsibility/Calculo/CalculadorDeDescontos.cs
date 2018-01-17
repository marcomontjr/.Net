using ChainofResponsibility.Descontos;

namespace ChainofResponsibility.Calculo
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPor5Itens();
            IDesconto d2 = new DescontoPorMais500Reais();
            IDesconto d3 = new DecontoLapisCaneta();
            IDesconto d4 = new SemDesconto();           

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);
        }
    }
}
