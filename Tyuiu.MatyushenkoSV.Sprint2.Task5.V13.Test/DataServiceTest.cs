using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint2.Task5.V13.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("16.08.2024", ds.FindDateOfNextDay(2024, 8, 15));
            Assert.AreEqual("01.03.2024", ds.FindDateOfNextDay(2024, 2, 29));
            Assert.AreEqual("01.01.2025", ds.FindDateOfNextDay(2024, 12, 31));
        }
    }
}
