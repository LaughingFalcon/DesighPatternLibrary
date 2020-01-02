using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.NullObject
{
    public class QueueItem: IQueue
    {
        string name;
        int value;
        public IQueue next;
        public QueueItem(string name, int value)
        {
            this.name = name;
            this.value = value;
            next = new QueueNull();
        }
        public QueueItem(string name, int value, IQueue next)
        {
            this.name = name;
            this.value = value;
            this.next = next;
        }

        public int GetValue()
        {
            Console.WriteLine(name+" inclui "+value+" na conta");
            return value + next.GetValue();
        }
    }
}
