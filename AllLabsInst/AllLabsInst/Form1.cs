using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllLabsInst
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ListChecker(textBox1.Text);
            var reverse = new StringReverse { MainString = textBox1.Text };
            textBox2.Text = reverse.String();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var decoder = new StringDereverse { Text = textBox1.Text, Dictionary = list };
            textBox2.Text = decoder.Decoder();
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            var textUpdater = new StringUpdater { Sentence = textBox1.Text };
            textBox2.Text = textUpdater.StringUpdate();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var textDecoder = new StringDeupdater { Sentence = textBox1.Text };
            textBox2.Text = textDecoder.StringDec();
        }

        private void ListChecker(string text)
        {
            if (list.Count == 0)
                list.Add(textBox1.Text);
            else
            {
                int counter = 0;
                foreach (var line in list)
                {
                    if (textBox1.Text == line)
                        counter++;
                }
                if (counter == 0)
                    list.Add(textBox1.Text);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var coder = new CoderLab4 { Text = textBox1.Text };
            textBox2.Text = coder.Coder();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var decoder = new DecoderLab4 { Text = textBox1.Text };
            textBox2.Text = decoder.Decoder();
        }
    }
}
