using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek
{
    internal class BMX : Araç
    {
        public override string ToString()
        {
            Console.ForegroundColor = Renk;
            return "BMX";
        }
    }
}
