using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
		buttonSave.Enabled = true;
            }
        }

	private void buttonSave_Click(object sender, EventArgs e)
	{
		if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
		{
			FileStream fs = File.OpenWrite(saveFileDialog.FileName);
			Program.WordMakeForm.ConversionWordBoard(wordBoard, fs);
			fs.Close();
		}
	}

	private void 更改毛织程序换开机画面ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (openBinFileDialog.ShowDialog(this) != DialogResult.OK)
			return;
		if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
			return;
		FileStream ofs = File.OpenWrite(saveFileDialog.FileName);
		ofs.SetLength(0);
		FileStream ifs = File.OpenRead(openBinFileDialog.FileName);
		MemoryStream ms = new MemoryStream();
		Program.WordMakeForm.ConversionWordBoard(wordBoard, ms);
		byte[] chk = { 0x03, 0x06, 0x00, 0x00, 0x09, 0x01, 0x00, 0x00 };
		byte[] buf = new byte[chk.Length];
		int dat;
		while ((dat = ifs.ReadByte()) != -1)
		{
			int i;
			ofs.WriteByte((byte)dat);
			for (i = 0; i < buf.Length - 1; i++)
			{
				buf[i] = buf[i + 1];
			}
			buf[buf.Length - 1] = (byte)dat;
			for (i = 0; i < buf.Length; i++)
			{
				if (chk[i] != buf[i])
					break;
			}
			if (i == buf.Length)
			{
				ofs.Seek(-chk.Length, SeekOrigin.Current);
				ifs.Seek(-chk.Length, SeekOrigin.Current);
				break;
			}
		}
		ms.Seek(0, SeekOrigin.Begin);
		int b = 0;
		while ((dat = ifs.ReadByte()) != -1)
		{
			
			if (b % 4 < 2)
			{
				int d = ms.ReadByte();
				if (d != -1)
					dat = d;
			}
			b++;
			ofs.WriteByte((byte)dat);
		}
		ofs.Close();
		ifs.Close();
		ms.Close();

	}
    }
}