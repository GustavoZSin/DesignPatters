namespace ChainsOfResponsabilityRequisicaoWeb
{
    internal class SemFormato : IResposta
    {
        public IResposta Proximo { get; set; }

        public string Converte(Requisicao requisicao, Conta conta)
        {
            return "Formato inválido";
        }
    }
}