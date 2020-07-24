using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstuctor_ShouldCreateAVendorObject_TypeMatch()
    {
      Vendor newVendor = new Vendor("Suzies");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      Assert.AreEqual("Suzie's", newVendor.Name);
    }
  }
}