using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WordMake.Properties;

namespace WordMake.Forms
{
    public partial class IndexMode : Form
    {
        int IndexOffset;
        public IndexMode()
        {
            InitializeComponent();
        }
        private void UpdateOut()
        {
            updatIndexOffset();
            StringBuilder AllWord = new StringBuilder();
            string ins = IntputRichTextBox.Text;
            //AllWord.Remove(0, AllWord.Length);
            int i = 0;
            int c = ins.Length;
            while (i < c)
            {
                char rc = ins[i++];
                if (rc == '\n')
                    continue;
                int io = 0;
                int ioc = AllWord.Length;
                bool nomach = true;
                while (io < ioc)
                {
                    if (rc == AllWord[io++])
                    {
                        nomach = false;
                        break;
                    }
                }
                if (nomach)
                {
                    AllWord.Append(rc);
                }
            }
            string allWord = AllWord.ToString();
            WordRichTextBox.Text = allWord;
            StringBuilder indexOut = new StringBuilder();
            Settings defs = Settings.Default;
            string FormatString;
            if (defs.数据格式十六进制)
            {
                FormatString = "X";
            }
            else
            {
                FormatString = "D";
            }
            string DataHead = defs.数据头;///Option.DataHead;
             string DataCauda = defs.数据尾;// Option.DataCauda;
				//string DataEndCauda = defs.段尾数据尾;// Option.DataEndCauda;
             //string SegmentHead = defs.段头;//Option.SegmentHead;
             //string SegmentCauda = defs.段尾;//Option.SegmentCauda;
                string SegmentHead = textBoxSegmentH.Text;//Option.SegmentHead;
                string SegmentCauda = textBoxSegmentC.Text;//Option.SegmentCauda;
				string CommentHead = defs.注解头;//Option.CommentHead;
				string CommentCauda = defs.注解尾;//Option.CommentCauda;
                string SegmentName = textBoxSegmentName.Text;//Option.SegmentName;
                bool AddIndex = checkBoxSegmentID.Checked;
                int sindex = 0;
            foreach (string s in IntputRichTextBox.Lines)
            {
                indexOut.Append(SegmentHead);
                if (AddIndex)
                    {
                        indexOut.Append(sindex.ToString());
                        sindex++;
                    }
                indexOut.Append(SegmentName);
                foreach (char word in s)
                {
                    indexOut.Append(DataHead);
                    
                    indexOut.Append((allWord.IndexOf(word) + IndexOffset).ToString(FormatString));
                    indexOut.Append(DataCauda);
                }
                indexOut.Append(SegmentCauda);
                indexOut.Append(CommentHead);
                indexOut.Append(s);
                indexOut.AppendLine(CommentCauda);
               
            }
            indexOut.AppendLine("#define WORD_COUNT\t\t" + allWord.Length.ToString());
            indexOut.AppendLine("#define STRING_COUNT\t\t" + IntputRichTextBox.Lines.Length.ToString());
            indexOut.AppendLine("#define WORD_INDEX_OFFSET\t" + IndexOffset.ToString());
            indexOut.AppendLine("#define WORD_MAX_INDEX\t\t" + (IndexOffset + allWord.Length-1).ToString());
            richTextBox1.Text = indexOut.ToString();
        }

        private void WordRichTextBox_TextChanged(object sender, EventArgs e)
        {
            OutRichTextBox.Text = Program.WordMakeForm.MakeString(WordRichTextBox.Text).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateOut();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updatIndexOffset();
        }

        private void updatIndexOffset()
        {
            try
            {
                IndexOffset = int.Parse(textBox1.Text);
                errorProvider.SetError(textBox1, "");
            }
            catch (Exception ee)
            {
                errorProvider.SetError(textBox1, ee.Message);
            }
        }
    }
}