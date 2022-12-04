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
      Bread Marge = new Bread();
      Assert.AreEqual(10, Marge.BreadPrice(3, 0));
    }
    [TestMethod]
        public void BuyABunch()
    {
      Bread Marge = new Bread();
      Assert.AreEqual(25, Marge.BreadPrice(7, 0));
    }
    [TestMethod]
        public void BuyZero()
    {
      Bread Marge = new Bread();
      Assert.AreEqual(0, Marge.BreadPrice(0, 0));
    }
  
      [TestMethod]
    public void DonutUseTheDeal()
    {
      Pastry Homer = new Pastry();
      Assert.AreEqual(4, Homer.PastryPrice(2, 0));
    }
    [TestMethod]
        public void UseTheDeal()
    {
      Pastry Homer = new Pastry();
      Assert.AreEqual(5, Homer.PastryPrice(3, 0));
    }
    [TestMethod]
        public void Lotsofdonuts()
    {
      Pastry Homer = new Pastry();
      Assert.AreEqual(12, Homer.PastryPrice(7, 0));
    }
        [TestMethod]
        public void Nothing()
    {
      Pastry Homer = new Pastry();
      Assert.AreEqual(0, Homer.PastryPrice(0, 0));
    }
    
  }
}