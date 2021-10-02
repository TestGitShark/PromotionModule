using System;
using System.Collections.Generic;

namespace PromotionModule
{
    public class SampleDataLoader
    {
       public static List<ProductUnitPrice> LoadUnitPriceList()
        {    
                List<ProductUnitPrice> productUnitPrices = new List<ProductUnitPrice>
            {
                new ProductUnitPrice { ProductId = 'A', UnitPrice = 100M },
                new ProductUnitPrice { ProductId = 'B', UnitPrice = 50M },
                new ProductUnitPrice { ProductId = 'C', UnitPrice = 25M },
                new ProductUnitPrice { ProductId = 'D', UnitPrice = 15M },
                new ProductUnitPrice { ProductId = 'E', UnitPrice = 10M },
                new ProductUnitPrice { ProductId = 'F', UnitPrice = 30M }
            };

                return productUnitPrices;
            
        }


        public static ShoppingCart LoadShoppingCart()
        {
            


            ShoppingCart cart = new ShoppingCart();
            cart.Items.Add(new CartItem { ProductId = 'A', Count = 5 });
            cart.Items.Add(new CartItem { ProductId = 'B', Count = 3 });
            cart.Items.Add(new CartItem { ProductId = 'C', Count = 2});
            cart.Items.Add(new CartItem { ProductId = 'D', Count =2});
            cart.Items.Add(new CartItem { ProductId = 'E', Count = 1 });
            return cart;

        }


        public static List<IPromotion> LoadPromotions()
        {
          
            List<IPromotion> promotions = new List<IPromotion>
                                                { new SingleProductPromotions{ IsPromotionActive = true, ProductCount = 3, PromotionProductId = 'A', PromotionPrice = 250 },
                                                  new SingleProductPromotions { IsPromotionActive = true, ProductCount = 2, PromotionProductId = 'B', PromotionPrice = 75  },
                                                  new SingleProductPromotions { IsPromotionActive = true, ProductCount = 2, PromotionProductId = 'C', PromotionPrice = 40 },
                                                  new DuoComboPromotion  { ProductIdOne= 'D',ProductIdTwo ='E' , CombinationPrice=20,IsPromotionActive=true } 

                                        };


            return promotions;

        }

    }
}
//{ }