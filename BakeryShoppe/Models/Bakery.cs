using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int breadAmount { get; set; }

    public Bread(int breadOrdered)
    {
      breadAmount = breadOrdered;
    }
    public int CalculateBread()
    {
      int calculateFreeBread = breadAmount / 3;
      int breadTotalCost = (breadAmount - calculateFreeBread) * 5;
      
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