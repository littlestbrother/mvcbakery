using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCBakery.Models;
using System.Collections.Generic;
using System;

namespace MVCBakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Ben's Bread", "Ben has lots of bread");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test the Vendor";
      Vendor newVendor = new Vendor(name, "no joke his actual name is Test");

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test the Vendor";
      Vendor newVendor = new Vendor(name, "no joke his actual name is Test");

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name1 = "Ben's Bread";
      string name2 = "Pete's Pastries";
      Vendor newVendor1 = new Vendor(name1, "description");
      Vendor newVendor2 = new Vendor(name2, "description... again!");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name1 = "Ben's Bread";
      string name2 = "Pete's Pastries";
      Vendor newVendor1 = new Vendor(name1, "description");
      Vendor newVendor2 = new Vendor(name2, "description... again!");

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string name1 = "Ben's Bread";
      Order newOrder = new Order(name1, "bread", 5, "9/24/2021", "Delivery");
      List<Order> newList = new List<Order> { newOrder };
      string name2 = "Pete's Pastries";
      Vendor newVendor = new Vendor(name2, "description... again!");
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
  }
}