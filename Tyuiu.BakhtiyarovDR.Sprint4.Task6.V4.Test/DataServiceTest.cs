using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint4.Task6.V4.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint4.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var colors = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            string[] res = ds.Calculate(colors);
            string[] wait = { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
