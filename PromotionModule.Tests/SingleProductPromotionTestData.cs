using System;
using System.Collections;
using System.Collections.Generic;

namespace PromotionModule.Tests
{
    public class SingleProductPromotionTestData : IEnumerable, IEnumerable<object[]>
    {

        private static List<ProductUnitPrice> productUnitPrices = new List<ProductUnitPrice>
            {
                new ProductUnitPrice { ProductId = 'A', UnitPrice = 100M },
                new ProductUnitPrice { ProductId = 'B', UnitPrice = 50M },
                new ProductUnitPrice { ProductId = 'C', UnitPrice = 25M },
                new ProductUnitPrice { ProductId = 'D', UnitPrice = 15M },
                new ProductUnitPrice { ProductId = 'E', UnitPrice = 10M },
                new ProductUnitPrice { ProductId = 'F', UnitPrice = 30M }
            };

        private static List<CartItem> cart = new List<CartItem>
            {
               new CartItem { ProductId = 'A', Count = 5 },
               new CartItem { ProductId = 'B', Count = 3 },
               new CartItem { ProductId = 'C', Count = 2},
               new CartItem { ProductId = 'D', Count =2},
               new CartItem { ProductId = 'E', Count = 1 }

            };

        private static SingleProductPromotions singleProductPromotion1 = new SingleProductPromotions { IsPromotionActive = true, ProductCount = 3, PromotionProductId = 'A', PromotionPrice = 250 };
        private static SingleProductPromotions singleProductPromotion2 = new SingleProductPromotions { IsPromotionActive = true, ProductCount = 2, PromotionProductId = 'B', PromotionPrice = 75 };
        private static SingleProductPromotions singleProductPromotion3 = new SingleProductPromotions { IsPromotionActive = true, ProductCount = 2, PromotionProductId = 'C', PromotionPrice = 40 };

        private readonly List<object[]> testData = new List<object[]>
        {
            new object[]{ productUnitPrices ,cart, singleProductPromotion1, 450},
            new object[]{ productUnitPrices ,cart, singleProductPromotion2, 125},
            new object[]{ productUnitPrices ,cart, singleProductPromotion3, 40}

        };


        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator<object[]> IEnumerable<object[]>.GetEnumerator()
        {
            return this.testData.GetEnumerator();
        }
    }
}
