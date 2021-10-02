using System;
using System.Collections.Generic;
// Promotions like A + B together for a fixed price 
namespace PromotionModule
{
    public class DuoComboPromotion : IPromotion
    {
        public char ProductIdOne { get; set; }
        public char ProductIdTwo { get; set; }
        public decimal  CombinationPrice { get; set; }
        public bool IsPromotionActive { get; set; }

        public void ApplyPromotion(ShoppingCart shoppingCart, List<ProductUnitPrice> unitPriceList)
        {
            if (IsPromotionActive)
            {
                CartItem cartItemOne = shoppingCart.Items.Find(x => x.ProductId == ProductIdOne);
                CartItem cartItemTwo = shoppingCart.Items.Find(x => x.ProductId == ProductIdTwo);

                //If both the promotional products exists in the shopping cart
                if(cartItemOne!=null && cartItemTwo!=null )
                {
                    decimal unitPrice = 0M;
                    if (!cartItemOne.PromotionApplied && !cartItemTwo.PromotionApplied)
                    {      
                       if(cartItemOne.Count==cartItemTwo.Count)
                        {
                            cartItemOne.FinalPrice = cartItemOne.Count * CombinationPrice;
                            cartItemTwo.FinalPrice = 0M;// combinational price added to cartItem 1
                           

                        }
                       else if(cartItemOne.Count > cartItemTwo.Count)
                        {
                             unitPrice = unitPriceList.Find(x => x.ProductId == cartItemOne.ProductId).UnitPrice;
                            cartItemTwo.FinalPrice = cartItemTwo.Count * CombinationPrice;
                            cartItemOne.FinalPrice = (cartItemOne.Count - cartItemTwo.Count) * unitPrice;
                           
                        }
                       else
                        {
                            unitPrice = unitPriceList.Find(x => x.ProductId == cartItemTwo.ProductId).UnitPrice;
                            cartItemOne.FinalPrice = cartItemOne.Count * CombinationPrice;
                            cartItemTwo.FinalPrice = (cartItemTwo.Count - cartItemOne.Count) * unitPrice;

                        }
                        cartItemOne.PromotionApplied = true;
                        cartItemTwo.PromotionApplied = true;

                        MessageService.WriteMessage($"Combination Promotion applied.Price after Promotion {ProductIdOne} - " +
                            $"{ cartItemOne.FinalPrice},  {ProductIdTwo}  {cartItemTwo.FinalPrice} - ");
                        

                    }

                }
            }
        }
    }
}
//{}
