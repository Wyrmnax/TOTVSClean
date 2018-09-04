using System.Collections.Generic;

namespace TOTVS.Models.ViewModels
{
    public class CompraVM
    {
        public Pedido Pedido { get; set; }
        public List<ProdutosDoPedido> ListaProdutosDoPedido { get; set; }
        public ICollection<Produto> ListaProdutos { get; set; }
    }
}