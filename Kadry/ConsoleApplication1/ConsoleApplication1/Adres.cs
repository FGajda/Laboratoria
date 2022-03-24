using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Adres
    {
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }

        public Adres(string Ulica, string NumerDomu, string KodPocztowy,string Miasto) 
        {
            this.Ulica = Ulica;
            this.NumerDomu = NumerDomu;
            this.KodPocztowy = KodPocztowy;
            this.Miasto = Miasto;
        }
    }
}
