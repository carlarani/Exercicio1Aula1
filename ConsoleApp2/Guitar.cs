using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Guitar : StringFamily
    {
        public int NumFret { get; set; }
        public Guitar(int NumFret, int NumStrings, string Maker, decimal Price) : base(NumStrings, Maker, Price)
        {
            this.NumFret = NumFret;
        }
    }
}
