using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]

  public class PastryTests
  {
    [TestMethod]
    public void Pastry_ConstructorTest_Int()
    {
      Pastry newPastry = new Pastry(11);
      Assert.AreEqual(11, newPastry.Amount);
    }
    [TestMethod]
    public void GetCost_ReturnsCostOfBreadForAnAmount_Int()
    {
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(0, newPastry.GetCost());
      Pastry newPastry2 = new Pastry(1);
      Assert.AreEqual(2, newPastry2.GetCost());
      Pastry newPastry3 = new Pastry(2);
      Assert.AreEqual(4, newPastry3.GetCost());
      Pastry newPastry4 = new Pastry(3);
      Assert.AreEqual(5, newPastry4.GetCost());
      Pastry newPastry5 = new Pastry(10);
      Assert.AreEqual(17, newPastry5.GetCost());
    }
  }
}