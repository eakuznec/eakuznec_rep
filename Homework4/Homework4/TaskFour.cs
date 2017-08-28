using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class TaskFour
    {
        public static void Execute()
        {
            UiConsole.PrintLine("ЗАДАНИЕ 4");
            IntMass intMass = new IntMass(3, 4, 20);
            intMass.Print("Двумерный массив: ");
            UiConsole.PrintLine($"Сумма элементов: {intMass.Sum()}");
            UiConsole.PrintLine($"Сумма элементов больше 10: {intMass.Sum(10)}");
            UiConsole.PrintLine($"Минимальный элемент: {intMass.Min}");
            UiConsole.PrintLine($"Максимальный элемент: {intMass.Max}");
            intMass.IndexMax().Print("Индексы максимального элемента: ");
            string fileName = "TaskFour.txt";
            intMass.WriteToFile(fileName);
            intMass = new IntMass(fileName);
            intMass.Print("Массив из файла:");
            UiConsole.EndAndClear();
        }
    }
}
