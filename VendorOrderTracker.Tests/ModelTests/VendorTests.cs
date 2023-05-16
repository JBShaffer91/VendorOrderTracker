using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
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
      Vendor newVendor = new Vendor("Test Vendor", "Sample description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      // Arrange
      string name = "Test Vendor";
      string description = "Sample description";
      Vendor newVendor = new Vendor(name, description);

      // Act
      string result = newVendor.Name;

      // Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      // Arrange
      string name = "Test Vendor";
      string description = "Sample description";
      Vendor newVendor = new Vendor(name, description);

      // Act
      string result = newVendor.Description;

      // Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      // Arrange
      string name = "Test Vendor";
      string description = "Sample description";
      Vendor newVendor = new Vendor(name, description);

      // Act
      int result = newVendor.Id;

      // Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      // Arrange
      string name01 = "Test Vendor 1";
      string name02 = "Test Vendor 2";
      string description01 = "Sample description 1";
      string description02 = "Sample description 2";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      // Act
      List<Vendor> result = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      // Arrange
      string name01 = "Test Vendor 1";
      string name02 = "Test Vendor 2";
      string description01 = "Sample description 1";
      string description02 = "Sample description 2";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);

      // Act
      Vendor foundVendor = Vendor.Find(2);

      // Assert
      Assert.AreEqual(newVendor2, foundVendor);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      // Arrange
      string title = "Order1";
      string description = "Order1 description";
      int price = 10;
      string date = "2023-05-16";
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Test Vendor";
      string vendorDescription = "Sample description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);

      // Act
      List<Order> result = newVendor.Orders;

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
