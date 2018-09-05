using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TOTVS.Data;
using TOTVS.Models;
using TOTVS.Models.ViewModels;

namespace TOTVS.Controllers
{
    public class ComprasController : Controller
    {
        private readonly TOTVSContext _context;

        public ComprasController(TOTVSContext context)
        {
            _context = context;
        }

        // GET: Compras
        [Route("index")]
        public IActionResult Index()
        {
            //var cart = SessionHelper.GetObjectFromJson<List<Produto>>(HttpContext.Session, "cart");

            var compraVM = new CompraVM() { ListaProdutosDoPedido = new List<ProdutosDoPedido>() };
            //Inicializando para nao ter um pedido nulo
            var pedido = new Pedido() { DataPedido = DateTime.Now, ValorTotal = 0 };

            var mockProdutosPedido = _context.ProdutosDoPedidos
                .Include(p => p.Produto)
                .FirstOrDefault(c => c.ID == 1);
            //compraVM.ListaProdutosDoPedido.Add(mockProdutosPedido);

            compraVM.ListaProdutos = _context.Produtos.ToList();
            //pedido = _context.Pedidos.Select(x => x.ID == id);

            compraVM.Pedido = pedido;
            return View(compraVM);
        }
    }
}