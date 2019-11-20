using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsInst
{
    class StringReverse
    {
        public  string MainString;

        public string String()
        {
                string sentence = MainString;
                return Reverse(sentence);
        }

        public  string Reverse(string sentece)
        {
                StringBuilder bldr = new StringBuilder();
                char[] symbols = sentece.ToArray();
                for (int i = symbols.Length - 1; i > -1; i--)
                {
                    if ((i + 1) % 2 == 0)
                        bldr.Append(i + 1);
                    else bldr.Append(symbols[i]);
                }
                return bldr.ToString();
        }
    }
}



