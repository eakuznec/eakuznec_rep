using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class TaskOne
    {
        public static void Execute()
        {
            UiConsole.PrintLine("ЗАДАНИЕ 1");
            var size = 20;
            Random random = new Random();
            IntArray array = new IntArray(size);
            for (int i = 0; i < size; i++)
            {
                array[i]=random.Next(-10000, 10001);
            }
            array.ToString("Исходный массив: ");

            UiConsole.PrintLine();
            var count = 0;
            UiConsole.PrintLine("Пары чисел:");
            for(int i = 0; i < size-1; i++)
            {
                if ((array[i] % 3 == 0) || (array[i+1] % 3 == 0))
                {
                    UiConsole.PrintLine( $"{array[i]} {array[i+1]}");
                    count++;
                }
            }
            UiConsole.PrintLine($"Число пар: {count}");
            UiConsole.EndAndClear();
        }
    }
}
