using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint2.Task6.V2.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();

            Assert.AreEqual("зима", ds.FindMonthSeason(1));
            Assert.AreEqual("весна", ds.FindMonthSeason(4));
            Assert.AreEqual("лето", ds.FindMonthSeason(7));
            Assert.AreEqual("осень", ds.FindMonthSeason(10));
        }
    }
}
