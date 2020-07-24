namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public int ID { get; } = 0;
    
    public Vendor(string name)
    {
      Name = name;
    }
  }
}