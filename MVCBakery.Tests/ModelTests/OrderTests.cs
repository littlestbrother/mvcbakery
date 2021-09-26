using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MVCBakery.Models;
using System;

namespace MVCBakery.Tests { [TestClass]
	public class OrderTests: IDisposable {

		public void Dispose() {
			Order.ClearAll();
		}

		[TestMethod]
		public void OrderConstructor_CreatesInstanceOfOrder_Order() {
			Order newOrder = new Order("Order from Pete", "bread", 5, "9/24/2021", "Delivery");
			Assert.AreEqual(typeof(Order), newOrder.GetType());
		}

		[TestMethod]
		public void GetTitle_ReturnsTitle_String() {
			string title = "Smith Order";
			Order newOrder = new Order(title, "bread", 5, "9/24/2021", "Delivery");
			string result = newOrder.Title;
			Assert.AreEqual(title, result);
		}

		[TestMethod]
		public void SetTitle_SetTitle_String() {
			string title = "Smith Order";
			Order newOrder = new Order(title, "bread", 5, "9/24/2021", "Delivery");
			string updatedTitle = "Tennant Order";
			newOrder.Title = updatedTitle;
			string result = newOrder.Title;
			Assert.AreEqual(updatedTitle, result);
		}

		[TestMethod]
		public void GetAll_ReturnsEmptyList_OrderList() {
			List < Order > newList = new List < Order > {};
			List < Order > result = Order.GetAll();
			CollectionAssert.AreEqual(newList, result);
		}

		[TestMethod]
		public void GetAll_ReturnsOrders_OrderList() {
			string title1 = "Smith Order";
			string title2 = "Tennant Order";
			Order newOrder1 = new Order(title1, "bread", 5, "9/24/2021", "Delivery");
			Order newOrder2 = new Order(title2, "bread", 4, "9/24/2021", "Pickup");
			List < Order > newList = new List < Order > {
				newOrder1,
				newOrder2
			};
			List < Order > result = Order.GetAll();
			CollectionAssert.AreEqual(newList, result);
		}
	}
}