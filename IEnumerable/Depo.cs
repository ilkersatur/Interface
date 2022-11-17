using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_
{
    internal class Depo : IEnumerable //depo sınıfını foreach te çalışılabilir hale getirdik
    {
        string[] depo = { "Ürün1", "Ürün2", "Ürün3" };

        public IEnumerator GetEnumerator()
        {
            return depo.GetEnumerator();
        }
    }
}
