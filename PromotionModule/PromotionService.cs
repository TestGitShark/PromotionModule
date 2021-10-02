using System;
using System.Collections.Generic;

namespace PromotionModule
{
    public class PromotionService:IPromotionService
    {
       public List<IPromotion> Promotions { get; set; } = new List<IPromotion>();

        public void ApplyPromotion(ShoppingCart shoppingCart, List<ProductUnitPrice> unitPriceList)
        {
            foreach(IPromotion promotion in Promotions)
            {
                promotion.ApplyPromotion(shoppingCart, unitPriceList);
            }

        }
    }
}

//{}
