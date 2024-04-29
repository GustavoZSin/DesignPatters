using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsability
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe("CANETA", orcamento) && Existe("LAPIS", orcamento))
            {
                Console.WriteLine("Aplicado desconto por venda casada...");
                return orcamento.Total * 0.05;
            }

            return Proximo.Desconta(orcamento);
        }
        public bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (nomeDoItem.ToUpper().Equals(item.Nome.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
