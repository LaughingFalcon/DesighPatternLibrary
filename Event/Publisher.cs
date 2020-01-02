using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Event
{
    public class Publisher
    {
        int info2;
        int info1;
        IEventAggregator aggregator;
        public Publisher(IEventAggregator EventAggregator)
        {
            aggregator = EventAggregator;
            info1 = 3;
            info2 = info1*10;
            aggregator.Publish(info1, info2);
        }

        public void updateInfo(int info1, int info2)
        {
            this.info1 = info1;
            this.info2 = info2;
            aggregator.Publish(info1, info2);
        }
        public void updateInfo(int info1)
        {
            this.info1 = info1;
            info2 = info1 * 10;
            aggregator.Publish(info1, info2);
        }
    }
}
