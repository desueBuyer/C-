using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsInst
{
    class DecoderLab4
    {
        public string Text { get; set; }

        public string Decoder()
        {
            string finalString = null;
            List<string> list = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var e in list)
            {
                int num = int.Parse(e) + 1;
                char symbol = (char)num;
                finalString += symbol.ToString();
            }
            return finalString;
        }
    }
}
