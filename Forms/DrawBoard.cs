using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WordMake.Forms
{
    public partial class DrawBoard : Form
    {
        public DrawBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           OutRichTextBox.Text = Program.WordMakeForm.MakeWordBoard(this.wordBoard).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wordBoard.EnableDraw = false;
            wordBoard.EnableDraw = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(openFileDialog.FileName);
                wordBoard.LatticeSize = bm.Size;
                int w = bm.Size.Width;
                int h = bm.Size.Height;
                int index = 0;
                for (int y = 0; y < h; y++)
                {
                    for (int x = 0; x < w; x++)
                    {
                        Color col = bm.GetPixel(x, y);
                        byte c=col.R;
                        c|=col.G;
                        c|=col.B;
                        wordBoard.DrawData[index++] =c<0xff/2;
                    }
                }
                wordBoard.ReDraw();
            }
        }
    }
}