using System.Xml.Serialization;
using System.Xml;

namespace ChainsOfResponsabilityRequisicaoWeb
{
    internal class CSV : IResposta
    {
        public IResposta Proximo { get; set; }

        public string Converte(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                return $"{conta.Nome};{conta.Saldo}";
            }

            return Proximo.Converte(requisicao, conta);
        }
    }
}