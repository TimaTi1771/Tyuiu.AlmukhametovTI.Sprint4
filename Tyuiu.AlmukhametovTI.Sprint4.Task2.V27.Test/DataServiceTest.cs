using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint4.Task2.V27.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint4.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 7, 6, 4, 5, 5, 4, 7, 6, 4, 7, 6, 3 };
            int res = ds.Calculate(numsArray);
            int wait = 34;
            Assert.AreEqual(res, wait);
        }
    }
}
