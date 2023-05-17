using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor? selectedVendor = Vendor.Find(id);
      return View(selectedVendor);
    }

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult CreateOrder(int id)
    {
      Vendor? selectedVendor = Vendor.Find(id);
      return View(selectedVendor);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult CreateOrder(int vendorId, string orderTitle, string orderDescription, string orderPrice, string orderDate)
    {
      DateTime parsedOrderDate = DateTime.Parse(orderDate);
      decimal parsedOrderPrice = decimal.Parse(orderPrice);
      Order newOrder = new Order(orderTitle, orderDescription, parsedOrderPrice, parsedOrderDate);
      Vendor? foundVendor = Vendor.Find(vendorId);
      foundVendor.AddOrder(newOrder);
      return RedirectToAction("Show", new { id = vendorId });
    }
  }
}
