using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]
    public void Bread_ConstructorTest_String()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(5, newBread.amount());
    }
  }
}