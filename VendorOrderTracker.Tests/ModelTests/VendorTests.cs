using Xunit;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{

  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [Fact]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test Vendor", "Sample description");
      Assert.IsType<Vendor>(newVendor);
    }

    [Theory]
    [InlineData("Test Vendor", "Sample description")]
    public void GetName_ReturnsName_String(string name, string description)
    {

      Vendor newVendor = new Vendor(name, description);
      //Act
      string result = newVendor.Name;
      Assert.Equal(name, result);
    }

    [Theory]
    [InlineData("Test Vendor", "Sample description")]
    public void GetDescription_ReturnsDescription_String(string name, string description)
    {

      Vendor newVendor = new Vendor(name, description);
      //Act
      string result = newVendor.Description;
      Assert.Equal(description, result);
    }

    [Theory]
    [InlineData("Test Vendor", "Sample description")]
    public void GetId_ReturnsVendorId_Int(string name, string description)
    {
      //Arrange
      Vendor newVendor = new Vendor(name, description);
      //Act
      int result = newVendor.Id;
      Assert.Equal(1, result);
    }

    [Fact]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Test Vendor 1";
      string name02 = "Test Vendor 2";
      string description01 = "Sample description 1";
      string description02 = "Sample description 2";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      //Act
      List<Vendor> result = Vendor.GetAll();

      Assert.Equal(newList, result);
    }

    [Fact]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Test Vendor 1";
      string name02 = "Test Vendor 2";
      string description01 = "Sample description 1";
      string description02 = "Sample description 2";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      //Act
      Vendor foundVendor = Vendor.Find(2);

      Assert.Equal(newVendor2, foundVendor);
    }

    [Fact]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title = "Order1";
      string description = "Order1 description";
      int price = 10;
      DateTime date = new DateTime(2023, 5, 16);
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Test Vendor";
      string vendorDescription = "Sample description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);
      //Act
      List<Order> result = newVendor.Orders;

      Assert.Equal(newList, result);
    }
  }
}
