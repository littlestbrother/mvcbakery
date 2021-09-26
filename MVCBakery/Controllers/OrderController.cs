using Microsoft.AspNetCore.Mvc;
using MVCBakery.Models;
using System.Collections.Generic;

namespace MVCBakery.Controllers {
	public class OrdersController: Controller {

		[HttpGet("/vendors/{vendorId}/orders/new")]
		public ActionResult New(int VendorId) {
			Vendor Vendor = Vendor.Find(VendorId);
			return View(Vendor);
		}

		[HttpGet("/vendors/{vendorId}/orders/{orderId}")]
		public ActionResult Show(int VendorId, int OrderId) {
			Order Order = Order.Find(OrderId);
			Vendor Vendor = Vendor.Find(VendorId);
			Dictionary < string,object > model = new Dictionary < string, object > ();
			model.Add("Orders", Order);
			model.Add("Vendors", Vendor);
			return View(model);
		}
	}
}