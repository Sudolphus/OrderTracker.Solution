using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public int ID { get; }
    private static int _nextID = 1;
    public Vendor(string name)
    {
      Name = name;
      ID = _nextID;
      _nextID++;
    }

    public static void ResetVendors()
    {
      _nextID = 1;
    }

    public static List<Vendor> GetAll()
    {
      List<Vendor> dummyList = new List<Vendor>();
      return dummyList;
    }
  }
}