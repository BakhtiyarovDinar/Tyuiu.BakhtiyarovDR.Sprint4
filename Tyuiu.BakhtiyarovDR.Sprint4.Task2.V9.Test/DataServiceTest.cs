using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint4.Task2.V9.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint4.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };

            int res = ds.Calculate(numsArray);
            int wait = 14;

            Assert.AreEqual(wait, res);
        }
    }
}
