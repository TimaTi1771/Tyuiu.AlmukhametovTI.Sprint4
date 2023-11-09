using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint4.Task6.V5.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint4.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var weg = new string[] { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };
            int res = ds.Calculate(weg);
            int wait = 1;
            Assert.AreEqual(res, wait);

        }
    }
}
