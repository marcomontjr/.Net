namespace State.Interfaces
{
    interface IEstado
    {
        void AplicaDescontoExtra(Orcamento orcamento);

        //Aqui colocamos os estados dos orçamentos para garantir as transições
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}