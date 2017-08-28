using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Doubler
    {
        Random random = new Random();
        private int _current;
        private int _finish;
        
        public Doubler()
        {
            Current = 1;
            Finish = random.Next(100, 200);
        }

        public int Current
        {
            get
            {
                return _current;
            }
            set
            {
                _current = value;
            }
        }

        public int Finish
        {
            get
            {
                return _finish;
            }
            set
            {
                _finish = value;
            }
        }

        public void CommandOne()
        {
            Current++;
        }

        public void CommandTwo()
        {
            Current=Current*2;
        }

        public void CommandThree()
        {
            Current = 1;
        }

        public void Game()
        {
            UiConsole.PrintLine($"Игра \"УДВОИТЕЛЬ\"\nЗадача игрока преобразовать начальное число c текущим значением {Current} в финальное - {Finish}, используя три команды:\n1 - увеличить текущее значение на 1;\n2 - увеличить текущее значение в 2 раза;\n3 - сбросить текущее значение до 1.\nПостарайтесь сделать это за наименьшее количество ходов. Если текущее значение числа превысит финальное, то вы проиграете!");
            
            var step = 0;
            var caseSwitch = 0;
            do
            {
                step++;
                caseSwitch =UiConsole.GetInt($"Ход: {step} - Текущее значение: {Current} - Команда: ");
                switch (caseSwitch)
                {
                    case 1:
                        CommandOne();
                        break;
                    case 2:
                        CommandTwo();
                        break;
                    case 3:
                        CommandThree();
                        break;
                } 
            } while (Current < Finish);
            UiConsole.PrintLine();
            UiConsole.PrintLine((Current == Finish) ? $"Победа!!! Вам понадобилось {step} ходов." : "Проигрыш! Вы превысили конечное число. =((");
        }
        
    }
}
