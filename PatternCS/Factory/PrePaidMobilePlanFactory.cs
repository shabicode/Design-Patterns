using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Factory
{
    internal class PrePaidMobilePlanFactory : BaseMobilePlanFactory
    {
        public override IMobilePlan CreateMobilePlan()
        {
            PrePaidMobilePlan prePaidMobilePlan = new PrePaidMobilePlan();
            prePaidMobilePlan.ConnectionSpeed = new ConnectionSpeed()
            {
                Name = "Low Connection Speed",
                Velocity = 50
            };
            prePaidMobilePlan.TextMessage = new TextMessage()
            {
                Name = "Post Paid Text Message",
                QuantityPerMonth = 2000
            };

            prePaidMobilePlan.PrePaidIntegration();
            return prePaidMobilePlan;
        }
    }
}
