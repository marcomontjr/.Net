namespace Strategy
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double valImposto;
            if (orcamento.Valor < 1000)
                return valImposto = orcamento.Valor * 0.05;
            else if(orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                return valImposto = orcamento.Valor * 0.07;
            else
                return valImposto = orcamento.Valor * 0.08 + 30;
        }
    }
}
