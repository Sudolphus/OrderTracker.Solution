using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorID}/orders/new")]
    public ActionResult New(int vendorID)
    {
      Vendor vendor = Vendor.FindVendor(vendorID);
      return View(vendor);
    }

    [HttpPost("/vendors/{vendorID}/orders")]
    public ActionResult Create(int vendorID, string breadOrder, string pastryOrder)
    {
      Vendor vendor = Vendor.FindVendor(vendorID);
      int bread = int.Parse(breadOrder);
      int pastry = int.Parse(pastryOrder);
      Order newOrder = new Order(bread, pastry);
      vendor.AddOrder(newOrder);
      return RedirectToAction("Index", "Vendors", new { area = ""});
    }

    [HttpGet("/vendors/{vendorID}/orders/{orderID}")]
    public ActionResult Show(int vendorID, int orderID)
    {
      Vendor vendor = Vendor.FindVendor(vendorID);
      Order order = Order.FindOrder(orderID);
      object[] vendorOrderArray = new object[]{vendor, order};
      return View(vendorOrderArray);
    }
  }
}