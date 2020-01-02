using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Decorator
{
    class WaterArmor : IHero
    {
        IHero hero;

        public WaterArmor(IHero hero)
        {
            this.hero = hero;
        }

        public double skillAllRound()
        {
            return (hero.skillAllRound() * 2);
        }

        public double skillUnderwater()
        {
            return (hero.skillUnderwater() * 9);
        }

        public double skillVulcano()
        {
            return (hero.skillVulcano());
        }
    }
}
