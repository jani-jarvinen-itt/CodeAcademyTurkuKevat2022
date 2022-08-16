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
            int[] a = { 1, 100, -30, 57, 12 };
            int[] b = { 2, 200, -70, 33, 62 };

            Laskenta laskenta = new();

            for (int indeksi = 0; indeksi < a.Length; indeksi++)
            {
                int odotusarvo = a[indeksi] + b[indeksi];

                int summa = laskenta.Summa(a[indeksi], b[indeksi]);
                Console.WriteLine($"Testataan: {summa}.");

                Assert.AreEqual(odotusarvo, summa);
            }
        }
    }
}