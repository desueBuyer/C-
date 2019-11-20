using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                try
                {
                    Image image = Image.FromFile(textBox1.Text);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = image;
                }
                catch (OutOfMemoryException ex)
                {
                    textBox1.Text = "Невозможно открыть выбранный файл";
                    return;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height);
                for (int height = 0; height < bmp.Height; height++)
                    for (int width = 0; width < bmp.Width; width++)
                    {
                        Color color = bmp.GetPixel(width, height);
                        int gray = (int)(0.299 * color.R + 0.587 * color.G + color.B * 0.114);
                        newBmp.SetPixel(width, height, Color.FromArgb(gray, gray, gray));
                    }
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = newBmp;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height);
                for (int height = 0; height < bmp.Height; height++)
                    for (int width = 0; width < bmp.Width; width++)
                    {
                        Color color = bmp.GetPixel(width, height);
                        newBmp.SetPixel(width, height, Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
                    }
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = newBmp;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var bitmap = new Bitmap(pictureBox1.Image);
                var newBitmap = new Bitmap(bitmap.Width, bitmap.Height);
                var array = new int[bitmap.Width, bitmap.Height];
                for (var i = 0; i < bitmap.Width; i++)
                    for (var j = 0; j < bitmap.Height; j++)
                    {
                        var ValueZiro = bitmap.GetPixel(i, j);
                        var averageValueZiro = ((int)ValueZiro.R + (int)ValueZiro.G + (int)ValueZiro.B) / 3;
                        if ((i - 1 >= 0) && (i <= bitmap.Width - 2) && (j - 1 >= 0) && (j <= bitmap.Height - 2))
                        {
                            var P1 = bitmap.GetPixel(i - 1, j - 1); var P5 = bitmap.GetPixel(i + 1, j + 1);
                            var P2 = bitmap.GetPixel(i, j - 1); var P6 = bitmap.GetPixel(i, j + 1);
                            var P3 = bitmap.GetPixel(i + 1, j - 1); var P7 = bitmap.GetPixel(i - 1, j + 1);
                            var P4 = bitmap.GetPixel(i + 1, j); var P8 = bitmap.GetPixel(i - 1, j);

                            var averageValueP1 = ((int)P1.R + (int)P1.G + (int)P1.B) / 3; var averageValueP5 = ((int)P5.R + (int)P5.G + (int)P5.B) / 3;
                            var averageValueP2 = ((int)P2.R + (int)P2.G + (int)P2.B) / 3; var averageValueP6 = ((int)P6.R + (int)P6.G + (int)P6.B) / 3;
                            var averageValueP3 = ((int)P3.R + (int)P3.G + (int)P3.B) / 3; var averageValueP7 = ((int)P7.R + (int)P7.G + (int)P7.B) / 3;
                            var averageValueP4 = ((int)P4.R + (int)P4.G + (int)P4.B) / 3; var averageValueP8 = ((int)P8.R + (int)P8.G + (int)P8.B) / 3;

                            var averageValueX = Math.Abs(averageValueP7 + 2 * averageValueP6 + averageValueP5 - averageValueP1 - 2 * averageValueP2 - averageValueP3);
                            var averageValueY = Math.Abs(averageValueP3 + 2 * averageValueP4 + averageValueP5 - averageValueP1 - 2 * averageValueP8 - averageValueP7);
                            var averageValue = (int)Math.Sqrt(Math.Pow(averageValueX, 2) + Math.Pow(averageValueY, 2));

                            if (averageValue > 255) { averageValue = 255; }

                            // |G| = |P1 + 2P2 + P3 - P7 - 2P6 - P5| + |P3 + 2P4 + P5 - P1 - 2P8 - P7| 
                            newBitmap.SetPixel(i, j, Color.FromArgb(Math.Abs(averageValue), Math.Abs(averageValue), Math.Abs(averageValue)));
                        }
                        else { newBitmap.SetPixel(i, j, Color.FromArgb(averageValueZiro, averageValueZiro, averageValueZiro)); }
                    }
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = newBitmap;
            }

        }
    }
}

