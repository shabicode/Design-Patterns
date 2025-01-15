using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Factory
{
    internal interface ITextMessage
    {
        string? Name { get; set; }
        int  QuantityPerMonth { get; set; }
    }
}
