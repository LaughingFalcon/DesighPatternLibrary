using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.ChainOfResponsibility
{
    public interface IEmployee
    {
        bool RequestMoney(int value);
        bool HasHigher();
        void SetHigher(IEmployee boss);
    }
}
