using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using Xunit;

namespace VendorOrderTracker.Tests
{
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [Fact]
    public void Constructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Order", "Test Description", 10, new DateTime(2023, 5, 15));
      Assert.IsType<Order>(newOrder);
    }

    [Fact]
    public void Constructor_SetsProperties_StringAndInt()
    {
      Order newOrder = new Order("Test Order", "Test Description", 10, new DateTime(2023, 5, 15));
      Assert.Equal("Test Order", newOrder.Title);
      Assert.Equal("Test Description", newOrder.Description);
      Assert.Equal(10, newOrder.Price);
      Assert.Equal(new DateTime(2023, 5, 15), newOrder.Date);
    }

    [Fact]
    public void GetAll_ReturnsAllOrderInstances_OrderList()
    {
      Order order1 = new Order("Order 1", "Description 1", 5, new DateTime(2023, 5, 12));
      Order order2 = new Order("Order 2", "Description 2", 15, new DateTime(2023, 5, 13));
      List<Order> expectedList = new List<Order> { order1, order2 };

      List<Order> resultList = Order.GetAll();

      Assert.Equal(expectedList, resultList);
    }

    [Fact]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order order1 = new Order("Order 1", "Description 1", 5, new DateTime(2023, 5, 12));
      Order order2 = new Order("Order 2", "Description 2", 15, new DateTime(2023, 5, 13));

      Order? foundOrder = Order.Find(2);

      Assert.Equal(order2, foundOrder);
    }
  }
}
