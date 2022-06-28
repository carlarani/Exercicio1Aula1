using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Instrument
    {
        public decimal Price { get; set; }
        public string Maker { get; set; }

        public Instrument(string Maker, decimal Price)
        {
            this.Maker = Maker;
            this.Price = Price;
        }

        public Instrument()
        {

        }

    }
}
