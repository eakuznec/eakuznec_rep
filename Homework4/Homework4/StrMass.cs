using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class StrMass
    {
        string[,] _mass;

        public StrMass(int row,int col)
        {
            _mass = new string[row, col];
        }

        public StrMass(string fileName, int row, int col)
        {
            _mass = new string[row, col];
            if (File.Exists(fileName)) 
            using (StreamReader streamReader = new StreamReader(fileName, Encoding.Default))
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        _mass[i, j] = streamReader.ReadLine();
                    }
                }
            }            
        }

        public string[,] Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        public string this[int index1, int index2]
        {
            get { return Mass[index1, index2]; }
            set { Mass[index1, index2] = value; }
        }

        public void SetColumn(int col, string login, string password)
        {
            Mass[0, col] = login;
            Mass[1, col] = password;
        }
        
        public bool CompareColumn(int col1, int col2)
        {
           
            return (Mass[0, col1] == Mass[0, col2]) && (Mass[1, col1] == Mass[1, col2])? true  : false;
            
        }
    }
}
