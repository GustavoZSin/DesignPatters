namespace ChainsOfResponsability
{
    public class Orcamento
    {
        public List<Item> Itens;
        public double Total;
        public Orcamento()
        {
            Itens = new List<Item>();
        }
        public void Adiciona(Item item)
        {
            Itens.Add(item);
            this.Total += item.Valor;
        }
    }
}