using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class UiConsole
    {
        public static void PrintLine(string s="")
        {
            Console.WriteLine(s);
        }

        public static void PrintLine(int s)
        {
            Console.WriteLine(s);
        }

        public static void Print(string s = "")
        {
            Console.Write(s);
        }

        public static string GetString(string msg="")
        {
            UiConsole.Print(msg);
            return Console.ReadLine();
        }

        public static void Pause()
        {
            Console.ReadKey();
        }

        public static void EndAndClear()
        {
            Pause();
            Console.Clear();
        }

        public static int GetInt()
        {
            int x;
            bool flag; 
            do
            {
                flag = int.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);
            return x;
        }

        public static int GetInt(string msg)
        {
            UiConsole.Print(msg);
            int x;
            bool flag;
            do
            {
                flag = int.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);
            return x;
        }
    }
}
