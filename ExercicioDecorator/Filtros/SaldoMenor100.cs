using System.Collections.Generic;

namespace ExercicioDecorator.Filtros
{
    class SaldoMenor100 : Filtro
    {
        public SaldoMenor100(Filtro outroFiltro) : base(outroFiltro) { }
        public SaldoMenor100() : base() { }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (var item in contas)
            {
                if (item.Saldo < 100) filtrada.Add(item);                
            }

            foreach (var item in Proximo(contas))
            {
                filtrada.Add(item);
            }
            return filtrada;
        }     
    }
}