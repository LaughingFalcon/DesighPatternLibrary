using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.NullObject
{
    public class Queue
    {
        IQueue queue;
        public Queue()
        {
            Random random = new Random();
            queue = new QueueItem("Maicom Giéquisom", random.Next(100),
                new QueueItem("Éuvis Pliestlei", random.Next(100),
                new QueueItem("Estive Jóbis", random.Next(100),
                new QueueItem("Arnoudi Chuazinéguer", random.Next(100),
                new QueueItem("Silvestre Estaloni", random.Next(100)
            )))));
        }
        public IQueue GetQueue()
        {
            return queue;
        }
    }
}
