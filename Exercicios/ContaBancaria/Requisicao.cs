namespace Exercicios.ContaBancaria
{
    public enum Formato
    {
        XML,
        CSV,
        Porcento,
        FormatoInvalido
    }
    public class Requisicao
    {
        public Formato Formato { get; set; }
        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }
}