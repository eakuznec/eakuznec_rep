using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class TaskTwo
    {
        public static void Execute()
        {
            UiConsole.PrintLine("ЗАДАНИЕ 2");
            var size = UiConsole.GetInt("Введите размер матрицы: ");
            var first = UiConsole.GetInt("Введите значение первого элемента: ");
            var step = UiConsole.GetInt("Введите шаг: ");
            IntArray array = new IntArray(size, first, step);
            array.ToString("Массив: ");
            UiConsole.PrintLine($"Сумма элементов массива:  {array.Sum}");
            array.Inverse();
            array.Multi(UiConsole.GetInt("Введите множитель массива: "));
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i]=random.Next(5);
            }
            array.ToString("Массив случайных чисел: ");
            UiConsole.Print("Колличество максимальных элементов массива: ");
            UiConsole.PrintLine(array.CountMax);

            string fileName = "TaskTwo.txt";
            array.WriteToFile(fileName);
            array = new IntArray(fileName);
            array.ToString("Массив из файла: ");
            UiConsole.EndAndClear();
        }
    }
}
