using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionModule
{
    public class ShoppingCart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public decimal CartTotalPrice(List<ProductUnitPrice> productUnitPrices)
        {

            foreach(CartItem cartItem in Items)
            {
                if(!cartItem.PromotionApplied)
                {

                    cartItem.FinalPrice = cartItem.Count * (productUnitPrices.Find(x => x.ProductId == cartItem.ProductId).UnitPrice);
                }

            }

            return (Items.Sum(x => x.FinalPrice));
        }


    }
}
//{}



