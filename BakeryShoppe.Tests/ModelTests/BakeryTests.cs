using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalculateBread_CalculateCostOfOneBreadItem_Cost()
    {
      Assert.AreEqual("$10", Bread.CalculateBread(3));
    }

    // [TestMethod]
    // public void CalculateBread_CalculateCostOfTwoBreadItems_Cost()
    //   {
    //     Assert.AreEqual("$10", Bread.CalculateBread(2));
    //   }
  }

  // public class PastryTests
  // {
  //   [TestMethod]
  //   public void CalculatePastry_CalculateCostOfPastryItems_Cost()
  //   {
  //     Assert.AreEqual("2", Pastry.CalculatePastry("1"));
  //   }
  // }

}