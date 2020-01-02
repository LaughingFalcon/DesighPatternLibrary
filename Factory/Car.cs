using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Factory
{
    public class Car : IProduct
    {
        int traction;
        int tank;
        bool economic;
        string model;
        public Car(string model, int traction, int tank, bool economic)
        {
            this.model = model;
            this.traction= traction;
            this.tank= tank;
            this.economic= economic;
        }
        public double efficiency()
        {
            if (economic)
                return 1+((1 / traction) / 2);
            else
                return 1+(1 / traction);
        }

        public double time()
        {
            return tank / efficiency();
        }
    }
}
