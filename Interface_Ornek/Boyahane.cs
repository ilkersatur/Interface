using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek
{
    internal class Boyahane
    {
        public void Boya(IBoyanabilirlik arac, ConsoleColor yenirenk) //metodun parametresi interface
        {
            ((Araç)arac).Renk = yenirenk;
        }
    }
}
