using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PromotionModule;


namespace PromotionModule.Tests
{
    public class DuoComboPromotionTestData : IEnumerable, IEnumerable<object[]>
    {

       private static  List<ProductUnitPrice> productUnitPrices = new List<ProductUnitPrice>
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



        
//private static   List<IPromotion> promotions = new List<IPromotion>
//                                           { new SingleProductPromotions{ IsPromotionActive = true, ProductCount = 3, PromotionProductId = 'A', PromotionPrice = 250 },
//                                             new SingleProductPromotions { IsPromotionActive = true, ProductCount = 2, PromotionProductId = 'B', PromotionPrice = 75  },
//                                             new SingleProductPromotions { IsPromotionActive = true, ProductCount = 2, PromotionProductId = 'C', PromotionPrice = 40 },
//                                             new DuoComboPromotion  { ProductIdOne= 'D',ProductIdTwo ='E' , CombinationPrice=20,IsPromotionActive=true }

//                                   };




private static readonly DuoComboPromotion comboPromotion = new DuoComboPromotion { ProductIdOne = 'D', ProductIdTwo = 'E', CombinationPrice = 20, IsPromotionActive = true };

        private readonly List<object[]> testData = new List<object[]>
        {
            new object[]{ productUnitPrices ,cart, comboPromotion, 35}
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return this.testData.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
   

}

   

//[]

//{}
