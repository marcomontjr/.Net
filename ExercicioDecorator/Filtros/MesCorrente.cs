using System;
using System.Collections.Generic;

namespace ExercicioDecorator.Filtros
{
    class MesCorrente : Filtro
    {
        public MesCorrente(Filtro outroFiltro) : base(outroFiltro) { }
        public MesCorrente() : base() { }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            DateTime mesAtual = new DateTime();
            foreach (var item in contas)
            {
                if (item.DataAbertura.Month == mesAtual.Month) filtrada.Add(item);                    
            }

            foreach (var item in Proximo(contas))
            {
                filtrada.Add(item);
            }

            return filtrada;
        }
    }
}