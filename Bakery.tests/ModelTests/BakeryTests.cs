using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadCalc;
using PastryCalc;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadCalc
  {
    [TestMethod]
    public void BuyOneGetOne()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Bread Marge = new Bread();
      Assert.AreEqual(10, Marge.BreadPrice(3, 0));
    }

  }
}