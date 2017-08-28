using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class TaskFive
    {
        public static void Execute()
        {
            UiConsole.PrintLine("ЗАДАНИЕ 5");
            Doubler doubler = new Doubler();
            doubler.Game();
            UiConsole.EndAndClear();
        }
        
    }
}
