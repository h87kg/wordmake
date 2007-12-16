using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using WordMake.Properties;
using System.Configuration;
using WordMake.CharacterSet;
namespace WordMake.Forms
{
	public partial class WordMakeForm : Form
	{
		public WordMakeForm()
		{
			Option = new WordMakeOption(this);
			//Settings.Default.PropertyChanged += new PropertyChangedEventHandler(Default_PropertyChanged);
			InitializeComponent();
		}
		private void OptionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Option.ShowDialog(this);
		}

		private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
		{
			this.wordBoard.Text = ((ToolStripTextBox)sender).Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.richTextBox1.Clear();
			StringBuilder strout = MakeString(this.textBoxin.Text);
			richTextBox1.Text = strout.ToString();
		}
		public void ConversionStringStream(TextReader IN, TextWriter OUT)
		{
			Settings defs = Settings.Default;
			WordBoard charMake = wordBoard.Clone();
			try
			{
				//初始换行参数
				int perRow;
				//行头
				string rowh = "";
				//行尾
				string rows = "";
				IniConversionRow(out perRow, ref rowh, ref rows);
				//
				int x = 0, y = 0;
				int iniX = 0, iniY = 0;
				int xSetp = 1, ySetp = 1;
				int Iwidth = charMake.ModeWidth - 1;
				int Iheight = charMake.ModeHeight - 1;
				//int bitCount = this.wordBoard1.BitCount;
				//输出字节顺序
				bool round = defs.输出字节顺序高位在前;//Option.HSB;
				//水平扫描顺序
				//if (!Option.LeftToRight)
				if (!defs.水平扫描从左到右)
				{
					iniX = x = Iwidth;
					xSetp = -1;
				}
				//竖直扫描顺序
				//if (!Option.TopToBottom)
				if (!defs.竖直扫描从上到下)
				{
					iniY = y = Iheight;
					ySetp = -1;
				}
				//string
				bool FX = defs.数据格式十六进制;
				int dataL = 3;
				string FormatString;
				if (defs.数据格式十六进制)
				{
					FormatString = "X";
					dataL = 2;
				}
				else
				{
					FormatString = "D";
				}
				string DataHead = defs.数据头;///Option.DataHead;
				string DataCauda = defs.数据尾;// Option.DataCauda;
				//string DataEndCauda = defs.段尾数据尾;// Option.DataEndCauda;
				string SegmentHead = defs.段头;//Option.SegmentHead;
				string SegmentCauda = defs.段尾;//Option.SegmentCauda;
				string CommentHead = defs.注解头;//Option.CommentHead;
				string CommentCauda = defs.注解尾;//Option.CommentCauda;
				string SegmentName = defs.段标识;//Option.SegmentName;
				//int DataCaudaLength = -DataCauda.Length;
				bool AddSegmentID = defs.添加段唯一标识;//Option.AddSegmentId;
				bool HorizontalScan = defs.扫描线方向水平;//Option.HorizontalScan;
				bool FillScan = defs.扫描线非整字节的用位０填充;//Option.FillScan;
				//string formats = Option.DataHead + Option.FormatString + Option.DataCauda + "\t";
				OUT.WriteLine(defs.文件头);//Option.FileHead);
				int red = 0;

				while ((red = IN.Read()) >= 0)
				{
					char c = (char)red;
					// DateTime time = DateTime.Now;
					OUT.Write(CommentHead);
					OUT.Write(c);
					OUT.WriteLine(CommentCauda);
					OUT.Write(SegmentHead);
					if (AddSegmentID)
					{
						OUT.Write(((int)c));
					}
					OUT.Write(SegmentName);
					charMake.SetChar(c);
					int count = charMake.BitCount;

					int data = 0;
					byte bit = 0;

					int rowc = perRow;
					OUT.Write(rowh);
					while ((count--) > 0)
					{

						if (round)
						{
							data = data << 1;
							if (charMake[x, y])
							{
								data++;
							}
						}
						else
						{
							data = data >> 1;
							if (charMake[x, y])
							{
								data |= 128;
							}
						}
						bit++;
						if (bit == 8)
						{

							bit = 0;
							OUT.Write(DataHead);
							OUT.Write(data.ToString(FormatString).PadLeft(dataL, '0'));
							//分行
							rowc--;
							if (count > 0)
							{
								if (rowc == 0)
								{
									OUT.WriteLine(rows);
									OUT.Write(rowh);
									rowc = perRow;
								}
								//分行
								else
								{
									OUT.Write(DataCauda);
								}
							}
							data = 0;
						}
						if (HorizontalScan)
						{
							x += xSetp;
							if (x < 0 || x > Iwidth)
							{
								if (FillScan)
								{
									if (bit != 0)
									{

										if (round)
										{
											data = data << (8 - bit);
										}
										else
										{
											data = data >> (8 - bit);
										}
										OUT.Write(DataHead);

										OUT.Write(data.ToString(FormatString).PadLeft(dataL, '0'));
										//OUT.Write(DataCauda);
										//strout.Append("\t");
										data = 0;
										bit = 0;
										//分行
										rowc--;
										if (count > 0)
										{
											if (rowc == 0)
											{
												OUT.WriteLine(rows);
												OUT.Write(rowh);
												rowc = perRow;
											}
											//分行
											else
											{
												OUT.Write(DataCauda);
											}
										}
									}
								}
								x = iniX;
								y += ySetp;
								if (y < 0 || y > Iheight)
								{
									y = iniY;
								}
							}
						}
						else
						{
							y += ySetp;
							if (y < 0 || y > Iheight)
							{
								if (FillScan)
								{
									if (bit != 0)
									{

										if (round)
										{
											data = data << (8 - bit);
										}
										else
										{
											data = data >> (8 - bit);
										}
										OUT.Write(DataHead);
										OUT.Write(data.ToString(FormatString).PadLeft(dataL, '0'));
										//分行
										rowc--;
										if (count > 0)
										{
											if (rowc == 0)
											{
												OUT.WriteLine(rows);
												OUT.Write(rowh);
												rowc = perRow;
											}
											//分行
											else
											{
												OUT.Write(DataCauda);
											}
										}
										//分行
										data = 0;
										bit = 0;
									}
								}
								y = iniY;
								x += xSetp;
								if (x < 0 || x > Iwidth)
								{
									x = iniX;
								}
							}
						}
					}
					if (bit != 0)
					{
						if (round)
						{
							data = data << (8 - bit);
						}
						else
						{
							data = data >> (8 - bit);
						}
						OUT.Write(DataHead);
						OUT.Write(data.ToString(FormatString).PadLeft(dataL, '0'));
						//OUT.Write(DataCauda);
						//strout.Append("\t");
					}
					//OUT.BaseStream.Seek(DataCaudaLength,SeekOrigin.Current);
					//OUT.Write(DataEndCauda);
					OUT.WriteLine(SegmentCauda);
					//      TimeSpan times = DateTime.Now - time;
				}
				OUT.WriteLine(defs.文件尾);//Option.FileCauda);
			}
			finally
			{
				//charMake.Dispose();
			}
		}
        public void ConversionWordBoard(WordBoard drwaBoard, TextWriter OUT)
        {
            if (drwaBoard.DrawData == null)
                return;
           // WordBoard drwaBoard = wordBoard.Clone();
            Settings defs = Settings.Default;

            try
            {
                //初始换行参数
                int perRow;
                //行头
                string rowh = "";
                //行尾
                string rows = "";
                IniConversionRow(out perRow, ref rowh, ref rows);
                //
                int x = 0, y = 0;
                int iniX = 0, iniY = 0;
                int xSetp = 1, ySetp = 1;
                int Iwidth = drwaBoard.ModeWidth - 1;
                int Iheight = drwaBoard.ModeHeight - 1;
                //int bitCount = this.wordBoard1.BitCount;
                //输出字节顺序
                bool round = defs.输出字节顺序高位在前;//Option.HSB;
                //水平扫描顺序
                //if (!Option.LeftToRight)
                if (!defs.水平扫描从左到右)
                {
                    iniX = x = Iwidth;
                    xSetp = -1;
                }
                //竖直扫描顺序
                //if (!Option.TopToBottom)
                if (!defs.竖直扫描从上到下)
                {
                    iniY = y = Iheight;
                    ySetp = -1;
                }
                //string
                bool FX = defs.数据格式十六进制;
                int dataL = 3;
                string FormatString;
                if (defs.数据格式十六进制)
                {
                    FormatString = "X";
                    dataL = 2;
                }
                else
                {
                    FormatString = "D";
                }
                string DataHead = defs.数据头;///Option.DataHead;
                string DataCauda = defs.数据尾;// Option.DataCauda;
                //string DataEndCauda = defs.段尾数据尾;// Option.DataEndCauda;
                string SegmentHead = defs.段头;//Option.SegmentHead;
                string SegmentCauda = defs.段尾;//Option.SegmentCauda;
                string CommentHead = defs.注解头;//Option.CommentHead;
                string CommentCauda = defs.注解尾;//Option.CommentCauda;
                string SegmentName = defs.段标识;//Option.SegmentName;
                //int DataCaudaLength = -DataCauda.Length;
                bool AddSegmentID = defs.添加段唯一标识;//Option.AddSegmentId;
                bool HorizontalScan = defs.扫描线方向水平;//Option.HorizontalScan;
                bool FillScan = defs.扫描线非整字节的用位０填充;//Option.FillScan;
                //string formats = Option.DataHead + Option.FormatString + Option.DataCauda + "\t";
                OUT.WriteLine(defs.文件头);//Option.FileHead);

                OUT.Write(SegmentHead);

                OUT.Write(SegmentName);
                int count = drwaBoard.BitCount;

                int data = 0;
                byte bit = 0;

                int rowc = perRow;
                OUT.Write(rowh);
                while ((count--) > 0)
                {

                    if (round)
                    {
                        data = data << 1;
                        if (drwaBoard[x, y])
                        {
                            data++;
                        }
                    }
                    else
                    {
                        data = data >> 1;
                        if (drwaBoard[x, y])
                        {
                            data |= 128;
                        }
                    }
                    bit++;
                    if (bit == 8)
                    {

                        bit = 0;
                        OUT.Write(DataHead);
                        OUT.Write(data.ToString(FormatString).PadLeft(dataL, '0'));
                        //分行
                        rowc--;
                        if (count > 0)
                        {
                            if (rowc == 0)
                            {
                                OUT.WriteLine(rows);
                                OUT.Write(rowh);
                                rowc = perRow;
                            }
                            //分行
                            else
                            {
                                OUT.Write(DataCauda);
                            }
                        }
                        data = 0;
                    }
                    if (HorizontalScan)
                    {
                        x += xSetp;
                        if (x < 0 || x > Iwidth)
                        {
                            if (FillScan)
                            {
                                if (bit != 0)
                                {

                                    if (round)
                                    {
                                        data = data << (8 - bit);
                                    }
                                    else
                                    {
                                        data = data >> (8 - bit);
                                    }
                                    OUT.Write(DataHead);

                                    OUT.Write(data.ToString(FormatString).PadLeft(dataL, '0'));
                                    //OUT.Write(DataCauda);
                                    //strout.Append("\t");
                                    data = 0;
                                    bit = 0;
                                    //分行
                                    rowc--;
                                    if (count > 0)
                                    {
                                        if (rowc == 0)
                                        {
                                            OUT.WriteLine(rows);
                                            OUT.Write(rowh);
                                            rowc = perRow;
                                        }
                                        //分行
                                        else
                                        {
                                            OUT.Write(DataCauda);
                                        }
                                    }
                                }
                            }
                            x = iniX;
                            y += ySetp;
                            if (y < 0 || y > Iheight)
                            {
                                y = iniY;
                            }
                        }
                    }
                    else
                    {
                        y += ySetp;
                        if (y < 0 || y > Iheight)
                        {
                            if (FillScan)
                            {
                                if (bit != 0)
                                {

                                    if (round)
                                    {
                                        data = data << (8 - bit);
                                    }
                                    else
                                    {
                                        data = data >> (8 - bit);
                                    }
                                    OUT.Write(DataHead);
                                    OUT.Write(data.ToString(FormatString).PadLeft(dataL, '0'));
                                    //分行
                                    rowc--;
                                    if (count > 0)
                                    {
                                        if (rowc == 0)
                                        {
                                            OUT.WriteLine(rows);
                                            OUT.Write(rowh);
                                            rowc = perRow;
                                        }
                                        //分行
                                        else
                                        {
                                            OUT.Write(DataCauda);
                                        }
                                    }
                                    //分行
                                    data = 0;
                                    bit = 0;
                                }
                            }
                            y = iniY;
                            x += xSetp;
                            if (x < 0 || x > Iwidth)
                            {
                                x = iniX;
                            }
                        }
                    }
                }
                if (bit != 0)
                {
                    if (round)
                    {
                        data = data << (8 - bit);
                    }
                    else
                    {
                        data = data >> (8 - bit);
                    }
                    OUT.Write(DataHead);
                    OUT.Write(data.ToString(FormatString).PadLeft(dataL, '0'));
                    //OUT.Write(DataCauda);
                    //strout.Append("\t");
                }
                //OUT.BaseStream.Seek(DataCaudaLength,SeekOrigin.Current);
                //OUT.Write(DataEndCauda);
                OUT.WriteLine(SegmentCauda);
                //      TimeSpan times = DateTime.Now - time;
                OUT.WriteLine(defs.文件尾);//Option.FileCauda);
            }
            finally
            {
                //drwaBoard.Dispose();
            }
        }

