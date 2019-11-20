using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsInst
{
    class StringDereverse
    {
        public string Text { get; set; }

        public List<string> Dictionary { get; set; }

        public string Decoder()
        {
            string finalText = null;
            if (Dictionary.Count > 0)
            {
                int counter = 0;
                foreach (var line in Dictionary)
                {
                    int subcounter = 0;
                    foreach (var letter in line)
                    {
                        if (!char.IsDigit(letter))
                        {
                            foreach (var elemnt in Text)
                            {
                                if (elemnt == letter)
                                    subcounter++;
                            }
                        }
                    }
                    if (counter < subcounter)
                    {
                        finalText = line;
                        counter = subcounter;
                    }
                }
            }
            return finalText;
        }
    }
}
