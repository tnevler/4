using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Практика4;

namespace Тестирование4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod41() // 30*1*2*3*4
        {
            int[] arr1 = { 0, 3, 0 };
            int[] arr2 = { 1, 2, 3, 4 };
            string result1 = "720";
            int[] r = Program.MultOfMas(arr1, arr2);
            string result2 = string.Concat(r);
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void TestMethod42() // 297+445
        {
            int[] arr1 = { 2, 9, 7 };
            int[] arr2 = { 4, 4, 5 };
            string result1 = "742";
            int[] r = Program.SumOfMas(arr1, arr2);
            string result2 = string.Concat(r);
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void TestMethod43() // 534-92
        {
            int[] arr1 = { 5, 3, 4 };
            int[] arr2 = { 0, 9, 2 };
            string result1 = "442";
            int[] r = Program.MinusMas(arr1, arr2);
            string result2 = string.Concat(r);
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void TestMethod44() // Show
        {
            int[] arr1 = { 2, 9, 7 };
            Program.Show(arr1);
        }
    }
}
