using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3 
{
    class Osoba : ICloneable
    {
        private int wiek; //deklaracja pola
        public Osoba() { } //konstruktor domyślny
        public Osoba(int wiek) //konstruktor parametryczny
        {
            this.wiek = wiek;
        }
        public void UstawWiek(int wiek) //metoda na ustawienie wieku
        {
            this.wiek = wiek;
        }
        public int PobierzWiek() //metoda na pobranie wieku
        {
            return wiek;
        }

        public Object Clone() //implementacja metody Clone
        {
            return MemberwiseClone();
        }

    }
}
