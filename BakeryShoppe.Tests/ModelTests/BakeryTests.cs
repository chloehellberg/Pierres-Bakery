using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalculateBread_CalculateCostOfBreadItems_Cost()
    {
      Assert.AreEqual("5", Bread.CalculateCost("1"));
    }
  }

  public class PastryTests
  {
    [TestMethod]
    public void CalculatePastry_CalculateCostOfPastryItems_Cost()
    {
      Assert.AreEqual("2", Pastry.CalculateCost("1"));
    }
  }

}