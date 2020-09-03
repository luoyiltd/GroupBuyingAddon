using System;
using System.Collections.Generic;
using AppKit;
using Foundation;
using GroupBuyingOrder.Model;

namespace GroupBuyingAddon.GroupBuyingOrder
{
    public class OrderDataSource : NSOutlineViewDataSource
    {
        public List<Order> OrderList = new List<Order>();

        public OrderDataSource()
        {
        }

        #region Override Methods
        public override nint GetChildrenCount(NSOutlineView outlineView, NSObject item)
        {
            if (item == null)
            {
                return OrderList.Count;
            }
            else
            {
                return ((Order)item).OrderList.Count;
            }

        }

        public override NSObject GetChild(NSOutlineView outlineView, nint childIndex, NSObject item)
        {
            var index = Convert.ToInt32(childIndex.ToString());

            if (item == null)
            {
                return OrderList[index];
            }
            else
            {
                return ((Order)item).OrderList[index];
            }

        }

        public override bool ItemExpandable(NSOutlineView outlineView, NSObject item)
        {
            if (item == null)
            {
                return OrderList[0].IsGroup;
            }
            else
            {
                return ((Order)item).IsGroup;
            }

        }
        #endregion
    }
}
