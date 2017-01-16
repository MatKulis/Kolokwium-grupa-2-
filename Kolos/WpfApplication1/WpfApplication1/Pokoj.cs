using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Pokoj : IComparable
    {
        private int nrPokoju;
        private double cenaZaDzien;
        public Pokoj(int nrPokoju, double cenaZaDzien)
        {
            nrPokoju = nrPokoju;
            cenaZaDzien = cenaZaDzien;

        }
        public virtual string ToString(string imie, string nazwisko)
        {
            return ("Pokoj, nr: " + imie + " cena za dzień: " + nazwisko);
        }
        public int MetodaNrPokoju()
        {
            return (nrPokoju);
        }
        public double MetodaCenaZaDzien()
        {
            return (cenaZaDzien);
        }
        public int CompareTo(object nrPokoju)
        {
            if (nrPokoju == null) return 1;

            Pokoj innynrPokoju = nrPokoju as Pokoj;
            if (innynrPokoju != null)
                return this.nrPokoju.CompareTo(innynrPokoju.nrPokoju);
            else
                throw new ArgumentException("Obiekt nie ma przypisanego numeru");            

        }
    }
}
