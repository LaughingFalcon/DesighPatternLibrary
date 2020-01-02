using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Factory
{
    interface IFactory
    {
        IProduct createProduct(string type, bool economic);
        IProduct createProduct(string type, int t, bool economic);
    }
}
