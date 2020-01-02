using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Event
{
    public class EventAggregator : IEventAggregator
    {
        List<ISubscriber> list;
        public EventAggregator()
        {
            list = new List<ISubscriber>();
        }
        public void Publish(int info1, int info2)
        {
            foreach (ISubscriber obj in list)
            {
                obj.update(info1,info2);
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            list.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            list.Remove(subscriber);
        }
    }
}
