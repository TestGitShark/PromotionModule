using System;
using System.Collections.Generic;

namespace PromotionModule
{
    public interface IPromotion
    {
        public bool IsPromotionActive { get; set; }
        public void ApplyPromotion(ShoppingCart shoppingCart, List<ProductUnitPrice> unitPriceList);

    }
}
