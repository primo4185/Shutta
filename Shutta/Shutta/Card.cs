using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    public class Card
    {
        public int Number;
        public bool isKwang;
        public string ToText()
        {
            string text = Number.ToString();
            if (isKwang)
                text += "K";

            return text;
        }
    }
}