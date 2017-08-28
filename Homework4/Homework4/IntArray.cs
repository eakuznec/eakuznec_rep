using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class IntArray
    {
        private int[] _arr;

#region Конструкторы
        public IntArray(int size)
        {
            _arr = new int[size];
        }

        public IntArray(int size=1, int first=0,int step=1)
        {
            _arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                _arr[i] = first + i * step;
            }
        }

        public IntArray(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] ss = File.ReadAllLines(fileName);
                _arr = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                {
                    _arr[i] = int.Parse(ss[i]);
                }
            }
        }

        #endregion
        public int[] Arr
        {
            get { return _arr; }
            set { _arr = value; }
        }

        public int this[int index]
        {
            get { return Arr[index]; }
            set { Arr[index] = value; }
        }

        public int Sum
        {
            get
            {
                var sum = 0;
                for (int i = 0; i < Arr.Length; i++)
                {
                    sum += Arr[i];
                }
                return sum;
            }
        }

        public int CountMax
        {
            get
            {
                var max=Arr[0];
                var count = 0;
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i] == max)
                    {
                        count++;
                    } else if (Arr[i] > max)
                    {
                        max = Arr[i];
                        count = 1;
                    }
                }
                return count;

            }
        }

        public void Multi(int multi = 1)
        {
            for(int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Arr[i]*multi;
            }
            ToString($"Массив домноженный на {multi}: ");
        }

        public void Inverse()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = -1 * _arr[i];
            }
            ToString($"Инверсный массив: ");
        }

        public int Lenght
        {
            get
            {
                return Arr.Length;
            }
        }

        public void ToString(string msg="")
        {
            UiConsole.Print(msg);
            for(int i=0;i<Arr.Length;i++)
            {
                UiConsole.Print($"{Arr[i]} ");
            }
            UiConsole.PrintLine();
        }

        public void WriteToFile(string path)
        {
            if (String.IsNullOrEmpty(path)) return;
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    streamWriter.WriteLine($"{Arr[i]}");
                }
            }
        }
    }
}
