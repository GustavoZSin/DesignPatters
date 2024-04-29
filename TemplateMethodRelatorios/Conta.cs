namespace TemplateMethodRelatorios
{
    public class Conta
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public string Agencia { get; private set; }
        public string NumeroDaConta { get; private set; }
        public Conta(string titular, double saldo, string agencia, string numeroDaConta)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            this.Agencia = agencia;
            this.NumeroDaConta = numeroDaConta;
        }
        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
    }
}