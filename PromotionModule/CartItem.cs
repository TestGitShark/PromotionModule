using System;
namespace PromotionModule
{
   
        public class CartItem
        {
            public char ProductId { get; set; }
            public int Count { get; set; }
        public bool PromotionApplied { get; set; } = false;
        public decimal FinalPrice { get; set; } = 0;
        }
   
}
