using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Piano:KeyboardFamily
    {
        enum type { electrical, acoustic};
        enum format { grandPiano, uprightPiano};
        int NumPedals { get; set; }
    }
}
