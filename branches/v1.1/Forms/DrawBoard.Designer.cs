namespace WordMake.Forms
{
    partial class DrawBoard
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawBoard));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OutRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.wordBoard = new WordMake.Forms.WordBoard();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(563, 272);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.OutRichTextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(372, 272);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出字符串：";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(9, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutRichTextBox
            // 
            this.OutRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OutRichTextBox.Location = new System.Drawing.Point(6, 20);
            this.OutRichTextBox.Name = "OutRichTextBox";
            this.OutRichTextBox.Size = new System.Drawing.Size(357, 217);
            this.OutRichTextBox.TabIndex = 0;
            this.OutRichTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordBoard);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 272);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "绘制区域：";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(90, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "清除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(171, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "从文件加载";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "图像文件|*.bmp;*.jpg;*.gif";
            // 
            // wordBoard
            // 
            this.wordBoard.AutoFontSize = global::WordMake.Properties.Settings.Default.自动字体大小;
            this.wordBoard.CharLocation = global::WordMake.Properties.Settings.Default.字模偏移;
            this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::WordMake.Properties.Settings.Default, "字体", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("CharLocation", global::WordMake.Properties.Settings.Default, "字模偏移", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("Multiple", global::WordMake.Properties.Settings.Default, "显示放大倍数", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("LatticeSize", global::WordMake.Properties.Settings.Default, "字模大小", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("AutoFontSize", global::WordMake.Properties.Settings.Default, "自动字体大小", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::WordMake.Properties.Settings.Default, "已点亮区域LCD颜色", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("LcdColor", global::WordMake.Properties.Settings.Default, "未点亮区域LCD颜色", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("FrameColor", global::WordMake.Properties.Settings.Default, "字符线框颜色", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wordBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordBoard.DrawData = ((System.Collections.BitArray)(resources.GetObject("wordBoard.DrawData")));
            this.wordBoard.EnableDraw = true;
            this.wordBoard.Font = global::WordMake.Properties.Settings.Default.字体;
            this.wordBoard.ForeColor = global::WordMake.Properties.Settings.Default.已点亮区域LCD颜色;
            this.wordBoard.FrameColor = global::WordMake.Properties.Settings.Default.字符线框颜色;
            this.wordBoard.LatticeSize = global::WordMake.Properties.Settings.Default.字模大小;
            this.wordBoard.LcdColor = global::WordMake.Properties.Settings.Default.未点亮区域LCD颜色;
            this.wordBoard.Location = new System.Drawing.Point(3, 17);
            this.wordBoard.ModeHeight = 12;
            this.wordBoard.ModeWidth = 12;
            this.wordBoard.Multiple = global::WordMake.Properties.Settings.Default.显示放大倍数;
            this.wordBoard.Name = "wordBoard";
            this.wordBoard.Size = new System.Drawing.Size(181, 252);
            this.wordBoard.TabIndex = 1;
            // 
            // DrawBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 272);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DrawBoard";
            this.Text = "画图板";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WordBoard wordBoard;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox OutRichTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}