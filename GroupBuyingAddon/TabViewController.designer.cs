// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace GroupBuyingAddon
{
	[Register ("TabViewController")]
	partial class TabViewController
	{
		[Outlet]
		AppKit.NSOutlineView ProductOrder { get; set; }

		[Outlet]
		AppKit.NSTableColumn AcualPriceCol { get; set; }

		[Outlet]
		AppKit.NSTableColumn CostCol { get; set; }

		[Outlet]
		AppKit.NSTableColumn ProductNameCol { get; set; }

		[Outlet]
		AppKit.NSTableColumn QuantityCol { get; set; }

		[Outlet]
		AppKit.NSTableColumn SalePriceCol { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ProductOrder != null) {
				ProductOrder.Dispose ();
				ProductOrder = null;
			}

			if (ProductNameCol != null) {
				ProductNameCol.Dispose ();
				ProductNameCol = null;
			}

			if (CostCol != null) {
				CostCol.Dispose ();
				CostCol = null;
			}

			if (SalePriceCol != null) {
				SalePriceCol.Dispose ();
				SalePriceCol = null;
			}

			if (AcualPriceCol != null) {
				AcualPriceCol.Dispose ();
				AcualPriceCol = null;
			}

			if (QuantityCol != null) {
				QuantityCol.Dispose ();
				QuantityCol = null;
			}
		}
	}
}
