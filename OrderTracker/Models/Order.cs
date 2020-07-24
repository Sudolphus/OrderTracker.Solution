using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public int BreadOrder { get; }
    public int PastryOrder { get; }
    public int ID { get; }
    private static int _nextID = 1;
    private static List<Order> _orderList = new List<Order>();

    public Order(int bread, int pastry)
    {
      BreadOrder = bread;
      PastryOrder = pastry;
      ID = _nextID;
      _nextID++;
      _orderList.Add(this);
    }

    public static void ResetOrders()
    {
      _nextID = 1;
      _orderList.Clear();
    }

    public static List<Order> GetAll()
    {
      return _orderList;
    }
  }
}