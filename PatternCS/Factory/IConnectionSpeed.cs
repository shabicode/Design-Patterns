using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Factory
{
    internal interface IConnectionSpeed
    {
        string Name { get; set; }
        int Velocity { get; set; }

    }
}
