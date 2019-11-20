using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsInst
{
    class StringDeupdater
    {
        public string Sentence;

        public string StringDec()
        {
            StringBuilder bldr = new StringBuilder();
            foreach (var symbol in Sentence)
            {
                int symbolNum = (int)symbol;
                symbolNum -= 2;
                bldr.Append((char)symbolNum);
            }
            return bldr.ToString();
        }
    }
}
