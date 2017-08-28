using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class IntMass
    {
        private int[,] _mass;
        Random random = new Random();

#region Конструкторы
        public IntMass(int row, int col)
        {
            _mass = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    _mass[i, j] = 0;
                }
            }
        }

        public IntMass(int row, int col, int max)
        {
            _mass = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    _mass[i, j] = random.Next(max);
                }
            }
        }

        public IntMass(string fileName)
        {
            int row, col;
            if (File.Exists(fileName))
            {
                string[] sRow = File.ReadAllLines(fileName);
                row = sRow.Length;
                string[] sCol = sRow[0].Split(' ');
                col= sCol[sCol.Length-1]!="" ? sCol.Length : sCol.Length-1;
                _mass = new int[row, col];
                for (int i = 0; i < row; i++)
                {
                    sCol = sRow[i].Split(' ');
                    for (int j = 0;j<col;j++)
                    {
                        _mass[i,j] = int.Parse(sCol[j]);
                    }
                }
            }
        }
        #endregion

        public int[,] Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        public int this[int index1, int index2]
        {
            get { return Mass[index1, index2]; }
            set { Mass[index1, index2] = value; }
        }

        public void Print(string msg="")
        {
            if (msg != "")
            {
                UiConsole.PrintLine(msg);
            }
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    UiConsole.Print($"{Mass[i,j]} ");
                }
                UiConsole.PrintLine();
            }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    sum += Mass[i, j];
                }
            }
            return sum;
        }

        public int Sum(int min)
        {
            int sum = 0;
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    if (Mass[i, j] > min)
                    {
                        sum += Mass[i, j];
                    }
                }
            }
            return sum;
        }

        public int Min
        {
            get
            {
                int min = _mass[0, 0];
                for (int i = 0; i < _mass.GetLength(0); i++)
                {
                    for (int j = 0; j < _mass.GetLength(1); j++)
                    {
                        if (_mass[i, j] < min)
                        {
                            min= _mass[i, j];
                        }
                    }
                }
                return min;
            }
        }

        public int Max
        {
            get
            {
                int max = _mass[0, 0];
                for (int i = 0; i < _mass.GetLength(0); i++)
                {
                    for (int j = 0; j < _mass.GetLength(1); j++)
                    {
                        if (_mass[i, j] > max)
                        {
                            max = _mass[i, j];
                        }
                    }
                }
                return max;
            }
        }

        public int MaxCount
        {
            get
            {
                var count = 0;
                for (int i = 0; i < _mass.GetLength(0); i++)
                {
                    for (int j = 0; j < _mass.GetLength(1); j++)
                    {
                        if (_mass[i, j] == Max)
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
        }

        public IntMass IndexMax()
        {
            
                IntMass indexMass = new IntMass(MaxCount, 2);
                var n = 0;
                for (int i = 0; i < Mass.GetLength(0); i++)
                {
                    for (int j = 0; j < Mass.GetLength(1); j++)
                    {
                        if (Mass[i, j] == Max)
                        {
                            indexMass[n, 0] = i;
                            indexMass[n, 1] = j;
                            n++;
                        }
                    }
                }
                return indexMass;
            

        }

        public void WriteToFile(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                for (int i = 0; i < Mass.GetLength(0); i++)
                {
                    for (int j = 0; j < Mass.GetLength(1); j++)
                    {
                        {
                            streamWriter.Write($"{Mass[i, j]} ");
                        }
                    }
                    streamWriter.WriteLine();
                }
            }
        }

        
    }
}
