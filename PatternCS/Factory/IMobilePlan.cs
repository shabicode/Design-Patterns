using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Factory
{
    internal interface IMobilePlan
    {
        IConnectionSpeed ConnectionSpeed { get; set; }
        ITextMessage TextMessage { get; set; }

    }
}
