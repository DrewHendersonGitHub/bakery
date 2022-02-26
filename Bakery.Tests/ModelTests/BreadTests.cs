using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]
    public void Bread_ConstructorTest_Int()
    {
      Bread newBread = new Bread(8);
      Assert.AreEqual(8, newBread.Amount);
    }
    [TestMethod]
    public void GetCost_ReturnsCostOfBreadForAnAmount_Int()
    {
      Bread newBread = new Bread(0);
      Assert.AreEqual(0, newBread.GetCost());
      Bread newBread2 = new Bread(2);
      Assert.AreEqual(10, newBread2.GetCost());
      Bread newBread3 = new Bread(3);
      Assert.AreEqual(10, newBread3.GetCost());
      Bread newBread4 = new Bread(4);
      Assert.AreEqual(15, newBread4.GetCost());
      Bread newBread5 = new Bread(80);
      Assert.AreEqual(270, newBread5.GetCost());
    }
  }
}