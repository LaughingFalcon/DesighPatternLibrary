using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesighPatternLibrary.Composite
{
    class Clan : IMercenary
    {
        string name;
        int moneyBank;
        public List<IMercenary> gang;

        public Clan(string name)
        {
            this.name = name;
            moneyBank = 0;
            gang = new List<IMercenary>();
        }

        public void NewMember(IMercenary newMember)
        {
            gang.Add(newMember);
        }
        public void data()
        {
            Console.WriteLine("Clan: "+name+" Quantidade de Membros: "+ gang.Count() + " Grana reserva: "+moneyBank);
            foreach (IMercenary member in gang)
            {
                member.data();
            }
        }
        public void payment(int value)
        {
            int leftover = value % gang.Count();
            int money = 0;
            if (leftover != 0)
            {
                moneyBank = leftover;
                money = (value - leftover) / gang.Count();
            }
            else
                money = value / gang.Count();
            foreach(IMercenary member in gang)
            {
                member.payment(money);
            }

        }
    }
}
