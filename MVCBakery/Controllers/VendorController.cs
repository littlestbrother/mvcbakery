using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MVCBakery.Models;

namespace MVCBakery.Controllers {
	public class VendorsController: Controller {

		[HttpGet("/vendors")]
		public ActionResult Index() {
			List < Vendor > allVendors = Vendor.GetAll();
			return View(allVendors);
		}

		[HttpGet("/vendors/new")]
		public ActionResult New() {
			return View();
		}

		[HttpPost("/vendors")]
		public ActionResult Create(string VendorName, string VendorDescription) {
			Vendor newVendor = new Vendor(VendorName, VendorDescription);
			return RedirectToAction("Index");
		}


		[HttpGet("/vendors/{id}")]
		public ActionResult Show(int id) {
			Dictionary < string, object > model = new Dictionary < string, object > ();
			Vendor selectedVendor = Vendor.Find(id);
			List < Order > VendorOrders = selectedVendor.Orders;
			model.Add("Vendor", selectedVendor);
			model.Add("Orders", VendorOrders);
			return View(model);
		}

        [HttpPost("/vendors/{vendorId}/orders/")]
        public ActionResult Create(string OrderDescription, string OrderTitle, int OrderPrice, string Date, string Type, int VendorId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor foundVendor = Vendor.Find(VendorId);
            Order newOrder = new Order(OrderDescription, OrderTitle, OrderPrice, Date, Type);
            foundVendor.AddOrder(newOrder);
            List<Order> VendorOrders = foundVendor.Orders;
            model.Add("Orders", VendorOrders);
            model.Add("Vendor", foundVendor);
            return View("Show", model);
        }
    }
}