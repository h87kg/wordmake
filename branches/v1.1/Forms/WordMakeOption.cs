using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using WordMake.Properties;

namespace WordMake.Forms
{
    public partial class WordMakeOption : Form
    {
        private WordMakeForm wordMakeForm;
        public WordMakeOption(WordMakeForm wordMakeForm)
        {
            this.wordMakeForm = wordMakeForm;
            InitializeComponent();
        }

        /// <summary>
        /// 为true时水平扫描顺序从左到右
        /// </summary>
        public bool LeftToRight
        {
            get
            {
                return this.radioButtonLtoR.Checked;
            }
            set
            {
                this.radioButtonLtoR.Checked = value;
            }
        }
        /// <summary>
        /// 为true时在每个字符的点阵数据后加入字符宽度信息
        /// </summary>
        public bool AutoWordWidth
        {
            get
            {
                return this.变宽.Checked;
            }
            set
            {
                this.变宽.Checked = value;
            }
        }

        /// <summary>
        /// 为true时竖直扫描顺序从上到下
        /// </summary>
        public bool TopToBottom
        {
            get
            {
                return this.radioButtonTtoB.Checked;
            }
            set
            {
                this.radioButtonTtoB.Checked = value;
            }
        }

        /// <summary>
        /// 为true时输出字节顺序高位在前
        /// </summary>
        public bool HSB
        {
            get
            {
                return this.radioButtonHfirst.Checked;
            }
            set
            {
                this.radioButtonHfirst.Checked = value;
            }
        }

        public string FileHead
        {
            get
            {
                return textBoxFileH.Text;
            }
            set
            {
                textBoxFileH.Text = value;
            }
        }

        public string FileCauda
        {
            get
            {
                return textBoxFileC.Text;
            }
            set
            {
                textBoxFileC.Text = value;
            }
        }

        public string SegmentHead
        {
            get
            {
                return textBoxSegmentH.Text;
            }
            set
            {
                textBoxSegmentH.Text = value;
            }
        }

        public string SegmentCauda
        {
            get
            {
                return textBoxSegmentC .Text;
            }
            set
            {
                textBoxSegmentC.Text = value;
            }
        }

        public string DataHead
        {
            get
            {
                return textBoxDataH.Text;
            }
            set
            {
                textBoxDataH.Text = value;
            }
        }

        public string DataCauda
        {
            get
            {
                return textBoxDataC.Text;
            }
            set
            {
                textBoxDataC.Text = value;
            }
        }
        public string CommentHead
        {
            get
            {
                return textBoxCommentH.Text;
            }
            set
            {
                textBoxCommentH.Text = value;
            }
        }

        public string CommentCauda
        {
            get
            {
                return this.textBoxCommentC.Text;
            }
            set
            {
                this.textBoxCommentC.Text = value;
            }
        }

        public string FormatString
        {
            get
            {
                if (radioButton10j.Checked)
                {
                    return "D";
                }
                else
                {
                    return "X";
                }
            }
            set
            {
                if (string.Compare(value,"D",true)!=0)
                {
                    radioButton10j.Checked = true;
                    return;
                }
                if (string.Compare(value, "X", true)!=0)
                {
                    radioButton16j.Checked = true;
                    return;
                }
                throw new ArgumentOutOfRangeException("value", "FormatString只允许使用十六进制（x）、十进制（d）");

            }
        }

        /// <summary>
        /// 添加段唯一标识
        /// </summary>
        public bool AddSegmentId
        {
            get
            {
                return this.checkBoxSegmentID.Checked;
            }
            set
            {
                this.checkBoxSegmentID.Checked = value;
            }
        }
        public string SegmentName
        {
            get
            {
                return this.textBoxSegmentName.Text;
            }
            set
            {
                this.textBoxSegmentName.Text = value;
            }
        }

        /// <summary>
        /// 为true是扫描线方向为水平
        /// </summary>
        public bool HorizontalScan
        {
            get
            {
                return this.radioButtonHScan.Checked;
            }
            set
            {
                this.radioButtonHScan.Checked = value;
            }
        }

        /// <summary>
        /// 为true时对每条扫描线非整字节的用位０填充
        /// </summary>
        public bool FillScan
        {
            get
            {
                return this.checkBoxFill0.Checked;
            }
            set
            {
                this.checkBoxFill0.Checked = value;
            }
        }

        /// <summary>
        /// 为数据分行
        /// </summary>
        public bool Divide
        {
            get
            {
                return this.checkBox数据段分行.Checked;
            }
            set
            {
                this.checkBox数据段分行.Checked = value;
            }
        }

        /// <summary>
        /// 数据行头
        /// </summary>
        public string RowHead
        {
            get
            {
                return this.textBox数据行头.Text;
            }
            set
            {
                this.textBox数据行头.Text = value;
            }
        }

        /// <summary>
        /// 数据行尾
        /// </summary>
        public string RowCauda
        {
            get
            {
                return this.textBox数据行尾.Text;
            }
            set
            {
                this.textBox数据行尾.Text = value;
            }
        }
            /// <summary>
        /// 数据行尾
        /// </summary>
        public int PerRowDataCount
        {
            get
            {
                try
                {
                    return int.Parse(this.maskedTextBox每行数据位.Text);
                }
                catch
                {
                    return 20;
                }
            }
            set
            {
                 maskedTextBox每行数据位.Text = value.ToString();
            }
        }
        private void textBoxFileH_TextChanged(object sender, EventArgs e)
        {

            outTextboxRe();
        }

        private void outTextboxRe()
        {
            timer.Start();
        }

