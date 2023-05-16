using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime Date { get; set; }
    public bool IsPaid { get; set; }
    private static List<Order> _instances = new List<Order>();

    public Order(string title, string description, decimal price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances.Find(order => order.Id == searchId);
    }

    public static void DeleteOrder(int orderId)
    {
      _instances.RemoveAll(order => order.Id == orderId);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void TogglePaymentStatus()
    {
      IsPaid = !IsPaid;
    }
  }
}
