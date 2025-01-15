using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Factory
{
    internal class PrePaidMobilePlan : IMobilePlan
    {
        public IConnectionSpeed ConnectionSpeed { get; set; }
        public ITextMessage TextMessage { get; set; }

        public void PrePaidIntegration() { }
    }
}
