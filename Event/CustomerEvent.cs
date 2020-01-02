using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Event
{
    public class CustomerEvent: ISubscriber
    {
        int info1;
        int info2;
        public CustomerEvent()
        {
            info1 = -1;
            info2 = -1;
        }
        public Publisher createPublisher(IEventAggregator aggregator)
        {
            Publisher publisher = new Publisher(aggregator);
            return publisher;
        }
        public void update(int info1, int info2){
            if (info1 != this.info1)
            {
                Console.WriteLine("Customer descobriu que info1 mudou");
                this.info1 = info1;
            }
            if (info2 != this.info2)
            {
                Console.WriteLine("Customer descobriu que info2 mudou");
                this.info2 = info2;
            }

        }
    }
}
