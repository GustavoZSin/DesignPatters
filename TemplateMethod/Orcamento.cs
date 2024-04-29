
namespace TemplateMethod
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens;
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }
        public Orcamento()
        {
            this.Valor = 0;
            this.Itens = new List<Item>();
        }
        public void Adiciona(Item item)
        {
            Itens.Add(item);
            this.Valor += item.Valor;
        }
    }
}
