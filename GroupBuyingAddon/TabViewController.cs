using System;

using AppKit;
using Foundation;
using GroupBuyingAddon.GroupBuyingOrder;
using GroupBuyingOrder.ViewModel;

namespace GroupBuyingAddon
{
    public partial class TabViewController : NSViewController
    {
        private readonly GroupBuyingOrderViewModel OrderViewModel;

        public TabViewController(IntPtr handle) : base(handle)
        {
            OrderViewModel = new GroupBuyingOrderViewModel();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.

            LoadOrders();
        }

        private void LoadOrders()
        {
            // Create data source and populate
            var DataSource = new OrderDataSource();

            DataSource.OrderList = OrderViewModel.OrderList;

            if(ProductOrder != null)
            {
                ProductOrder.DataSource = DataSource;
                ProductOrder.Delegate = new OrderOutlineDelegate(DataSource);
            }
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
