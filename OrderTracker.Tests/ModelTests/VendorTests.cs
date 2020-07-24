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
  }
}