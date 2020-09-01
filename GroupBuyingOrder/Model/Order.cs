﻿namespace GroupBuyingOrder.Model
{
    public class Order
    {
        public string ProductName { get; set; }

        public decimal ProductCost { get; set; }

        public decimal ProductSalePrice { get; set; }

        public decimal ProductActualPrice { get; set; }

        public int ProductQuantity { get; set; }

    }
}