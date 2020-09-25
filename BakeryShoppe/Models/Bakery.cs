namespace Bakery.Models
{
  public class Bread
  {
    public int totalBreadRequested { get; set; }

    public Bread(int breadOrdered)
    {
      totalBreadRequested = breadOrdered;
    }
    public int CalculateBread()
    {
      int calculateFreeBread = totalBreadRequested / 3;
      int breadTotalCost = (totalBreadRequested - calculateFreeBread) * 5;
      
      return breadTotalCost;
    }
  }

  public class Pastry
  {
    public int pastryAmount { get; set; }

    public Pastry(int pastryOrdered)
    {
      pastryAmount = pastryOrdered;
    }
    public int CalculatePastry()
    {
      int discountedPastries = pastryAmount / 3;
      int pastryTotalCost = (pastryAmount * 2) - discountedPastries;

      return pastryTotalCost;
    }
  }
}