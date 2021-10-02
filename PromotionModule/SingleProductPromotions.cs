using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionModule
{
    public class SingleProductPromotions:IPromotion
    {
        public char PromotionProductId { get; set; }
        public int ProductCount { get; set; }
        public decimal PromotionPrice { get; set; }
        public bool IsPromotionActive { get; set; }

        public void ApplyPromotion(ShoppingCart shoppingCart, List<ProductUnitPrice> unitPriceList)
        {

            if(IsPromotionActive)
            {
                CartItem cartItem =shoppingCart.Items.Find(x => x.ProductId == PromotionProductId);
            
                if (cartItem!=null && !cartItem.PromotionApplied )
                {
                    decimal unitPrice = unitPriceList.Find(x => x.ProductId == cartItem.ProductId).UnitPrice;
                   
                     cartItem.FinalPrice = (int)(cartItem.Count / ProductCount) * PromotionPrice +
                           (cartItem.Count % ProductCount) * unitPrice;
                      cartItem.PromotionApplied = true;
                       MessageService.WriteMessage($"Promotion applied on {cartItem.ProductId}- " +
                          $"original price {cartItem.Count * unitPrice} promotional price {cartItem.FinalPrice}");

                }


                //else some promotion already applied & only one promotion per product


            }     //or this promtional product is not in the cart
        }
        //else this promotion is no longer active
        
    }
}
