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
      Bread breadOrder = new Bread(1);
      Assert.AreEqual(5, breadOrder.CalculateBread());
    }

    [TestMethod]
    public void CalculateBread_CalculateCostOfTwoBreadItems_Cost()
    {
      Bread breadOrder = new Bread(2);
      Assert.AreEqual(10, breadOrder.CalculateBread());
    }

    [TestMethod]
    public void CalculateBread_CalculateCostOfManyBreadItems_Cost()
    {
      Bread breadOrder = new Bread(9);
      Assert.AreEqual(30, breadOrder.CalculateBread());
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CalculatePastry_CalculateCostOfPastryItems_Cost()
    {
      Pastry pastryOrder = new Pastry(1);
      Assert.AreEqual(2, pastryOrder.CalculatePastry());
    }

    [TestMethod]
    public void CalculatePastry_CalculateCostOfMultiplePastires_Cost()
    {
      Pastry pastryOrder = new Pastry(3);
      Assert.AreEqual(5, pastryOrder.CalculatePastry());
    }
  }
}