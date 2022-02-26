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
  }
}