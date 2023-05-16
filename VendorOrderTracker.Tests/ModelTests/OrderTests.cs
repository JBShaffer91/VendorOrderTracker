using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void Constructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Order", "Test Description", 10, "2023-05-15");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void Constructor_SetsProperties_StringAndInt()
    {
      Order newOrder = new Order("Test Order", "Test Description", 10, "2023-05-15");
      Assert.AreEqual("Test Order", newOrder.Title);
      Assert.AreEqual("Test Description", newOrder.Description);
      Assert.AreEqual(10, newOrder.Price);
      Assert.AreEqual("2023-05-15", newOrder.Date);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderInstances_OrderList()
    {
      Order order1 = new Order("Order 1", "Description 1", 5, "2023-05-12");
      Order order2 = new Order("Order 2", "Description 2", 15, "2023-05-13");
      List<Order> expectedList = new List<Order> { order1, order2 };

      List<Order> resultList = Order.GetAll();

      CollectionAssert.AreEqual(expectedList, resultList);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order order1 = new Order("Order 1", "Description 1", 5, "2023-05-12");
      Order order2 = new Order("Order 2", "Description 2", 15, "2023-05-13");

      Order foundOrder = Order.Find(2);

      Assert.AreEqual(order2, foundOrder);
    }
  }
}
