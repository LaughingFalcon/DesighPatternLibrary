using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Decorator
{
    class RedTunic: IHero
    {
        IHero hero;

        public RedTunic(IHero hero)
        {
            this.hero = hero;
        }

        public double skillAllRound()
        {
            return (hero.skillAllRound() * 2);
        }

        public double skillUnderwater()
        {
            return (hero.skillUnderwater());
        }

        public double skillVulcano()
        {
            return (hero.skillVulcano() *3);
        }
    }
}