		private static void IniConversionRow(out int perRow, ref string rowh, ref string rows)
		{
			Settings defs = Settings.Default;
			perRow = 0;
			try
			{
				perRow = int.Parse(defs.每行数据位);
			}
			catch { }
			bool divide = defs.数据段分行;//Option.Divide;

			if (divide && perRow != 0)
			{
				rowh = defs.数据行头;// Option.RowHead;
				rows = defs.数据行尾;// Option.RowCauda;
			}
			else
			{
				perRow = int.MaxValue;
			}
		}
		public StringBuilder MakeString(string s)
		{
			StringBuilder strout = new StringBuilder();
			StringReader IN = new StringReader(s);
			StringWriter OUT = new StringWriter(strout);
			ConversionStringStream(IN, OUT);
			IN.Dispose();
			OUT.Dispose();
			return strout;
		}
        public StringBuilder MakeWordBoard(WordBoard drwaBoard)
        {
            StringBuilder strout = new StringBuilder();
            StringWriter OUT = new StringWriter(strout);
            ConversionWordBoard(drwaBoard,OUT);
            OUT.Dispose();
            return strout;
        }
		string[] fontName;
		private void WordMakeForm_Load(object sender, EventArgs e)
		{
			FontFamily[] ff = FontFamily.Families;
			fontName = new string[ff.Length];
			for (int i = 0; i < ff.Length; i++)
			{
				fontName[i] = ff[i].Name;
			}
			toolStripComboBoxfont.Items.AddRange(fontName);
			toolStripComboBoxfont.Text = this.wordBoard.Font.FontFamily.Name;
			FrFontSizeText();
			frCharLocationText();
			frMultipleText();

		}


