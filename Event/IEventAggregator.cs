using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Event
{
    public interface IEventAggregator
    {
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void Publish(int info1, int info2);
    }
}
