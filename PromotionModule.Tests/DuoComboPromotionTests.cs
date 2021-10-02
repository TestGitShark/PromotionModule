using System;
using PromotionModule;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace PromotionModule.Tests
{
    public class DuoComboPromotionTests
    {
        [Theory]
        [ClassData (typeof(DuoComboPromotionTestData))]
        public void ApplyPromotion_GetPriceAfterPromotion(List<ProductUnitPrice> productUnitPrices, List<CartItem> cartItems,DuoComboPromotion comboPromotion,  decimal expectedPrice)
        {
            //Arrange
           

            ShoppingCart cart = new ShoppingCart();
            foreach(CartItem cartItem in cartItems)
            {
                cart.Items.Add(cartItem);
            }

            //Act
            comboPromotion.ApplyPromotion(cart, productUnitPrices);

           
            Decimal calculatedPrice = (cart.Items.Where((x => x.ProductId == 'D' || x.ProductId == 'E')).ToList()).Sum(s => s.FinalPrice);

            //Assert

            Assert.Equal(expectedPrice, calculatedPrice);
        }



    }
}
//[]

//{}
