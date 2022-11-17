using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_
{
    internal class Kitap : IComparable
    {
        public int KitapID { get; set; }
        public string KitapAdı { get; set; }
        public int Fiyat { get; set; }

        public int CompareTo(object? obj)
        {
            Kitap kitap = (Kitap)obj; //cast tür dönüşümü yaparız  //objeyi kitapa dönüştürdük
            return KitapID.CompareTo(kitap.KitapID); //kitap adlarını karşılaştırılabilr hale getirdik

        }
    }
}
