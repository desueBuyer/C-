using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsInst
{
    class CoderLab4
    {
        public string Text { get; set; }

        public string Coder()
        {
            string finalString = null;
            foreach (var symbol in Text)
            {
                int ascii = symbol-1;
                finalString += ascii.ToString()+" ";
            }
            return finalString;
        }
    }
}
