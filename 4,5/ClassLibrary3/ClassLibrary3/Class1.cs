using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary3
{
    public class Class1
    {
        public static int[,] Tab2D(int Size1, int Size2)
        {
            Random A = new Random();
            int[,] Tab = new int[Size1,Size2];
            for (int i = 0; i < Size1; i++)
            {
                for (int j = 0; j < Size2; j++)
                {
                    Tab[i, j] = A.Next(100);
                }
            }
            return Tab;
        }
    }
}
