using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public int ID { get; }
    private List<Order> _orderList = new List<Order>();
    private static int _nextID = 1;
    private static List<Vendor> _vendorList = new List<Vendor>();

    public Vendor(string name)
    {
      Name = name;
      ID = _nextID;
      _nextID++;
      _vendorList.Add(this);
    }

    public Vendor(string name, string phoneNumber, string address, string email)
    {
      Name = name;
      Phone = phoneNumber;
      Address = address;
      Email = email;
      ID = _nextID;
      _nextID++;
      _vendorList.Add(this);
    }

    public void AddOrder(Order newOrder)
    {
      _orderList.Add(newOrder);
    }

    public List<Order> GetOrders()
    {
      return _orderList;
    }

    public void VendorUpdate(string name, string phoneNumber, string address, string email)
    {
      Name = name;
      Phone = phoneNumber;
      Address = address;
      Email = email;
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
      Vendor foundVendor = null;
      for (int i = 0; i < _vendorList.Count; i++)
      {
        if (_vendorList[i].ID == id)
        {
          foundVendor = _vendorList[i];
          break;
        }
      }
      return foundVendor;
    }

    public static void Delete(int id)
    {
      Vendor foundVendor = FindVendor(id);
      _vendorList.Remove(foundVendor);
    }
  }
}