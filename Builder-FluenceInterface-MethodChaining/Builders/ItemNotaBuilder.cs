namespace Builder_FluenceInterface_MethodChaining.Builders
{
    public class ItemNotaBuilder
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Builder.ItemNota CriaItem()
        {
            return new Builder.ItemNota(Nome, Valor);
        }

        public ItemNotaBuilder AtribuiNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ItemNotaBuilder AtribuiValor(double valor)
        {
            Valor = valor;
            return this;
        }
    }
}