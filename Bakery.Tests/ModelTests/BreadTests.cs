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
      Bread newBread = new Bread(8);
      Assert.AreEqual(8, newBread.GetCost());
    }
  }
}