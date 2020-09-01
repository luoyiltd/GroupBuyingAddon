using System.Collections.Generic;
using GroupBuyingOrder.Model;

namespace GroupBuyingOrder.ViewModel
{
    public class GroupBuyingOrderViewModel
    {
        public List<Order> OrderList { get; set; }

        public GroupBuyingOrderViewModel()
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            OrderList = new List<Order>
            {
                new Order { ProductName = "OneName", ProductCost = 21, ProductSalePrice = 25, ProductActualPrice = 23, ProductQuantity = 2 },
                new Order { ProductName = "TwoName", ProductCost = 11, ProductSalePrice = 15, ProductActualPrice = 13, ProductQuantity = 1 },
                new Order { ProductName = "ThreeName", ProductCost = 31, ProductSalePrice = 35, ProductActualPrice = 33, ProductQuantity = 23 }
            };
        }
    }
}