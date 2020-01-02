using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Decorator
{
    class IronBoot : IHero
    {
        IHero hero;

        public IronBoot(IHero hero)
        {
            this.hero = hero;
        }

        public double skillAllRound()
        {
            return (hero.skillAllRound() * 0.8);
        }

        public double skillUnderwater()
        {
            return (hero.skillUnderwater() * 4);
        }

        public double skillVulcano()
        {
            return (hero.skillVulcano() * 0.8);
        }
    }
}
