using System;
using System.Collections.Generic;

namespace PromotionModule
{
    public interface IPromotionService
    {
      
        public void ApplyPromotion(ShoppingCart shoppingCart, List<ProductUnitPrice> unitPriceList);
    }
}
