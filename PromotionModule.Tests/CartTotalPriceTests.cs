using System;
using PromotionModule;
using System.Collections.Generic;
using Xunit;
using System.Linq;


namespace PromotionModule.Tests
{
    public class CartTotalPriceTests
    {
        [Theory]
        [ClassData(typeof(CartTotalPriceTestData))]
        public void CartTotalPrice_GetTotalPrice(List<ProductUnitPrice> productUnitPrices, List<CartItem> cartItems,decimal expectedTotalPrice)

        {
            //Arrange
            ShoppingCart cart = new ShoppingCart();
            foreach (CartItem cartItem in cartItems)
            {
                cart.Items.Add(cartItem);
            }
            //Act
            decimal calculatedTotalPrice=cart.CartTotalPrice(productUnitPrices);

            //Assert
            Assert.Equal(expectedTotalPrice, calculatedTotalPrice);

        }
    }
}
