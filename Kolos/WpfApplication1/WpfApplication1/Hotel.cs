using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Hotel:IHotel,IData
    {
        private SortedDictionary<Pokoj,Gosc> rezerwacja;
        private double zysk = -80;
        private DateTime data;

        public void DodajRezerwacje(string imie, string nazwisko, int nr, double cena)
        {
          
        }
        public void OdwołajRezerwacje()
        {
        
        } 
        public void UstawDate(DateTime data)
        {
          
        }
        public bool SprawdzDate() 
        {                                    
         
            
            return true;                   
            
        }
       
    }
}
