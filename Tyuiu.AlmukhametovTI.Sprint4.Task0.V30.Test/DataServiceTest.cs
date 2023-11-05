using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint4.Task0.V30.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] Array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.GetSumEvenArrEl(Array);
            int wait = 30;
            Assert.AreEqual(res, wait);

        }
    }
}
