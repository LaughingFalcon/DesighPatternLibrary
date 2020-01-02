using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Decorator
{
    class Challenger
    {
        double underwater;
        double vulcano;
        double all;

        public Challenger()
        {
            this.underwater = 0.9;
            this.vulcano = 0.5;
            this.all = 0.1;
        }

        public void Quests(IHero hero)
        {
            if (hero.skillUnderwater() >= underwater)
                Console.WriteLine("Passou no teste da água");
            else
                Console.WriteLine("Falhou no teste da água");

            if (hero.skillVulcano() >= vulcano)
                Console.WriteLine("Passou no teste do fogo");
            else
                Console.WriteLine("Falhou no teste do fogo");

            if (hero.skillAllRound() >= underwater)
                Console.WriteLine("Passou nos testes gerais");
            else
                Console.WriteLine("Falhou nos testes gerais");
        }
    }
}
