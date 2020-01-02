using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Prototype
{
    public interface IRobot
    {
        IRobot Clone();
        string info();
    }
}
