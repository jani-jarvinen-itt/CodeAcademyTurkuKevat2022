using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yksikkötestaus;
using System;

namespace Yksikkötestaus.Tests
{
    [TestClass()]
    public class LaskentaTests
    {
        [TestMethod()]
        public void SummaTest()
        {
            int a = 1;
            int b = 2;
            int odotusarvo = a + b;

            Laskenta laskenta = new();
            int summa = laskenta.Summa(a, b);

            Assert.AreEqual(odotusarvo, summa);
        }
    }
}