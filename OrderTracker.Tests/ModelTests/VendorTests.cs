using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System;
using System.Collections.Generic;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {
    public void Dispose()
    {
      Vendor.ResetVendors();
    }

    [TestMethod]
    public void VendorConstuctor_ShouldCreateAVendorObject_TypeMatch()
    {
      Vendor newVendor = new Vendor("Suzie's");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      Assert.AreEqual("Suzie's", newVendor.Name);
    }

    [TestMethod]
    public void VendorConstructor_ShouldAssignIDForViewing_Match()
    {
      Vendor newVendor = new Vendor("Suzie's");
      int _expectedID = 1;
      Assert.AreEqual(_expectedID, newVendor.ID);
    }

    [TestMethod]
    public void VendorConstructor_ShouldAddVendorToList_Added()
    {
      Vendor newVendor1 = new Vendor("Suzie's");
      Vendor newVendor2 = new Vendor("Central Perk");
      List<Vendor> _expectedList = new List<Vendor> { newVendor1, newVendor2 };
      CollectionAssert.AreEqual(_expectedList, Vendor.GetAll());
    }

    [TestMethod]
    public void AddOrder_ShouldAddOrderToVendor_ListMatch()
    {
      Vendor newVendor = new Vendor("Suzie's");
      Order newOrder = new Order(5, 3);
      newVendor.AddOrder(newOrder);
      List<Order> _expectedList = new List<Order> { newOrder };
      CollectionAssert.AreEqual(_expectedList, newVendor.GetOrders());
    }

    [TestMethod]
    public void FindVendor_ShouldFindVendorFromID_Match()
    {
      Vendor newVendor = new Vendor("Suzie's");
      Vendor foundVendor = Vendor.FindVendor(1);
      Assert.AreEqual(newVendor, foundVendor);
    }

    [TestMethod]
    public void VendorConstructorOverload_StoreMoreData_Match()
    {
      Vendor newVendor = new Vendor("Suzies", "503-555-9999", "123 Fake Street", "suzies@bakery.com");
      Assert.AreEqual("Suzies", newVendor.Name);
      Assert.AreEqual("503-555-9999", newVendor.Phone);
      Assert.AreEqual("123 Fake Street", newVendor.Address);
      Assert.AreEqual("suzies@bakery.com", newVendor.Email);
    }
  }
}