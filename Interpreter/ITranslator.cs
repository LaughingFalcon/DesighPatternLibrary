using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Interpreter
{
    interface ITranslator
    {
        string ToPortuguese(string text);
        string ToPe(string text);
        string ToLeet(string text);
    }
}
