using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab_9;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TriangleEqual()
        {
            // Arrange
            bool ok;
            // Act
            Triangle t1 = new Triangle(3, 4, 5);
            Triangle t2 = new Triangle();
            ok = t1 >= t2;
            // Assert
            Assert.AreEqual(t1, true);
        }
        [TestMethod]
        public void TriangleExistence()
        {
            // Arrange
            bool ok;
            // Act
            ok = Triangle.Existence(0, 0, 0);
            // Assert
            Assert.AreEqual(ok, false);
        }
        [TestMethod]
        public void TrianglePerimetr()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            double p = Triangle.Perimetr(t1);
            Assert.AreEqual(p, 3 + 4 + 5);
        }
        [TestMethod]
        public void TriangleSquare()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            Assert.AreEqual(t1.Square(), 6);
        }
        [TestMethod]
        public void TriangleAdd()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            t1++;
            bool ok = t1.A == 4 && t1.B == 5 && t1.C == 6;
            Assert.AreEqual(ok, true);
        }
        [TestMethod]
        public void TriangleDel()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            t1--;
            bool ok = t1.A == 2 && t1.B == 3 && t1.C == 4;
            Assert.AreEqual(ok, true);
        }
        [TestMethod]
        public void TriangleComporaison1()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            Triangle t2 = new Triangle(2, 3, 4);
            bool ok = t1 <= t2;
            Assert.AreEqual(ok, false);
        }
        [TestMethod]
        public void TriangleExplicit()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            double s = (double)t1;
            Assert.AreEqual(s, 6);
        }
        [TestMethod]
        public void TriangleImplicit()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            bool ok = t1;
            Assert.AreEqual(ok, true);
        }
        [TestMethod]
        public void TriangleStaticSquare()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            Assert.AreEqual(Triangle.Square(t1), 6);
        }
        [TestMethod]
        public void TriangleArrayStruct1()
        {
            TriangleArray ta1 = new TriangleArray();
            Assert.AreEqual(ta1.size, 0);
        }
        [TestMethod]
        public void TriangleArrayStruct2()
        {
            TriangleArray ta1 = new TriangleArray(1);
            Assert.AreEqual(ta1.size, 1);
        }
        [TestMethod]
        public void Tr1Existence()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            Assert.IsTrue(t1.Existence());
        }
        [TestMethod]
        public void T1Perimetr()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            Assert.AreEqual(t1.Perimetr(), 3 + 4 + 5);
        }
        [TestMethod]
        public void TriangleArrayIndex()
        {
            TriangleArray ta1 = new TriangleArray(1);
            ta1[0] = new Triangle(3, 4, 5);
            Assert.AreEqual(ta1[0].Square(), 6);
        }
        [TestMethod]
        public void TriangleArrayMinimum()
        {
            TriangleArray ta1 = new TriangleArray(2);
            ta1[0] = new Triangle(3, 4, 5);
            ta1[1] = new Triangle(1, 1, 1);
            Assert.AreEqual(ta1.MinimumSquareIndex(), 1);
        }
    }
}