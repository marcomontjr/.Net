using System.Collections.Generic;

namespace ExercicioDecorator.Filtros
{
    class SaldoMaior500Mil : Filtro
    {
        public SaldoMaior500Mil(Filtro outroFiltro) : base(outroFiltro) { }
        public SaldoMaior500Mil() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (var item in contas)
            {
                if (item.Saldo > 500000) filtrada.Add(item);  
            }

            foreach (var item in Proximo(contas))
            {
                filtrada.Add(item);
            }
            return filtrada;
        }
    }
}