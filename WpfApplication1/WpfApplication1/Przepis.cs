using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    class Przepis 
    {
        private string nazwa;
        private double suma ;
        private int czasPrzygotowania;
        private List<Skladnik> skladniki;

        public void DodajSkladnik(string nazwaSkladnika, string ilosc, double cenaSkladnika)  //implementaca metody na dodanie produku do zakupów
        {
           skladniki.Add(new Skladnik(nazwaSkladnika, ilosc, cenaSkladnika));
        }

        public void UstawNazweCzas(string nazwa, int czasPrzygotowania)
        {
            this.nazwa = nazwa;
            this.czasPrzygotowania = czasPrzygotowania;
        }

        public override string ToString()
        {
            string Przepis = nazwa;
            double suma = 0;
            for (int i = 0; i < skladniki.Count; i++)
            {
                Przepis += Environment.NewLine + "[" + i + "] " + skladniki[i].ToString();
                suma += skladniki[i].PodajCeneLaczna();
            }
            Przepis += Environment.NewLine + "Suma: " + suma;
            return Przepis;
        }
        public bool CzyCzas()
        {
            if(czasPrzygotowania>0)
            return(true);
            else
            return(false);
        }

        public int IleSkladnikow()
        {
            int liczbaskladnikow = 0;
            foreach (var element in skladniki)
            {
                liczbaskladnikow += 1;

            }
            return liczbaskladnikow;
        }

    }
}
