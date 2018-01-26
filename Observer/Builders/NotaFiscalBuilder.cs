using System;
using System.Collections.Generic;

namespace Observer
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime /*Calendar*/ Data { get; private set; }

        private IList<AcaoAposGerarNota> todasAcosASeremExecutadas = new List<AcaoAposGerarNota>();

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, valorTotal, impostos, todosItens, Observacoes,
                Data.GetHashCode() == 0 ? Data = DateTime.Now : Data);

            foreach (AcaoAposGerarNota acao in todasAcosASeremExecutadas)
            {
                acao.Executa(nf);
            }            
            return nf;
        } 

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            todasAcosASeremExecutadas.Add(novaAcao);
        }

        /*Outra opção para resolver o problema da data opcional seria setar no construtor.
         * Com isso retirar a lógica na passagem de parâmetros e apenas passar a data.
        public NotaFiscalBuilder()
        {
            Data = DateTime.Now;
        
        }*/

        public NotaFiscalBuilder ComObservacoes(string obs)
        {
            Observacoes = obs;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            Data = data;            
            return this;
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        private double valorTotal;
        private double impostos;
        private IList<ItemNota> todosItens = new List<ItemNota>();

        public NotaFiscalBuilder ComItem(ItemNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos = valorTotal * 0.05;
            return this;
        }
    }
}