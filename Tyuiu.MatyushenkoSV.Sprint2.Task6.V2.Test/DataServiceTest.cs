using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint2.Task6.V2.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindSeasonName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Зима", ds.FindSeasonName(1));
            Assert.AreEqual("Весна", ds.FindSeasonName(4));
            Assert.AreEqual("Лето", ds.FindSeasonName(7));
            Assert.AreEqual("Осень", ds.FindSeasonName(10));
        }
    }
}
