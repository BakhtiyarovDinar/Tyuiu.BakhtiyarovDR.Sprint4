using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint4.Task0.V27.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint4.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Бахтияров Д. Р. | АСОиУБ-23-3";

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #4                                                               -");
            Console.WriteLine("- Тема: Одномерные массивы (статический ввод)                             -");
            Console.WriteLine("- Задание #0                                                              -");
            Console.WriteLine("- Вариант #27                                                             -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович | АСОиУБ-23-3                      -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- УСЛОВИЕ:                                                                -");
            Console.WriteLine("- Дан одномерный целочисленный массив на 10 элементов                     -");
            Console.WriteLine("- заполненный статическими значениями в диапазоне от 0 до 9               -");
            Console.WriteLine("- подсчитать произведение нечетных элементов массива.                     -");
            Console.WriteLine("- {7 ,4 ,3 ,2 ,1 ,5 ,9 ,8 ,7 ,4}                                          -");
            Console.WriteLine("-                                                                         -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                        -");
            Console.WriteLine("---------------------------------------------------------------------------");

            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Произведение нечетных элементов массива = " + ds.GetMultOddArrEl(numsArray));
            Console.ReadKey();
        }
    }
}
