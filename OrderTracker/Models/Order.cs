using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public int BreadOrder { get; }
    public int PastryOrder { get; }
    public int ID { get; }
    private static int _nextID = 1;

    public Order(int bread, int pastry)
    {
      BreadOrder = bread;
      PastryOrder = pastry;
      ID = _nextID;
      _nextID++;
    }

    public static void ResetOrders()
    {
      _nextID = 1;
    }

    public static List<Order> GetAll()
    {
      List<Order> dummyList = new List<Order>();
      return dummyList;
    }
  }
}