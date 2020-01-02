using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Adapter
{
    class AdapterMega : ITransformAdapter
    {
        bool isTreined;

        public AdapterMega(bool treined)
        {
            this.isTreined = treined;
        }
        public int newNumber(string tipo1, string tipo2)
        {
            MegaEvolution megaForm = new MegaEvolution();
            var newNumber = 1;
            if (isTreined)
                newNumber = newNumber + 3;
            else
                newNumber = newNumber + 1;

            newNumber += (int)megaForm.newNumber(tipo1, tipo2);


            return newNumber;
        }
    }
}
