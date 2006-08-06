using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WordMake.Forms
{
    public partial class TextEditForm : Form
    {
        public TextEditForm()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                if (textBox == null)
                {
                    return "";
                }
                {
                    return this.textBox.Text;
                }
            }
            set
            {
                this.textBox.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ok = true;
            closeing = true;
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            closeing = true;
            timer.Start();
        }

        private void TextEditForm_Load(object sender, EventArgs e)
        {
            textBox.Focus();
            timer.Start();
        }
        private bool closeing;
        private bool ok;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (closeing)
            {
                if (Opacity <= 0)
                { 
                    timer.Stop();
                    if (ok)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                } 
                this.Opacity -= 0.2;
            }
            else
            {
                if (Opacity > 0.8)
                {
                    timer.Stop();
                    return;
                }
                this.Opacity += 0.1;
            }
        }
    }
}