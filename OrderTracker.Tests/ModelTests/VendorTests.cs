using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System;

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
  }
}