using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public int ID { get; }
    private static int _nextID = 1;
    private static List<Vendor> _vendorList = new List<Vendor>();

    public Vendor(string name)
    {
      Name = name;
      ID = _nextID;
      _nextID++;
      _vendorList.Add(this);
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
  }
}