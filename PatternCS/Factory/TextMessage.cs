using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Factory
{
    internal class TextMessage : ITextMessage
    {
        public string? Name { get; set; }
        public int QuantityPerMonth { get; set; }
    }
}
