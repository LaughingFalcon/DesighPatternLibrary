using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Observer
{
    interface IObservador
    {
        void sendNotification(int notification,string sender);
        void add(Apostador newGuy);
    }
}
