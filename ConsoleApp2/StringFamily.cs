using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StringFamily : Instrument
    {
        public int NumStrings { get; set; }
        public StringFamily(int NumStrings, String Maker, decimal Price) : base(Maker, Price)
        {
            NumStrings = NumStrings;
        }
        public StringFamily()
        {

        }

    }
}
