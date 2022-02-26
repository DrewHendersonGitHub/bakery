using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]
    public void GetCost_ReturnsCostOfBreadForAnAmount_Int()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(0, newBread.GetCost(0));
      Bread newBread1 = new Bread();
      Assert.AreEqual(5, newBread1.GetCost(1));
      Bread newBread2 = new Bread();
      Assert.AreEqual(10, newBread2.GetCost(2));
      Bread newBread3 = new Bread();
      Assert.AreEqual(10, newBread3.GetCost(3));
      Bread newBread4 = new Bread();
      Assert.AreEqual(15, newBread4.GetCost(4));
      Bread newBread5 = new Bread();
      Assert.AreEqual(335, newBread5.GetCost(100));
    }
  }
}