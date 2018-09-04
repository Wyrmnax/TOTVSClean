namespace TOTVS.Models
{
    public class ProdutosDoPedido
    {
        public int ID { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}