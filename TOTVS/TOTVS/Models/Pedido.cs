using System;
using System.Collections.Generic;

namespace TOTVS.Models
{
    public class Pedido
    {
        public int ID { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }

        public ICollection<ProdutosDoPedido> ProdutosDoPedidos { get; set; }
    }
}