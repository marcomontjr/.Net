namespace Observer
{
    public class ItemNotaBuilder
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public ItemNota CriaItem()
        {
            return new ItemNota(Nome, Valor);
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