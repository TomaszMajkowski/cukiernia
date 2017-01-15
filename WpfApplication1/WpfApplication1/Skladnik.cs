using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    class Skladnik :IComparable
    {
        private string nazwaSkladniku;
        private string ilosc;
        private double cenaSkladnika;


        public Skladnik(string nazwaSkladniku, string ilosc, double cenaSkladnika) //konstruktor parametryczny
        {
            this.nazwaSkladniku = nazwaSkladniku;
            this.cenaSkladnika = cenaSkladnika;
            this.ilosc = ilosc;
        }

        public double PodajCeneLaczna() //metoda zwracająca cenę łączną
        {
            return Math.Round(cenaSkladnika * Convert.ToInt32(ilosc), 2);
        }

        public override string ToString() //metoda zwracająca informacje o produkcie
        {
            return nazwaSkladniku + ", " + cenaSkladnika + " * " + ilosc + " = " + PodajCeneLaczna();
        }
        public double PobierzCene()
        {
            return cenaSkladnika;
        }

        public int CompareTo(Skladnik obj)
        {
            if (this.nazwaSkladniku == obj.nazwaSkladniku) return this.ilosc.CompareTo(obj.ilosc);
            return obj.nazwaSkladniku.CompareTo(this.nazwaSkladniku);
        }
    }
}
    