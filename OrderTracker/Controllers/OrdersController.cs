using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      List<Order> orderList = Order.GetAll();
      Dictionary<string, object> listDictionary = new Dictionary<string, object>();
      listDictionary["vendor"] = vendorList;
      listDictionary["order"] = orderList;
      return View(listDictionary);
    }

    [HttpGet("/vendors/{vendorID}/orders/new")]
    public ActionResult New(int vendorID)
    {
      Vendor vendor = Vendor.FindVendor(vendorID);
      return View(vendor);
    }
  }
}