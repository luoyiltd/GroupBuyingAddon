using System;
using AppKit;
using Foundation;
using GroupBuyingOrder.Model;

namespace GroupBuyingAddon.GroupBuyingOrder
{
    public class OrderOutlineDelegate : NSOutlineViewDelegate
    {
        private const string CellIdentifier = "OrderCell";
        private OrderDataSource DataSource;

        public OrderOutlineDelegate(OrderDataSource DataSource)
        {
            this.DataSource = DataSource;
        }

        #region Override Methods

        public override NSView GetView(NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
        {
            // This pattern allows you reuse existing views when they are no-longer in use.
            // If the returned view is null, you instance up a new view
            // If a non-null view is returned, you modify it enough to reflect the new data
            NSTextField view = (NSTextField)outlineView.MakeView(CellIdentifier, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
            }

            // Cast item
            var order = item as Order;

            // Setup view based on the column selected
            switch (tableColumn.Title)
            {
                case "Product Name":
                    view.StringValue = order.ProductName;
                    break;
                case "Cost":
                    view.StringValue = order.ProductCost.ToString();
                    break;
                case "Sale Price":
                    view.StringValue = order.ProductSalePrice.ToString();
                    break;
                case "Actual Price":
                    view.StringValue = order.ProductActualPrice.ToString();
                    break;
                case "Quantity":
                    view.StringValue = order.ProductQuantity.ToString();
                    break;
            }

            return view;
        }
        #endregion
    }
}
