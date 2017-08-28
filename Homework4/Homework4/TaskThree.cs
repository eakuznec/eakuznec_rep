using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class TaskThree
    {
        public static void Execute()
        {
            UiConsole.PrintLine("ЗАДАНИЕ 3");
            string fileName = "TaskThree.txt";
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                streamWriter.WriteLine("root");
                streamWriter.WriteLine("GeekBrains");
            }
            
            StrMass strArray = new StrMass(2, 4);
            StreamReader streamReader = new StreamReader(fileName);
            strArray.SetColumn(0,streamReader.ReadLine(), streamReader.ReadLine());
            streamReader.Close();

            var check = false;
            for (int i = 1; i < 4; i++)
            {
                UiConsole.PrintLine($"Попытка {i}");
                strArray.SetColumn(i,UiConsole.GetString("Введите логин: "),UiConsole.GetString("Введите пароль: "));
                if (strArray.CompareColumn(0, i))
                {
                    check = true;
                    break;
                }
            }
            UiConsole.PrintLine(check?"Вы вошли в систему.":"Доступ запрещен!");
            UiConsole.EndAndClear();
        }
    }
}
