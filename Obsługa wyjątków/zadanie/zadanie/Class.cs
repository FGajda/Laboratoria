using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie
{
    class Class
    {
        private int zw;
        public int w1
        {
            get
            {
                return zw;
            }
            set 
            {
                try
                {
                    zw = rangeCheckValue(value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0}", ex);
                }
            }
        }
        public int kw { set; get; }

        private int rangeCheckValue(int k)
        {
            if (k > 32)
            {
                throw new ArgumentException("Złe wartości");
            }
            return k;
        }

        public Class(int a) { zw = a; }
    }
}
