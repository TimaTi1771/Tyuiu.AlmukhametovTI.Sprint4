using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AlmukhametovTI.Sprint4.Task6.V5.Lib;


namespace Tyuiu.AlmukhametovTI.Sprint4.Task6.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();          

            Console.Title = "Спринт #4 | Выполнил: Альмухаметов Т. И. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Альмухаметов Тимур Ильясович | ИИПб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [ Меркурий, Венера, Земля, Марс, Юпитер,    *");
            Console.WriteLine("* Сатурн, Уран, Нептун. ], используя класс Array подсчитайте количество   *");
            Console.WriteLine("* элементов, длина которых равна 5.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var len = new string[] { "Meркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун"};

            Console.WriteLine("Исходный массив: ");
            for( int i = 0; i <= len.Length - 1; i++)
            {
                Console.WriteLine(len[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длинна которых равна 5:");

            int res = ds.Calculate(len);
            Console.WriteLine("***");
            Console.WriteLine($"*{res}*");
            Console.WriteLine("***");
            Console.ReadKey();
        }
    }
}
