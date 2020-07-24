using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CanCreateOrderObjects_TypeMatch()
    {
      Order newOrder = new Order(0, 0);
      int expectedBread = 0;
      int expectedPastry = 0;
      Assert.AreEqual(typeof(Order), newOrder.GetType());
      Assert.AreEqual(expectedBread, newOrder.BreadOrder);
      Assert.AreEqual(expectedPastry, newOrder.PastryOrder);
    }

    [TestMethod]
    public void OrderConstructor_AssignIDsToOrder_Match()
    {
      Order newOrder = new Order(0,0);
      int _expectedID = 1;
      Assert.AreEqual(_expectedID, newOrder.ID);
    }
  }
}