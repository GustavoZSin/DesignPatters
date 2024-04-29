namespace TemplateMethodRelatorios
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Relatório Simples:");
            Console.WriteLine("Banco ABCD");
            Console.WriteLine("--------------------------------------------------------------");
        }
        protected override void Corpo(List<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine("Titular:" + conta.Titular);
                Console.WriteLine("Saldo: R$" + conta.Saldo);
                Console.WriteLine("--------------------------------------------------------------");
            }
        }
        protected override void Rodape()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("(99) 99999-9999");
        }
    }
}
