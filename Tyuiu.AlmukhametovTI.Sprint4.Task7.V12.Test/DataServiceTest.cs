using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint4.Task7.V12.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint4.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 3;
            int colums = 4;
            int[,] mtrx = new int[rows, colums];
            string str = "658932125478";
            int res = ds.Calculate(rows, colums, str);
            int wait = 30;
            Assert.AreEqual(res, wait);
        }
    }
}
