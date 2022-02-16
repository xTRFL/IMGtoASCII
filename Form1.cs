using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascii_img
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(OpenFile.FileName);
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string asc = "Ñ@#W$987654321JI0HA?!abc;:+=-,._ ";
            string output = "";
            Bitmap pic = new Bitmap(pictureBox1.Image);
            for(int i = 0; i < pic.Height; i++)
            {
                for(int j = 0; j < pic.Width; j++)
                {
                    Color picColor = pic.GetPixel(j, i);
                    int red = picColor.R;
                    int green = picColor.G;
                    int blue = picColor.B;
                    int grey = (red + green + blue) / 3;
                    int x = Convert.ToInt32(Math.Floor(Convert.ToDouble((grey) / asc.Length)));
                    output += asc[x];
                }
                output += "\n";
            }
            textBox1.Text = output;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string asc = "Ñ@#W$987654321JI0HA?!abc;:+=-,._ ";
            string output = "";
            Bitmap pic = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < pic.Height; i++)
            {
                for (int j = 0; j < pic.Width; j++)
                {
                    Color picColor = pic.GetPixel(j, i);
                    int red = picColor.R;
                    int green = picColor.G;
                    int blue = picColor.B;
                    int grey = (red + green + blue) / 3;
                    int x = Convert.ToInt32(Math.Floor(Convert.ToDouble((grey) / asc.Length)));
                    output += asc[x] + " ";
                }
                output += "\n";
            }
            textBox1.Text = output;
        }
    }
}