		private void toolStripComboBoxfont_TextChanged(object sender, EventArgs e)
		{
			string fm = ((ToolStripComboBox)sender).Text.Trim();
			if (fontName != null)
			{
				foreach (string s in fontName)
				{
					if (s.Equals(fm))
					{
						try
						{
							Font old = wordBoard.Font;
							this.wordBoard.Font = new Font(((ToolStripComboBox)sender).Text, old.Size, old.Style);
						}
						catch (Exception ee)
						{
							MessageBox.Show(ee.Message);
						}
					}
				}

			}
		}

		private void toolStripComboBoxMultiple_TextUpdate(object sender, EventArgs e)
		{
			ToolStripComboBox s = ((ToolStripComboBox)sender);
			try
			{
				this.wordBoard.Multiple = int.Parse(s.Text);
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message);
			}

		}

		private void toolStripComboBoxMultiple_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.wordBoard.Multiple = ((ToolStripComboBox)sender).SelectedIndex + 1;
		}

		private void toolStripComboBoxClearText(object sender, EventArgs e)
		{
			((ToolStripComboBox)sender).Text = "";
		}
		private WordMakeOption Option;

		private void toolStripComboBoxMultiple_Leave(object sender, EventArgs e)
		{
			frMultipleText();
		}

		private void frMultipleText()
		{
			this.toolStripComboBoxMultiple.Text = "放大" + this.wordBoard.Multiple.ToString() + "倍";
		}

		private void toolStripComboBoxModeSize_TextChanged(object sender, EventArgs e)
		{
			ToolStripComboBox s = (ToolStripComboBox)sender;
			if (s.SelectedIndex == s.Items.Count - 1)
			{
				s.Text = "";
			}
			string str = s.Text.Replace('*', ',');
			str = str.Replace('，', ',');
			try
			{
				wordBoard.LatticeSize = (Size)(TypeDescriptor.GetConverter(typeof(Size)).ConvertFrom(str));
			}
			catch { }
			/*string[] si = s.Text.Split(new char[] { '*', '＊' }, 2);
			if (si.Length < 2 || si[1].Trim().Length < 1)
			{
				return;
			}
			try
			{
				this.wordBoard.LatticeSize = new Size(int.Parse(si[0]), int.Parse(si[1]));
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message);
			}
			 */
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			SaveFileDialog sf = new SaveFileDialog();
			if (sf.ShowDialog(this) == DialogResult.OK)
			{
				Stream fs = File.Create(sf.FileName);
				GB2312.GetAllChars(fs);
				fs.Dispose();
			}
		}



		private void 批量生成ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BatchMake bm = new BatchMake(this);
			bm.ShowDialog(this);
			/*openFileDialog.Title = "打开文本文件";
			openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				saveFileDialog.Title = "保存输出文件";
				saveFileDialog.Filter = "文本文件(*.txt)|*.txt";
				if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
				{
					StreamReader sr = new StreamReader(openFileDialog.FileName);
					StreamWriter sw = new StreamWriter(saveFileDialog.FileName,false,Encoding.UTF8);
					this.ConversionStringStream(sr, sw);
					sr.Dispose();
					sw.Dispose();
				}
			}*/
		}

		private void toolStripComboBoxFontSize_TextChanged(object sender, EventArgs e)
		{
			ToolStripComboBox s = (ToolStripComboBox)sender;
			if (s.Text == "自动")
			{
				this.wordBoard.AutoFontSize = true;
			}
			else
			{
				try
				{
					//wordBoard.Suspend();
					float size = float.Parse(s.Text);
					this.wordBoard.AutoFontSize = false;
					Font oldf = wordBoard.Font;
					//wordBoard.Resume();
					wordBoard.Font = new Font(oldf.FontFamily, size, oldf.Style);

				}
				catch (Exception ee)
				{
					MessageBox.Show(ee.Message);
				}
				finally
				{
					//wordBoard.Resume();
				}
			}
		}

		private void CharOffsetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem s = (ToolStripMenuItem)sender;
			Point old = wordBoard.CharLocation;
			if (s == this.向上ToolStripMenuItem)
			{
				old.Y -= 1;
			}
			else if (s == this.向下ToolStripMenuItem)
			{
				old.Y += 1;
			}
			else if (s == this.向左ToolStripMenuItem)
			{
				old.X -= 1;
			}
			else if (s == this.向右ToolStripMenuItem)
			{
				old.X += 1;
			}
			else if (s == this.复位ToolStripMenuItem)
			{
				old = new Point(0, 0);

			}
			wordBoard.CharLocation = old;
			//refCharOffsetTextBox();
		}
		private void toolStripTextBox偏移_TextChanged(object sender, EventArgs e)
		{
			if (toolStripTextBox左右偏移.Text.Length == 0 || toolStripTextBox上下偏移.Text.Length == 0)
			{
				return;
			}
			if (toolStripTextBox左右偏移.Text == "-" || toolStripTextBox上下偏移.Text == "-")
			{
				return;
			}
			try
			{
				if (toolStripTextBox左右偏移 == sender)
				{
					wordBoard.CharLocation = new Point(int.Parse(toolStripTextBox左右偏移.Text), wordBoard.CharLocation.Y);
				}
				else
				{
					wordBoard.CharLocation = new Point(wordBoard.CharLocation.X, int.Parse(toolStripTextBox上下偏移.Text));
				}
			}
			catch (Exception ee)
			{
				MessageBox.Show(this, ee.Message);
			}
		}
		private void toolStripButtonFont_Click(object sender, EventArgs e)
		{

		}

		private void WordMakeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Settings.Default.显示放大倍数 = wordBoard.Multiple;
			Settings.Default.Save();

		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{

		}

		private void 配置文件另存为ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Option.SaveConfigure();

		}

		private void 加载ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LoadConfigure();

		}
		public void LoadConfigure()
		{
			openFileDialog.Title = Resources.加载配置文件;
			openFileDialog.Filter = Resources.配置文件Filter;
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				try
				{
					ExeConfigurationFileMap filemap = new ExeConfigurationFileMap();
					filemap.ExeConfigFilename = openFileDialog.FileName;
					Configuration con = ConfigurationManager.OpenMappedExeConfiguration(filemap, ConfigurationUserLevel.None);
					AppSettingsSection WordMakeSetings = con.Sections["WordMakeSetings"] as AppSettingsSection;
					if (WordMakeSetings == null)
					{
						MessageBox.Show(this, "选择的文件并不包含可以的配置信息！");
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
		}
		private void toolStripButtonFont_CheckedChanged(object sender, EventArgs e)
		{
			FontStyle newstyle = FontStyle.Regular;
			if (this.toolStripButtonBold.Checked)
			{
				newstyle = FontStyle.Bold;
			}
			if (this.toolStripButtonItalic.Checked)
			{
				newstyle |= FontStyle.Italic;
			}
			if (this.toolStripButtonUnderline.Checked)
			{
				newstyle |= FontStyle.Underline;
			}
			try
			{
				Font oldf = wordBoard.Font;
				this.wordBoard.Font = new Font(oldf.FontFamily, oldf.Size, newstyle);
			}
			catch (Exception ee)
			{
				MessageBox.Show(this, ee.Message);
				ToolStripButton s = (ToolStripButton)sender;
				s.Checked = !s.Checked;
			}
		}

		private void wordBoard_AutoFontSizeChanged(object sender, EventArgs e)
		{
			FrFontSizeText();

		}

		private void FrFontSizeText()
		{
			if (toolStripComboBoxFontSize.Focused)
				return;
			if (wordBoard.AutoFontSize)
			{
				toolStripComboBoxFontSize.Text = "自动";
			}
			else
			{
				toolStripComboBoxFontSize.Text = wordBoard.Font.Size.ToString();
			}
			toolStripComboBoxFontSize.ToolTipText = "字号(" + wordBoard.Font.Size.ToString() + ")";
		}

		private void wordBoard_CharLocationChanged(object sender, EventArgs e)
		{
			frCharLocationText();

		}

		private void frCharLocationText()
		{
			toolStripTextBox上下偏移.Text = wordBoard.CharLocation.Y.ToString();
			toolStripTextBox左右偏移.Text = wordBoard.CharLocation.X.ToString();
		}


		private void wordBoard_FontChanged(object sender, EventArgs e)
		{
			Font f = wordBoard.Font;
			toolStripComboBoxfont.Text = f.Name;
			toolStripButtonBold.Checked = f.Bold;
			toolStripButtonItalic.Checked = f.Italic;
			toolStripButtonUnderline.Checked = f.Underline;
			FrFontSizeText();
		}

		private void wordBoard_LatticeSizeChanged(object sender, EventArgs e)
		{
			if (!toolStripComboBoxModeSize.Focused)
				toolStripComboBoxModeSize.Text = TypeDescriptor.GetConverter(typeof(Size)).ConvertToString(wordBoard.LatticeSize);
			//toolStripComboBoxModeSize.s
		}

		private void textBoxin_TextChanged(object sender, EventArgs e)
		{
			this.wordBoard.Text = ((TextBox)sender).Text;
		}

		private void gB2312ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialogText();
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				Stream fs = File.Create(saveFileDialog.FileName);
				if (sender == this.toolStripMenuItemGB2312All)
				{
					GB2312.GetAllChars(fs);
				}
				else if (sender == this.一级简码ToolStripMenuItem)
				{
					GB2312.GetStairChars(fs);
				}
				else if (sender == this.二级简码ToolStripMenuItem)
				{
					GB2312.GetSecondaryChars(fs);
				}
				else if (sender == this.ASCII全部ToolStripMenuItem)
				{
					ASCII.GetAllChars(fs);
				}
				fs.Dispose();
			}
		}

		private void saveFileDialogText()
		{
			saveFileDialog.Title = "保存";
			saveFileDialog.Filter = "文本文件(*.txt)|*.txt";
		}

		private void 确定ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Stream fs = null;
			int st = 0;
			int end = 0;
			try
			{
				st = int.Parse(toolStripTextBoxGBStart.Text);
				end = int.Parse(toolStripTextBoxGBEnd.Text);
				saveFileDialogText();
				if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
				{
					fs = File.Create(saveFileDialog.FileName);
					GB2312.GetChars(fs, st, end);
				}
			}
			catch (Exception ee)
			{
				MessageBox.Show(this, ee.Message, "出错了");
				return;
			}
			finally
			{
				if (fs != null)
				{
					fs.Dispose();
				}
			}
		}

		private void configToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem s = (ToolStripMenuItem)sender;
			Option.LoadConfigure(Application.StartupPath + "\\" + s.Text + ".config");
		}

		private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.richTextBox1.Copy();
		}

		private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.richTextBox1.SelectAll();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AboutBox ab = new AboutBox();
			ab.ShowDialog(this);
			ab.Dispose();
		}

        private void 移除文件中相同字符ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            openFileDialog.Title = "打开文件";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                saveFileDialog.Title = "保存输出文件到...";
                saveFileDialog.Filter = openFileDialog.Filter;
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    StreamReader sReader = new StreamReader(openFileDialog.FileName,true);
                    string ins = sReader.ReadToEnd();
                    StringBuilder so = new StringBuilder();
                    sReader.Close();
                    StreamWriter sWriter = new StreamWriter(saveFileDialog.FileName);
                    int i = 0;
                    int c = ins.Length;
                    while (i<c)
                    {
                        char rc = ins[i++];
                        int io = 0;
                        int ioc = so.Length;
                        bool nomach = true;
                        while (io < ioc)
                        {
                            if (rc == so[io++])
                            {
                                nomach = false;
                                break;
                            }
                        }
                        if (nomach)
                        {
                            so.Append(rc);
                        }
                    }
                    sWriter.Write(so.ToString());
                    sWriter.Close();
                }
            }
        }

        private void 自动生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndexMode im = new IndexMode();
            im.Show();
        }

        private void 画图板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawBoard db = new DrawBoard();
            db.Show();
        }
	}
}