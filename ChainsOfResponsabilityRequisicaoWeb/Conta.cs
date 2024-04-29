using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsabilityRequisicaoWeb
{
    public class Conta
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public Conta()
        {
            this.Nome = string.Empty;
            this.Saldo = 0;
        }
        public Conta(string nome, double saldo)
        {
            this.Nome = nome;
            this.Saldo = saldo;
        }
        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
    }
}
