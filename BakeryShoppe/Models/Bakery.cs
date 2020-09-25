using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public static int CalculateBread(int breadAmount)
    {

      int calculateFreeBread = breadAmount / 3;
      int breadTotalCost = (breadAmount - calculateFreeBread) * 5;
      
      return breadTotalCost;
    }
  }

  // public class Pastry
  // {
  //   public static string CalculatePastry(int pastryAmount)
  //   {

  //   }

  // }
}