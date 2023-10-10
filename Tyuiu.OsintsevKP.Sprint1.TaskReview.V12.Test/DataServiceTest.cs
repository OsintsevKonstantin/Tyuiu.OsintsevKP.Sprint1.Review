using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OsintsevKP.Sprint1.TaskReview.V12.Lib;

namespace Tyuiu.OsintsevKP.Sprint1.TaskReview.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(153, res);
        }
    }
}
