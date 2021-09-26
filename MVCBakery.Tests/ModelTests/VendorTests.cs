using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCBakery.Models;
using System.Collections.Generic;
using System;

namespace MVCBakery.Tests { [TestClass]
	public class VendorTests: IDisposable {

		public void Dispose() {
			Vendor.ClearAll();
		}

		[TestMethod]
		public void VendorConstructor_CreatesInstanceOfVendor_Vendor() {
			Vendor newVendor = new Vendor("Ben's Bread", "Ben has lots of bread");
			Assert.AreEqual(typeof(Vendor), newVendor.GetType());
		}

		[TestMethod]
		public void GetProperty_ReturnsProperty_String() {
			string name = "Test the Vendor";
			Vendor newVendor = new Vendor(name, "no joke his actual name is Test");
			string result = newVendor.Name;
			Assert.AreEqual(name, result);
		}

		[TestMethod]
		public void GetId_ReturnsVendorId_Int() {
			string name = "Test the Vendor";
			Vendor newVendor = new Vendor(name, "no joke his actual name is Test");
			int result = newVendor.Id;
			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void GetAll_ReturnsAllVendorObjects_VendorList() {
			string name1 = "Ben's Bread";
			string name2 = "Pete's Pastries";
			Vendor newVendor1 = new Vendor(name1, "description");
			Vendor newVendor2 = new Vendor(name2, "description... again!");
			List < Vendor > newList = new List < Vendor > {
				newVendor1,
				newVendor2
			};
			List < Vendor > result = Vendor.GetAll();
			CollectionAssert.AreEqual(newList, result);
		}

		[TestMethod]
		public void Find_ReturnsCorrectVendor_Vendor() {
			string name1 = "Ben's Bread";
			string name2 = "Pete's Pastries";
			Vendor newVendor1 = new Vendor(name1, "description");
			Vendor newVendor2 = new Vendor(name2, "description... again!");
			Vendor result = Vendor.Find(2);
			Assert.AreEqual(newVendor2, result);
		}

		[TestMethod]
		public void AddOrder_AssociatesOrderWithVendor_OrderList() {
			string name1 = "Ben's Bread";
			Order newOrder = new Order(name1, "bread", 5, "9/24/2021", "Delivery");
			List < Order > newList = new List < Order > {
				newOrder
			};
			string name2 = "Pete's Pastries";
			Vendor newVendor = new Vendor(name2, "description... again!");
			newVendor.AddOrder(newOrder);
			List < Order > result = newVendor.Orders;
			CollectionAssert.AreEqual(newList, result);
		}

	}
}