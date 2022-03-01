using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]

  public class PastryTests
  {
    [TestMethod]
    public void Get_ReturnsTheValueOfCostOrAmount_Int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(2, newPastry.Cost);
      Assert.AreEqual(-1, newPastry.Amount);
    }
    [TestMethod]
    public void Set_SetsTheValueOfCostOrAmount_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.Cost = 2;
      newPastry.Amount = 9;
      Assert.AreEqual(2, newPastry.Cost);
      Assert.AreEqual(9, newPastry.Amount);
    }
    [TestMethod]
    public void GetCost_ReturnsCostOfBreadForAnAmount_Int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(0, newPastry.GetCost(0));
      Pastry newPastry1 = new Pastry();
      Assert.AreEqual(2, newPastry1.GetCost(1));
      Pastry newPastry2 = new Pastry();
      Assert.AreEqual(4, newPastry2.GetCost(2));
      Pastry newPastry3 = new Pastry();
      Assert.AreEqual(5, newPastry3.GetCost(3));
      Pastry newPastry4 = new Pastry();
      Assert.AreEqual(7, newPastry4.GetCost(4));
      Pastry newPastry5 = new Pastry();
      Assert.AreEqual(167, newPastry5.GetCost(100));
    }
  }
}