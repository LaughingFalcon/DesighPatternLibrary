using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Adapter
{
    class AdapterReve : ITransformAdapter
    {
        public int newNumber(string tipo1, string tipo2)
        {
            Revest revest = new Revest();
            var number = 0;
            var type = revest.newPoke(tipo1, tipo2);
            if (type.Equals("metalic"))
                number = 5;
            if (type.Equals("shadow"))
                number = 2;

            return number;

        }


    }
}
