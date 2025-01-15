using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Factory
{
    internal class ConnectionSpeed : IConnectionSpeed
    {
        public string Name { get; set; }
        public int Velocity { get; set; }
    }
}
