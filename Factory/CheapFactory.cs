using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Factory
{
    class CheapFactory : IFactory
    {
        public IProduct createProduct(string type, int t, bool economic)
        {
            IProduct newProduct = new Car(type, t, 80, economic);
            return newProduct;
        }
        public IProduct createProduct(string type, bool economic)
        {
            IProduct newProduct = new Motocycle(type, 40, economic);

            return newProduct;
        }
    }
}
