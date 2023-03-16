using Microsoft.VisualStudio.TestTools.UnitTesting;
using GGLibrary;
using System;

namespace UnitTestGG
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreaSquare_4_returned16()
        { 
            GGClass g = new GGClass();
            int A = 4;
            int S = A * A;
            int expected = 16;

            int result = (int)g.AreaSquare(A, S);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaRhomd_4and8_returned16()
        {
            GGClass g = new GGClass();
            int d1 = 4;
            int d2 = 8;
            int S = (int)(d1 * d2) / 2;
            int expected = 16;

            int result = g.AreaRhomb(d1, d2, S);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AreaTrangle_3and5_returned()
        {
            GGClass g = new GGClass();
            float a = 3;
            float h = 5;
            float S = (a * h)/2;
            double expected = 7.5;

            float result = g.AreaTrangle(a, h, S);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaRectangle_3nd5_returned15()
        {
            GGClass g = new GGClass();
            int h = 3;
            int l = 5;
            int S = h * l;
            int expected = 15;

            int result = g.AreaRectangle1(h, l, S);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaCiirle_PiandR_returned()
        {
            GGClass g = new GGClass();
            int R = 3;
            int S = ((int)(Math.PI * Math.Pow(R, 2)));
            int expected = 28;

            int result = g.AreaCircle(R, S);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaRing_50and40_returned()
        {
            GGClass g = new GGClass();
            double R = 50;
            double r = 40;

            double S = 3.14 * Math.Pow(R, 2) - Math.Pow(r, 2);

            double expected = 6250;
            double result = g.AreaRing((int)R, (int)r);
            Assert.AreEqual(expected, result);
        }
    }
}
