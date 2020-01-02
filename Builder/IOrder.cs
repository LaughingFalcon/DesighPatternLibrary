using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Builder
{
    interface IOrder
    {
        void chooseBread(string type, bool isTosted);
        void chooseCheese(List<string> type);
        void chooseSalad(List<string> type);
        void chooseSauce(List<string> type);
        void chooseMeat(string type);

    }
}
