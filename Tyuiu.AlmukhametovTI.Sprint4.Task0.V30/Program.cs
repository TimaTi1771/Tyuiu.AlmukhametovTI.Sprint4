using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AlmukhametovTI.Sprint4.Task0.V30.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint4.Task0.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 / Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #4                                                          *");
            Console.WriteLine("* Задание #0                                                         *");
            Console.WriteLine("* Вариант #12                                                        *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 10 элементов       *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9          *");
            Console.WriteLine("* подсчитать сумму четных элементов массива.   {4, 8, 6, 4, 9, 5, 8, *");
            Console.WriteLine("* 7, 8, 4, 7, 6, 8}                                                  *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
            Console.WriteLine("**********************************************************************");

            int[] Array = { 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8 };
            int sum = 0;

            foreach (int num in Array)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine(" Сумма нечётных элементов массива = " + ds.GetSumEvenArrEl(Array));

            Console.ReadKey();
        }
    }
}
    

