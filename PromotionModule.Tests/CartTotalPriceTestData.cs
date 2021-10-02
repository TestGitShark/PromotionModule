using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PromotionModule;

namespace PromotionModule.Tests
{
    public class CartTotalPriceTestData : IEnumerable, IEnumerable<object[]>
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
               new CartItem { ProductId = 'A', Count = 1 },
               new CartItem { ProductId = 'B', Count = 3 },
               new CartItem { ProductId = 'C', Count = 2}
              

            };
        private readonly List<object[]> testData = new List<object[]>
        {
            new object[]{ productUnitPrices ,cart, 300}
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
