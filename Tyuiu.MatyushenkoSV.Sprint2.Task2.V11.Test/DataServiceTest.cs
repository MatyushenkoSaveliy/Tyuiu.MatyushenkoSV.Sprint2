using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint2.Task2.V11.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint2.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 7;
            int y = 8;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
