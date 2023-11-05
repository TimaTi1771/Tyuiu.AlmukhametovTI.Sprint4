using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AlmukhametovTI.Sprint4.Task0.V30.Lib
{
    public class DataService : ISprint4Task0V30
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int[] numsarray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
