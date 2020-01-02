using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Decorator
{
    class BlueTunic: IHero
    {
        IHero hero;

        public BlueTunic(IHero hero)
        {
            this.hero = hero;
        }

        public double skillAllRound()
        {
            return (hero.skillAllRound() * 2);
        }

        public double skillUnderwater()
        {
            return (hero.skillUnderwater() * 4);
        }

        public double skillVulcano()
        {
            return (hero.skillVulcano());
        }
    }
}
