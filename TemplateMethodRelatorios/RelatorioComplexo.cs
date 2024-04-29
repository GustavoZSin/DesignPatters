namespace TemplateMethodRelatorios
{
    internal class RelatorioComplexo : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Relatório Complexo:");
            Console.WriteLine("Banco ABCD");
            Console.WriteLine("Avenida Rio Branco, Bairro Centro, Caxias do Sul - RS/Brasil");
            Console.WriteLine("(54) 99999-9999");
            Console.WriteLine("--------------------------------------------------------------");
        }
        protected override void Corpo(List<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine("Titular:" + conta.Titular);
                Console.WriteLine("Agência:" + conta.Agencia);
                Console.WriteLine("Número da Conta:" + conta.NumeroDaConta);
                Console.WriteLine("Saldo: R$" + conta.Saldo);
                Console.WriteLine("--------------------------------------------------------------");
            }
        }
        protected override void Rodape()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("banco1@abcd.com.br");
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm"));
        }
    }
}
