using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsabilityRequisicaoWeb
{
    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }
        public string Executa(Conta conta)
        {
            IResposta xml = new XML();
            IResposta csv = new CSV();
            IResposta porcento = new Porcento();
            IResposta semFormato = new SemFormato();

            xml.Proximo = csv;
            csv.Proximo = porcento;
            porcento.Proximo = semFormato;

            return xml.Converte(this, conta);
        }
    }
}
