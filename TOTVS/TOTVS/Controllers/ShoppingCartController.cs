using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TOTVS.Data;
using TOTVS.Models;
using TOTVS.ViewModels;

namespace TOTVS.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly TOTVSContext _context;

        public ShoppingCartController(TOTVSContext context)
        {
            _context = context;
        }

        //
        // GET: /ShoppingCart/
        public ActionResult Index(string cartId)
        {
            var cart = _context.Carts.Include(x => x.Album).Where(x => x.CartId == cartId).ToList();

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart//,
                //CartTotal = cart.GetTotal()
            };
            // Return the view
            return View(viewModel);
        }

        //
        // GET: /Store/AddToCart/5
        public ActionResult AddToCart(int id)
        {
            // Retrieve the album from the database
            var addedAlbum = _context.Albums
                .Single(album => album.AlbumId == id);

            var aaaa = this.ControllerContext.ToString();
            var bbbb = _context.Carts.FirstOrDefault();

            var cart = new Cart() { };
            cart.AlbumId = id;
            cart.Album = addedAlbum;
            cart.DateCreated = DateTime.Now;
            cart.Count = cart.Count++;

            _context.Carts.Add(cart);

            _context.SaveChanges();

            // Add it to the shopping cart
            //var cart = ShoppingCart.GetCart(_context);

            //cart.AddToCart(addedAlbum);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }

        //
        // AJAX: /ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            // Remove the item from the cart
            var cart = ShoppingCart.GetCart(_context);

            // Get the name of the album to display confirmation
            string albumName = _context.Carts
                .Single(item => item.RecordId == id).Album.Title;

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            // Display the confirmation message
            var results = new ShoppingCartRemoveViewModel
            {
                Message = _context.Albums.FirstOrDefault() +
                    " Foi removido do seu carrinho.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }

        //
        // GET: /ShoppingCart/CartSummary
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(_context);

            ViewData["CartCount"] = cart.GetCount();
            return PartialView("CartSummary");
        }
    }
}