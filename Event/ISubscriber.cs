using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Event
{
    public interface ISubscriber
    {
        void update(int info1, int info2);
    }
}
