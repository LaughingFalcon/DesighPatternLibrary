using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Observer
{
    class Apostador
    {
        public string name;
        IObservador mediator;
        public int lastBet;
        public string lastPutter;
        public int maxBet;

        public Apostador(string name, IObservador mediator, int maxBet)
        {
            this.name = name;
            this.mediator = mediator;
            lastBet = 0;
            lastPutter = "";
            this.maxBet = maxBet;
        }

        public void sendMessage(int bet)
        {
            if(bet<=maxBet && bet>lastBet)
                mediator.sendNotification(bet,name);
        }
    }
}
