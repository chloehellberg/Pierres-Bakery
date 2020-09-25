using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public static string CalculateBread(int breadAmount)
    {
      Dictionary <int, string> costs = new Dictionary<int, string>(){
        { 1, "$5" }, 
        { 2, "$10" }, 
        { 3, "$10" }
      };

      string breadTotalCost = "0";
      
      foreach(KeyValuePair<int, string> cost in costs)
      {
        if (cost.Key == 1)
        {
          breadTotalCost = cost.Value;
        }
        else if (cost.Key == 2)
        {
          breadTotalCost = cost.Value;
        }
        else
        {
          breadTotalCost = cost.Value;
        }
      }

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