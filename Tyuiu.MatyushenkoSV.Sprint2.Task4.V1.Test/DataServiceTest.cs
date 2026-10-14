using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint2.Task4.V1.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint2.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 5.0; 
            double res = ds.Calculate(x, y);
            double wait = 1.0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 2.0; 
            double res = ds.Calculate(x, y);
            double wait = 2.0; 
            Assert.AreEqual(wait, res);
        }
    }
}
