using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek
{
    internal class Serce : Araç, IBoyanabilirlik
    {
        public override string ToString()
        {
            Console.ForegroundColor = Renk;
            return "Serçe";
        }
    }
}
