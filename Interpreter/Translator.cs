using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Interpreter
{
    public class Translator
    {
        public static string LeetToPortuguese(string text)
        {
            text = text.Replace("0", "o");
            text = text.Replace("1", "i");
            text = text.Replace("3", "e");
            text = text.Replace("4", "a");
            return text;
        }
        public static string PeToPortuguese(string text)
        {
            text = text.ToLower();
            text = text.Replace("pp", "P");
            text = text.Replace("p", "");

            return text;
        }
        public static string ClientToCsv(Client client)
        {
            string texto = "\""+client.name + "\"," + client.idade + ",\"" + client.country+ "\"";
            return texto;
        }
    }
}
