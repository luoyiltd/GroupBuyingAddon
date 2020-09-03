using System.Collections.Generic;
using Foundation;

namespace GroupBuyingOrder.Model
{
    public class Order : NSObject
    {
        #region Constants

        private const string NotApplicable = "N/A";

        #endregion

        public List<Order> OrderList = new List<Order>();

        public Order()
        {

        }

        #region Properties

        public string ProductName { get; set; } = NotApplicable;

        public decimal ProductCost { get; set; } = -1;

        public decimal ProductSalePrice { get; set; } = -1;

        public decimal ProductActualPrice { get; set; } = -1;

        public int ProductQuantity { get; set; } = -1;

        public bool IsGroup
        {
            get { return (OrderList.Count > 0); }
        }
        #endregion
    }
}