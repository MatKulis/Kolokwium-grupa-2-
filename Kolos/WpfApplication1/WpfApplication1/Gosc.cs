using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Gosc
    {
        private string imie, nazwisko;
        public Gosc(string imie, string nazwisko)
        {
           imie = imie;
           nazwisko= nazwisko;
 
        }
        public virtual string ToString(string imie, string nazwisko)
        {
           return ("Gosc, "+imie+" "+nazwisko);
        }
    }
}
