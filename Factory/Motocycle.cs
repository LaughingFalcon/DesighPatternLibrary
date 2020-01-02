using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Factory
{
    public class Motocycle : IProduct
    {
        int tank;
        bool economic;
        string model;
        public Motocycle(string model, int tank, bool economic)
        {
            this.model = model;
            this.tank = tank;
            this.economic = economic;
        }
        public double efficiency()
        {
            if (economic)
                return 1 + ((1 / 4) );
            else
                return 1 + (1 / 2);
        }

        public double time()
        {
            return tank / efficiency();
        }
    }
}
