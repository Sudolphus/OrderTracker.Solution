using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorPhone, string vendorAddress, string vendorEmail)
    {
      Vendor newVendor = new Vendor(vendorName, vendorPhone, vendorAddress, vendorEmail);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundVendor = Vendor.FindVendor(id);
      return View(foundVendor);
    }

    [HttpGet("/vendors/{id}/edit")]
    public ActionResult Edit(int id)
    {
      Vendor vendor = Vendor.FindVendor(id);
      return View(vendor);
    }

    [HttpPost("/vendors/{id}/edit")]
    public ActionResult Update(int id, string vendorName, string vendorPhone, string vendorAddress, string vendorEmail)
    {
      Vendor vendor = Vendor.FindVendor(id);
      vendor.VendorUpdate(vendorName, vendorPhone, vendorAddress, vendorEmail);
      return RedirectToAction("Show", new { id = id });
    }

    [HttpPost("/vendors/{id}/destroy")]
    public ActionResult Destroy(int id)
    {
      Vendor.Delete(id);
      return RedirectToAction("Index");
    }
  }
}