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
                new Order
                {
                    ProductName = "8月订单", ProductCost = 21, ProductSalePrice = 25, ProductActualPrice = 23, ProductQuantity = 2,
                    OrderList = new List<Order>
                    {
                        new Order {ProductName = "彩虹积木", ProductCost = 210, ProductSalePrice = 250, ProductActualPrice = 230, ProductQuantity = 20}
                    }
                },
                new Order { ProductName = "9月订单", ProductCost = 11, ProductSalePrice = 15, ProductActualPrice = 13, ProductQuantity = 1 },
                new Order
                {
                    ProductName = "10月订单", ProductCost = 31, ProductSalePrice = 35, ProductActualPrice = 33, ProductQuantity = 23,
                    OrderList = new List<Order>
                    {
                        new Order {ProductName = "攀爬架", ProductCost = 211, ProductSalePrice = 251, ProductActualPrice = 231, ProductQuantity = 21},
                        new Order {ProductName = "陶瓷碗", ProductCost = 212, ProductSalePrice = 252, ProductActualPrice = 232, ProductQuantity = 22}
                    }
                }
            };


        }
    }
}