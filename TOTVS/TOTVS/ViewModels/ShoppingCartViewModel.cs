using System.Collections.Generic;
using TOTVS.Models;

namespace TOTVS.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}