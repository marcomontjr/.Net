using System;
using System.Collections.Generic;

namespace Builder
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemNota> Itens { get; set; }
        public String Observacoes { get; set; }

        public NotaFiscal(String razaoSocial
                        , String cnpj                        
                        , double valBruto
                        , double impostos
                        , IList<ItemNota> itens
                        , String obs
                        , DateTime dataEmissao)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;            
            ValBruto = valBruto;
            Impostos = impostos;
            Itens = itens;
            Observacoes = obs;
            DataEmissao = dataEmissao;
        }
    }
}