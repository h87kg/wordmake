using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WordMake.Forms
{
    public partial class BatchMake : Form
    {
        public enum BatchMakeState
        {
            SelectFile,
            Making,
            Maked,
            Cancel
        }
        public BatchMake(WordMakeForm wordMakeForm)
        {
            WordMakeForm = wordMakeForm;
            InitializeComponent();

            BatchState = BatchMakeState.SelectFile;
            panelSelectFile.Dock = DockStyle.Fill;
            panelSelectFile.BringToFront();
        }
        private DateTime start;
        private WordMakeForm WordMakeForm;
        public BatchMakeState BatchState;
        private StreamReader sReader = null;
        private StreamWriter sWriter = null;
        private void buttonINFile_Click(object sender, EventArgs e)
        {
            if (sender == buttonINFile)
            {
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    this.textBoxINFile.Text = openFileDialog.FileName;
                }
            }
            else if (sender == buttonOutFile)
            {
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    this.textBoxOutFile.Text = saveFileDialog.FileName;
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            switch (BatchState)
            {
                case BatchMakeState.SelectFile:
                    {
                        if (!File.Exists(textBoxINFile.Text))
                        {
                            MessageBox.Show(this, "指定的文件不存在请从新输入。", "出错了");
                            textBoxINFile.Focus();
                            return;
                        }
                        try
                        {
                            sReader = new StreamReader(textBoxINFile.Text);
                            sWriter = new StreamWriter(textBoxOutFile.Text, false, Encoding.UTF8);
                            progressBar.Minimum = progressBar.Value = 0;
                            progressBar.Maximum = (int)(sReader.BaseStream.Length);
                            panelMaking.Dock = DockStyle.Fill;
                            panelMaking.BringToFront();
                            BatchState = BatchMakeState.Making;
                            timer.Start();
                            th = new Thread(new ThreadStart(this.Conversion));
                            th.Name = "BatchMake";
                            start = DateTime.Now;
                            th.Start();
                            buttonNext.Enabled = false;
                        }
                        catch (Exception ee)
                        {
                            if (sReader != null)
                            {
                                sReader.Dispose();
                            }
                            if (sWriter != null)
                            {
                                sWriter.Dispose();
                            }
                            MessageBox.Show(this, ee.Message, "出错了");
                        }
                        break;
                    }
            }

        }
        Thread th = null;
        private void Conversion()
        {
            WordMakeForm.ConversionStringStream(sReader, sWriter);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (sReader == null)
            {
                timer.Stop();
            }
            else
            {
                progressBar.Value = (int)(sReader.BaseStream.Position);
                TimeSpan ts= DateTime.Now - start;
                double tk = ts.TotalSeconds;
                double l = sReader.BaseStream.Length;
                double p = sReader.BaseStream.Position;
                l = l-p;
                long stk =(long)(tk * l / p);
                labelTime.Text = "估计剩余时间：" + TimeSpan.FromSeconds(stk).ToString()+"   已用时间："+TimeSpan.FromSeconds((long)tk).ToString();
                if (th.ThreadState == ThreadState.Stopped)
                {
                    EndMake();
                    buttonCancel.Enabled = false;
                    buttonNext.Text = "完成";
                    buttonNext.DialogResult = DialogResult.OK;
                    buttonNext.Enabled = true;
                    BatchState = BatchMakeState.Maked;
                }
            }
        }

        private void EndMake()
        {
            if (th != null)
            {
                th.Abort();
            }
            timer.Stop();
            if (sReader != null)
            {
                sReader.Dispose();
                sReader = null;
            }
            if (sWriter != null)
            {
                sWriter.Dispose();
                sWriter = null;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            EndMake();
            BatchState = BatchMakeState.Cancel;
        }
    }
}