        private void textBoxFileH_Enter(object sender, EventArgs e)
        { 
            TextBox editingTextBox = ((TextBox)sender);
            TextEditForm ed = new TextEditForm();
            Point scp = editingTextBox.PointToScreen(new Point(0, 0));
            ed.Location = new Point(scp.X + 10, scp.Y + 4);
            ed.Text = editingTextBox.Text;
            if (ed.ShowDialog(this) == DialogResult.OK)
            {
                editingTextBox.Text = ed.Text;
            }
            ed.Dispose();
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            outS();
            //radioButtonCheckedChanged(sender, e);
        }

        private void outS()
        {
            string h = "型如：“■■□□□□□□”的字符\r\n将输出：";
            if (this.radioButtonHfirst.Checked)
            {
                this.textBox输出字节顺序.Text = h + "11000000";
            }
            else
            {
                this.textBox输出字节顺序.Text = h + "00000011";
            }
        }

        private void Option_Load(object sender, EventArgs e)
        {
            outS();
            outTextboxRe();
            this.maskedTextBox每行数据位.ValidatingType = typeof(int);
            foreach (TabPage tp in tabControl1.Controls)
            {
                foreach (Control c in tp.Controls)
                {
                    GroupBox gb = c as GroupBox;
                    if (gb != null)
                    {
                        bool first = true;
                        bool fv = true;
                        foreach (Control c1 in gb.Controls)
                        {
                            RadioButton rb = c1 as RadioButton;
                            if (rb != null)
                            {
                                if (first)
                                {
                                    fv = !rb.Checked;
                                    first = false;
                                }
                                else
                                {
                                    rb.Checked = fv;
                                }
                            }
                        }
                    }
                }
            }
            outTextboxRe();
        }

        private void checkBox数据段分行_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox数据段分行.Enabled = ((CheckBox)sender).Checked;
            outTextboxRe();
        }

        private void maskedTextBox每行数据位_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.SetError((Control)sender,"位置"+e.Position.ToString()+"出错："+e.RejectionHint);
        }

        private void maskedTextBox每行数据位_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (e.IsValidInput)
            {
                errorProvider.SetError((Control)sender, "");
            }
            else
            {
                errorProvider.SetError((Control)sender, e.Message+"已被设为默认值。");
                maskedTextBox每行数据位.Text = "20";
            }
        }

        private void button默认值_Click(object sender, EventArgs e)
        {
            WordMake.Properties.Settings.Default.Reset();
            outTextboxRe();
           
        }
        public void SaveConfigure()
        {
            saveFileDialog.Title = Resources.配置文件另存为;
            saveFileDialog.Filter = Resources.配置文件Filter;
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    ExeConfigurationFileMap filemap = new ExeConfigurationFileMap();
                    filemap.ExeConfigFilename = saveFileDialog.FileName;
                    Configuration con = ConfigurationManager.OpenMappedExeConfiguration(filemap, ConfigurationUserLevel.None);
                    AppSettingsSection WordMakeSetings = new AppSettingsSection();
                    KeyValueConfigurationCollection keyv = WordMakeSetings.Settings;
                    Type otype = typeof(string);
                    SettingsPropertyCollection settings = Settings.Default.Properties;
                    foreach (SettingsProperty sett in settings)
                    {
                        string name = sett.Name;
                        object o = Settings.Default[name];
                        TypeConverter tc = TypeDescriptor.GetConverter(o);
                        if (tc.CanConvertTo(otype))
                        {
                            keyv.Add(name, tc.ConvertToString(o));
                        }
                    }
                    con.Sections.Clear();
                    con.Sections.Add("WordMakeSetings", WordMakeSetings);
                    con.Save();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(this, ee.ToString());
                }
            }
        }
        public void LoadConfigure()
        {
            openFileDialog.Title = Resources.加载配置文件;
            openFileDialog.Filter = Resources.配置文件Filter;
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                LoadConfigure(openFileDialog.FileName);
            }
        }

        public void LoadConfigure(string fileaName)
        {
            try
            {
                ExeConfigurationFileMap filemap = new ExeConfigurationFileMap();
                filemap.ExeConfigFilename = fileaName;
                Configuration con = ConfigurationManager.OpenMappedExeConfiguration(filemap, ConfigurationUserLevel.None);
                AppSettingsSection WordMakeSetings = con.Sections["WordMakeSetings"] as AppSettingsSection;
                if (WordMakeSetings == null)
                {
                    MessageBox.Show(this, "选择的文件并不包含可用的配置信息！");
                    return;
                }

                KeyValueConfigurationCollection keyv = WordMakeSetings.Settings;
                Settings settings = Settings.Default;
                foreach (KeyValueConfigurationElement kValue in keyv)
                {
                    object old = settings[kValue.Key];
                    settings[kValue.Key] = TypeDescriptor.GetConverter(old).ConvertFrom(kValue.Value);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadConfigure();
            outTextboxRe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveConfigure();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            textBoxOutPut.Text = wordMakeForm.MakeString(wordMakeForm.ProductName).ToString();
            timer.Stop();

        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            Control s = (Control)sender;
            if (s.Text != toolTip.GetToolTip(s))
            {
                this.toolTip.SetToolTip(s, s.Text);
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            colorDialog.Color = s.BackColor;
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                s.BackColor = colorDialog.Color;
            }
        }
        /* private void radioButtonCheckedChanged(object sender, EventArgs e)
        {
           RadioButton s = (RadioButton)sender;
            if (!s.Checked)
            {
                foreach (Control o in s.Parent.Controls)
                {
                    if (o is RadioButton)
                    {
                        if (o != sender)
                        {
                            ((RadioButton)o).Checked = true;
                        }
                    }
                }
            }

        }
*/

    }
}