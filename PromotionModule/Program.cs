using System;
using System.Collections.Generic;

namespace PromotionModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<ProductUnitPrice> productUnitPriceList = SampleDataLoader.LoadUnitPriceList();
            ShoppingCart shoppingCart = SampleDataLoader.LoadShoppingCart();
            //List<IPromotion> promotions = SampleDataLoader.LoadPromotions();

            PromotionService promotionService = new PromotionService();
            promotionService.Promotions= SampleDataLoader.LoadPromotions();

            promotionService.ApplyPromotion(shoppingCart, productUnitPriceList);
            MessageService.WriteMessage($"Shopping Cart Total is {shoppingCart.CartTotalPrice(productUnitPriceList)}"); 

        }
    }
}
