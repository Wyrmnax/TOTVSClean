using System.Linq;
using TOTVS.Models;

namespace TOTVS.Data
{
    public class SeedData
    {
        public static class DbInitializer
        {
            public static void Initialize(TOTVSContext context)
            {
                context.Database.EnsureCreated();

                // Look for any students.
                if (context.Produtos.Any())
                {
                    return;   // DB has been seeded
                }

                var produtos = new Produto[]
                {
            new Produto{Descricao="Uno",ValorIndividual=15},
            new Produto{Descricao="Coelho",ValorIndividual=20},
            new Produto{Descricao="Celular",ValorIndividual=55},
            new Produto{Descricao="Paciencia",ValorIndividual=13}
                };
                foreach (Produto p in produtos)
                {
                    context.Produtos.Add(p);
                }
                context.SaveChanges();

                /* var courses = new Pedido[]
                 {
             new Pedido{ValorTotal=1050,DataPedido=new DateTime(2017,1,18)},
             new Pedido{ValorTotal=4022,DataPedido=new DateTime(2018,2,18)},
             new Pedido{ValorTotal=4041,DataPedido=new DateTime(2017,1,13)}
                 };
                 foreach (Pedido p in courses)
                 {
                     context.Pedidos.Add(p);
                 }
                 context.SaveChanges();

                 var produtosPedidos = new ProdutosDoPedido[]
                 {
             new ProdutosDoPedido{Quantidade=1,Produto=1050,Grade=Grade.A},
             new ProdutosDoPedido{Quantidade=1,Produto=4022,Grade=Grade.C},
             new ProdutosDoPedido{Quantidade=1,Produto=4041,Grade=Grade.B},
             new ProdutosDoPedido{Quantidade=2,Produto=1045,Grade=Grade.B},
             new ProdutosDoPedido{Quantidade=2,Produto=3141,Grade=Grade.F},
             new ProdutosDoPedido{Quantidade=2,Produto=2021,Grade=Grade.F},
                 };
                 foreach (ProdutosDoPedido e in produtosPedidos)
                 {
                     context.ProdutosDoPedidos.Add(e);
                 }
                 context.SaveChanges();*/
            }
        }
    }
}