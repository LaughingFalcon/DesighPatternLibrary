using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Adapter
{
    public class PocketMonster
    {
        public string nome;
        string tipo1;
        string tipo2;
        public double hp;
        double attack;
        double defese;
        double specialAttack;
        double specialDefese;
        double speed;

        public PocketMonster(string nome, string tipo1, string tipo2, double baseNumber)
        {
            this.nome = nome;
            this.tipo1 = tipo1;
            this.tipo2 = tipo2;
            this.hp = baseNumber*10;
            this.attack = baseNumber*3;
            this.defese = baseNumber*2;
            this.specialAttack = baseNumber*2;
            this.specialDefese = baseNumber*3;
            this.speed = baseNumber*1;

        }

        public void transform(ITransformAdapter newForm)
        {
            var newNumber = newForm.newNumber(tipo1, tipo2);

            this.hp = (hp+newNumber) * 10.0;
            this.attack = (attack+newNumber) * 3.0;
            this.defese = (defese+newNumber) * 2.0;
            this.specialAttack = (specialAttack+newNumber) * 2.0;
            this.specialDefese = (specialDefese+newNumber) * 3.0;
            this.speed = (speed+newNumber) * 1.0;
        }

        public void baseform(ITransformAdapter newForm)
        {
            var newNumber = newForm.newNumber(tipo1, tipo2);

            this.hp = (hp / 10.0) - newNumber;
            this.attack = (attack / 3.0) - newNumber;
            this.defese = (defese / 2.0) - newNumber;
            this.specialAttack = (specialAttack / 2.0) - newNumber;
            this.specialDefese = (specialDefese / 3.0) - newNumber;
            this.speed = (speed / 1.0) - newNumber;
        }

    }
}
