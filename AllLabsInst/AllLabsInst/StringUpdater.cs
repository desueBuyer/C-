using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsInst
{
    class StringUpdater
    {
        public string Sentence;

        public  string StringUpdate()
        {
            StringBuilder bldr = new StringBuilder();
            foreach (var symbol in Sentence)
            {
                int symbolNum = (int)symbol;
                symbolNum += 2;
                bldr.Append((char)symbolNum);
            }
            return bldr.ToString();
        }
    }
}
