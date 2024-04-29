namespace ChainsOfResponsabilityRequisicaoWeb
{
    internal class Porcento : IResposta
    {
        public IResposta Proximo { get; set; }

        public string Converte(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                return $"{conta.Nome}%{conta.Saldo}";
            }

            return Proximo.Converte(requisicao, conta);
        }
    }
}