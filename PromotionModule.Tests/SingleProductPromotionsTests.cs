using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using PromotionModule;

namespace PromotionModule.Tests
{
    public class SingleProductPromotionsTests
    {
        [Theory]
        [ClassData(typeof(SingleProductPromotionTestData))]
        public void SingleProductPromotion_ApplyPromotion_GetPriceAfterPromotion(List<ProductUnitPrice> productUnitPrices, List<CartItem> cartItems, SingleProductPromotions singleProductPromotion,decimal expectedPrice)
        {

            //Arrange
            ShoppingCart cart = new ShoppingCart();
            foreach (CartItem cartItem in cartItems)
            {
                cart.Items.Add(cartItem);
            }
            //Act

            singleProductPromotion.ApplyPromotion(cart, productUnitPrices);


            //Assert

            CartItem item =cart.Items.Find (x => x.ProductId == singleProductPromotion.PromotionProductId);

            Assert.Equal(expectedPrice, item.FinalPrice);
        }


    }
}
//[]

//{}
