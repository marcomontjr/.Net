namespace Decorator
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto) : base(outroImposto){ }
        public ICCC() : base() { }
        public override double Calcula(Orcamento orcamento)
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