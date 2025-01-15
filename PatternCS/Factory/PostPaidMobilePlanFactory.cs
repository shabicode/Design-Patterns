using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Factory
{
    internal class PostPaidMobilePlanFactory : BaseMobilePlanFactory
    {
        public override IMobilePlan CreateMobilePlan()
        {
            PostPaidMobilePlan prePaidMobilePlan = new PostPaidMobilePlan();
            prePaidMobilePlan.ConnectionSpeed = new ConnectionSpeed()
            {
                Name = "High Connection Speed",
                Velocity = 100
            };
            prePaidMobilePlan.TextMessage = new TextMessage()
            {
                Name = "Post Paid Text Message",
                QuantityPerMonth = 5000
            };

            prePaidMobilePlan.PostPaidIntegration();
            return prePaidMobilePlan;
        }
    }
}
