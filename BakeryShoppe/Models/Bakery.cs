using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public static string CalculateBread(int breadAmount)
    {
      Dictionary <int, string> cost = new Dictionary<int, string>(){
        { 1, "$5" }, 
        { 2, "$10" }, 
        { 3, "$10" }
      };

      string breadTotalCost = "null";


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