using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Umowa
    {
        public string DataZawarcia { get; set; }
        public string TypUmowy { get; set; }
        public int CzasUmowy { get; set; }

        public Umowa(string DataZawarcia, string TypUmowy, int CzasUmowy) 
        {
            this.DataZawarcia = DataZawarcia;
            this.TypUmowy = TypUmowy;
            this.CzasUmowy = CzasUmowy;
        }
    }
}
