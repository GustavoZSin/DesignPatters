using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsabilityRequisicaoWeb
{
    public interface IResposta
    {
        public IResposta Proximo { get; set; }
        public string Converte(Requisicao requisicao, Conta conta);
    }
}
