using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrzeciazanieOperatorow
{
    class KoszOwocow
    {
        public int jablka { get; set; }
        public int gruszki { get; set; }
        public int pomarancze { get; set; }

        public KoszOwocow(int jabIlosc, int gruIlosc, int pomIlosc)
        {
            jablka = jabIlosc;
            gruszki = gruIlosc;
            pomarancze = pomIlosc;
        }
        public static implicit operator int (KoszOwocow item) {return item.jablka;}

        public static KoszOwocow operator +(KoszOwocow owoce1,KoszOwocow owoce2)
        {
            return new KoszOwocow(owoce1.jablka+owoce2.jablka,
                                    owoce1.gruszki+owoce2.gruszki,
                                        owoce1.pomarancze+owoce2.pomarancze);
        }
        public static bool operator ==(KoszOwocow owoce1, KoszOwocow owoce2)
        {
            return owoce1.Equals(owoce2);
        }
        public static bool operator !=(KoszOwocow owoce1, KoszOwocow owoce2)
        {
            return !(owoce1.Equals(owoce2));
        }

        public override string ToString()
        {
            return "W koszu znajduje się: "+jablka+"jabłek, "+gruszki+"gruszek, "+pomarancze+"pomaranczy";
        }
        public override bool  Equals(object obj)
        {
 	        if (obj is KoszOwocow)
            {
                KoszOwocow porownywacz=(KoszOwocow)obj;
                return (this.jablka == porownywacz.jablka) && (this.pomarancze == porownywacz.pomarancze)
                    && (this.gruszki == porownywacz.gruszki);
            }
            else 
            {
                return false;
            }
        }
        public override int  GetHashCode()
        {
 	        return base.GetHashCode();
        }
    }
}
