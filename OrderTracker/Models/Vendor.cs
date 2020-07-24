using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public int ID { get; }
    private List<Order> _orderList = new List<Order>();
    private static int _nextID = 1;
    private static List<Vendor> _vendorList = new List<Vendor>();
    private static Dictionary<int, Vendor> _vendorDictionary = new Dictionary<int, Vendor>();

    public Vendor(string name)
    {
      Name = name;
      ID = _nextID;
      _nextID++;
      _vendorList.Add(this);
      _vendorDictionary[ID] = this;
    }

    public void AddOrder(Order newOrder)
    {
      _orderList.Add(newOrder);
    }

    public List<Order> GetOrders()
    {
      return _orderList;
    }

    public static void ResetVendors()
    {
      _nextID = 1;
      _vendorList.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendorList;
    }

    public static Vendor FindVendor(int id)
    {
      return _vendorDictionary[id];
    }
  }
}