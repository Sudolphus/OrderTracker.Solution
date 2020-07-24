namespace OrderTracker.Models
{
  public class Order
  {
    public int BreadOrder { get; }
    public int PastryOrder { get; }
    public int ID { get; }
    public Order(int bread, int pastry)
    {
      BreadOrder = bread;
      PastryOrder = pastry;
    }

  }
}