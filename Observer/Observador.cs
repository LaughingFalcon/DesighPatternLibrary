using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Observer
{
    class Observador : IObservador
    {
        List<Apostador> gang;
        public Observador()
        {
            gang = new List<Apostador>();
        }
        public void add(Apostador newGuy)
        {
            gang.Add(newGuy);
        }

        public void sendNotification(int notification, string sender)
        {
            foreach (Apostador guy in gang)
            {
                guy.lastBet = notification;
                guy.lastPutter = sender;
            }
        }
    }
}
