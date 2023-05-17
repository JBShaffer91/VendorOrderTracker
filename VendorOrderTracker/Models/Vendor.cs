using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public int Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor>();

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>();
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor? Find(int searchId)
    {
      return _instances.Find(vendor => vendor.Id == searchId);
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static void DeleteVendor(int vendorId)
    {
      _instances.RemoveAll(vendor => vendor.Id == vendorId);
    }

    public void DeleteAllOrders()
    {
      Orders.Clear();
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void UpdateVendor(string newName, string newDescription)
    {
      Name = newName;
      Description = newDescription;
    }
  }
}
