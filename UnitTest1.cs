using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgileFreaks;



namespace AgileFreaksTest
{
    [TestClass]
    public class UnitTest1
    {
        int[] array1 = { };
        int[] array2 = { 1, 2, 3, 4 };
        int[] array3 = { 1, 1, 1 };
        int[] array4 = { 2, 2, 2 };
        int[] array5 = { -10, 1, 2, 9, 2, 3, 3, 0, -6, 1 };
        int[] array6 = { -2, 2, -1 };

         
        [TestMethod]
        public void TestSimpleProblem1_WithArray1()
        {
            Program test1 = new Program();
            Assert.AreEqual(0, test1.SimpleProblem1(array1));
        }

        [TestMethod]
        public void TestSimpleProblem2_WithArray1()
        {
            Program test2 = new Program();
            Assert.AreEqual<string>("0 and 0", test2.SimpleProblem2(array1));
        }

        [TestMethod]
        public void TestSimpleProblem3_WithArray2()
        {
            Program test3 = new Program();
            Assert.AreEqual(false, test3.SimpleProblem3(array2));
        }
        
    }
}
