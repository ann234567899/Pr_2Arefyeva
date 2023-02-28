using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ПрР1_Арефьева;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 0;
            int j = 0;

            int actual = 0;

            MatrixCreation mat = new MatrixCreation(i, j);
            int nomber = 0;

            Assert.AreEqual(actual, mat.MATRIX(nomber));
        }
    }
}
