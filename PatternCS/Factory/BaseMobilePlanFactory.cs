using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Factory
{
    internal abstract class BaseMobilePlanFactory
    {
        public IMobilePlan GetMobilePlan()
        {
            IMobilePlan mobilePlan = this.CreateMobilePlan();
            return mobilePlan;
        }
        public abstract IMobilePlan CreateMobilePlan();
    }
}
