using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AlmukhametovTI.Sprint4.Task2.V27.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint4.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 / Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #4                                                          *");
            Console.WriteLine("* Задание #2                                                         *");
            Console.WriteLine("* Вариант #27                                                        *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 13 элементов       *");
            Console.WriteLine("* заполненный случайными в диапазоне от 2 до 7 подсчитать сумму      *");
            Console.WriteLine("*  четных элементов массива.                                         *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numArray[i] = rnd.Next(2, 8);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numArray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");

            int res = ds.Calculate(numArray);

            Console.WriteLine("Сумма чётных элементов массива равна: " + res);
            Console.ReadKey();

        }
    }
}
