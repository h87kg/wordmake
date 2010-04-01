using WordMake.Properties;
namespace WordMake.Forms
{
    partial class WordMakeForm
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
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordMakeForm));
		this.fontDialog = new System.Windows.Forms.FontDialog();
		this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
		this.splitter1 = new System.Windows.Forms.Splitter();
		this.panel1 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.contextMenuStripOut = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.textBoxin = new System.Windows.Forms.TextBox();
		this.wordBoard = new WordMake.Forms.WordBoard();
		this.menuStrip1 = new System.Windows.Forms.MenuStrip();
		this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.配置文件另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.加载预定配置文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.aSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.移除文件中相同字符ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.批量生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.生成字符集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.gB2312ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItemGB2312All = new System.Windows.Forms.ToolStripMenuItem();
		this.一级简码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.二级简码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.高级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripTextBoxGBStart = new System.Windows.Forms.ToolStripTextBox();
		this.toolStripTextBoxGBEnd = new System.Windows.Forms.ToolStripTextBox();
		this.确定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.aSCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ASCII全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.自动生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.画图板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStrip1 = new System.Windows.Forms.ToolStrip();
		this.toolStripComboBoxMultiple = new System.Windows.Forms.ToolStripComboBox();
		this.toolStripComboBoxfont = new System.Windows.Forms.ToolStripComboBox();
		this.toolStripComboBoxFontSize = new System.Windows.Forms.ToolStripComboBox();
		this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
		this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
		this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
		this.toolStripComboBoxModeSize = new System.Windows.Forms.ToolStripComboBox();
		this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
		this.向上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.向下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.向左ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.向右ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.复位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.toolStripTextBox上下偏移 = new System.Windows.Forms.ToolStripTextBox();
		this.toolStripTextBox左右偏移 = new System.Windows.Forms.ToolStripTextBox();
		this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
		this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
		this.简谱播放器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripContainer1.ContentPanel.SuspendLayout();
		this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
		this.toolStripContainer1.SuspendLayout();
		this.panel1.SuspendLayout();
		this.contextMenuStripOut.SuspendLayout();
		this.menuStrip1.SuspendLayout();
		this.toolStrip1.SuspendLayout();
		this.SuspendLayout();
		// 
		// toolStripContainer1
		// 
		// 
		// toolStripContainer1.ContentPanel
		// 
		this.toolStripContainer1.ContentPanel.AutoScroll = true;
		this.toolStripContainer1.ContentPanel.Controls.Add(this.splitter1);
		this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
		this.toolStripContainer1.ContentPanel.Controls.Add(this.wordBoard);
		this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(526, 217);
		this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
		this.toolStripContainer1.Name = "toolStripContainer1";
		this.toolStripContainer1.Size = new System.Drawing.Size(526, 266);
		this.toolStripContainer1.TabIndex = 1;
		this.toolStripContainer1.Text = "toolStripContainer1";
		// 
		// toolStripContainer1.TopToolStripPanel
		// 
		this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
		this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
		// 
		// splitter1
		// 
		this.splitter1.BackColor = System.Drawing.Color.White;
		this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
		this.splitter1.Location = new System.Drawing.Point(0, 129);
		this.splitter1.Name = "splitter1";
		this.splitter1.Size = new System.Drawing.Size(526, 4);
		this.splitter1.TabIndex = 7;
		this.splitter1.TabStop = false;
		// 
		// panel1
		// 
		this.panel1.Controls.Add(this.button1);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.richTextBox1);
		this.panel1.Controls.Add(this.textBoxin);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 129);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(526, 88);
		this.panel1.TabIndex = 6;
		// 
		// button1
		// 
		this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		this.button1.Location = new System.Drawing.Point(439, 6);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 4;
		this.button1.Text = "预览";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(this.button1_Click);
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(3, 10);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(101, 12);
		this.label1.TabIndex = 3;
		this.label1.Text = "在这里输入文字：";
		// 
		// richTextBox1
		// 
		this.richTextBox1.AcceptsTab = true;
		this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			    | System.Windows.Forms.AnchorStyles.Left)
			    | System.Windows.Forms.AnchorStyles.Right)));
		this.richTextBox1.AutoWordSelection = true;
		this.richTextBox1.ContextMenuStrip = this.contextMenuStripOut;
		this.richTextBox1.EnableAutoDragDrop = true;
		this.richTextBox1.HideSelection = false;
		this.richTextBox1.Location = new System.Drawing.Point(0, 36);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.Size = new System.Drawing.Size(523, 49);
		this.richTextBox1.TabIndex = 5;
		this.richTextBox1.Text = "";
		this.richTextBox1.WordWrap = false;
		// 
		// contextMenuStripOut
		// 
		this.contextMenuStripOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.全选ToolStripMenuItem});
		this.contextMenuStripOut.Name = "contextMenuStripOut";
		this.contextMenuStripOut.Size = new System.Drawing.Size(136, 48);
		// 
		// 复制ToolStripMenuItem
		// 
		this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
		this.复制ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
		this.复制ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
		this.复制ToolStripMenuItem.Text = "复制";
		this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
		// 
		// 全选ToolStripMenuItem
		// 
		this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
		this.全选ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
		this.全选ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
		this.全选ToolStripMenuItem.Text = "全选";
		this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
		// 
		// textBoxin
		// 
		this.textBoxin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			    | System.Windows.Forms.AnchorStyles.Right)));
		this.textBoxin.Location = new System.Drawing.Point(110, 7);
		this.textBoxin.MaxLength = 100;
		this.textBoxin.Name = "textBoxin";
		this.textBoxin.Size = new System.Drawing.Size(323, 21);
		this.textBoxin.TabIndex = 1;
		this.textBoxin.TextChanged += new System.EventHandler(this.textBoxin_TextChanged);
		// 
		// wordBoard
		// 
		this.wordBoard.AutoFontSize = global::WordMake.Properties.Settings.Default.自动字体大小;
		this.wordBoard.AutoWidth = global::WordMake.Properties.Settings.Default.变宽;
		this.wordBoard.CharLocation = global::WordMake.Properties.Settings.Default.字模偏移;
		this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::WordMake.Properties.Settings.Default, "字体", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("CharLocation", global::WordMake.Properties.Settings.Default, "字模偏移", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("Multiple", global::WordMake.Properties.Settings.Default, "显示放大倍数", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("LatticeSize", global::WordMake.Properties.Settings.Default, "字模大小", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("AutoFontSize", global::WordMake.Properties.Settings.Default, "自动字体大小", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::WordMake.Properties.Settings.Default, "已点亮区域LCD颜色", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("LcdColor", global::WordMake.Properties.Settings.Default, "未点亮区域LCD颜色", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("FrameColor", global::WordMake.Properties.Settings.Default, "字符线框颜色", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.wordBoard.DataBindings.Add(new System.Windows.Forms.Binding("AutoWidth", global::WordMake.Properties.Settings.Default, "变宽", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.wordBoard.Dock = System.Windows.Forms.DockStyle.Top;
		this.wordBoard.DrawData = null;
		this.wordBoard.EnableDraw = false;
		this.wordBoard.Font = global::WordMake.Properties.Settings.Default.字体;
		this.wordBoard.ForeColor = global::WordMake.Properties.Settings.Default.已点亮区域LCD颜色;
		this.wordBoard.FrameColor = global::WordMake.Properties.Settings.Default.字符线框颜色;
		this.wordBoard.LatticeSize = global::WordMake.Properties.Settings.Default.字模大小;
		this.wordBoard.LcdColor = global::WordMake.Properties.Settings.Default.未点亮区域LCD颜色;
		this.wordBoard.Location = new System.Drawing.Point(0, 0);
		this.wordBoard.ModeHeight = 12;
		this.wordBoard.ModeWidth = 12;
		this.wordBoard.Multiple = global::WordMake.Properties.Settings.Default.显示放大倍数;
		this.wordBoard.Name = "wordBoard";
		this.wordBoard.Size = new System.Drawing.Size(526, 129);
		this.wordBoard.TabIndex = 0;
		this.wordBoard.Text = "WordMake";
		this.wordBoard.MultipleChanged += new System.EventHandler(this.toolStripComboBoxMultiple_Leave);
		this.wordBoard.CharLocationChanged += new System.EventHandler(this.wordBoard_CharLocationChanged);
		this.wordBoard.FontChanged += new System.EventHandler(this.wordBoard_FontChanged);
		this.wordBoard.AutoFontSizeChanged += new System.EventHandler(this.wordBoard_AutoFontSizeChanged);
		this.wordBoard.LatticeSizeChanged += new System.EventHandler(this.wordBoard_LatticeSizeChanged);
		// 
		// menuStrip1
		// 
		this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
		this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
		this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.选项ToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.toolStripMenuItem1});
		this.menuStrip1.Location = new System.Drawing.Point(3, 0);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.Size = new System.Drawing.Size(340, 24);
		this.menuStrip1.Stretch = false;
		this.menuStrip1.TabIndex = 0;
		this.menuStrip1.Text = "menuStrip1";
		// 
		// 文件FToolStripMenuItem
		// 
		this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置文件另存为ToolStripMenuItem,
            this.加载ToolStripMenuItem,
            this.加载预定配置文件ToolStripMenuItem});
		this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
		this.文件FToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
		this.文件FToolStripMenuItem.Text = "文件(&F)";
		// 
		// 配置文件另存为ToolStripMenuItem
		// 
		this.配置文件另存为ToolStripMenuItem.Name = "配置文件另存为ToolStripMenuItem";
		this.配置文件另存为ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.配置文件另存为ToolStripMenuItem.Text = global::WordMake.Properties.Resources.配置文件另存为;
		this.配置文件另存为ToolStripMenuItem.Click += new System.EventHandler(this.配置文件另存为ToolStripMenuItem_Click);
		// 
		// 加载ToolStripMenuItem
		// 
		this.加载ToolStripMenuItem.Name = "加载ToolStripMenuItem";
		this.加载ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.加载ToolStripMenuItem.Text = "加载配置文件...";
		this.加载ToolStripMenuItem.Click += new System.EventHandler(this.加载ToolStripMenuItem_Click);
		// 
		// 加载预定配置文件ToolStripMenuItem
		// 
		this.加载预定配置文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.aSMToolStripMenuItem});
		this.加载预定配置文件ToolStripMenuItem.Name = "加载预定配置文件ToolStripMenuItem";
		this.加载预定配置文件ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.加载预定配置文件ToolStripMenuItem.Text = "加载预定配置文件";
		// 
		// cToolStripMenuItem
		// 
		this.cToolStripMenuItem.Name = "cToolStripMenuItem";
		this.cToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
		this.cToolStripMenuItem.Text = "C";
		this.cToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
		// 
		// aSMToolStripMenuItem
		// 
		this.aSMToolStripMenuItem.Name = "aSMToolStripMenuItem";
		this.aSMToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
		this.aSMToolStripMenuItem.Text = "ASM";
		this.aSMToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
		// 
		// 选项ToolStripMenuItem
		// 
		this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体ToolStripMenuItem});
		this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
		this.选项ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
		this.选项ToolStripMenuItem.Text = "选项";
		// 
		// 字体ToolStripMenuItem
		// 
		this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
		this.字体ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
		this.字体ToolStripMenuItem.Text = "选项";
		this.字体ToolStripMenuItem.Click += new System.EventHandler(this.OptionToolStripMenuItem_Click);
		// 
		// 工具TToolStripMenuItem
		// 
		this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.移除文件中相同字符ToolStripMenuItem,
            this.批量生成ToolStripMenuItem,
            this.生成字符集ToolStripMenuItem,
            this.自动生成ToolStripMenuItem,
            this.画图板ToolStripMenuItem,
            this.简谱播放器ToolStripMenuItem});
		this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
		this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
		this.工具TToolStripMenuItem.Text = "工具(&T)";
		// 
		// 移除文件中相同字符ToolStripMenuItem
		// 
		this.移除文件中相同字符ToolStripMenuItem.Name = "移除文件中相同字符ToolStripMenuItem";
		this.移除文件中相同字符ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.移除文件中相同字符ToolStripMenuItem.Text = "移除文件中相同字符..";
		this.移除文件中相同字符ToolStripMenuItem.Click += new System.EventHandler(this.移除文件中相同字符ToolStripMenuItem_Click);
		// 
		// 批量生成ToolStripMenuItem
		// 
		this.批量生成ToolStripMenuItem.Name = "批量生成ToolStripMenuItem";
		this.批量生成ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.批量生成ToolStripMenuItem.Text = "批量生成...";
		this.批量生成ToolStripMenuItem.Click += new System.EventHandler(this.批量生成ToolStripMenuItem_Click);
		// 
		// 生成字符集ToolStripMenuItem
		// 
		this.生成字符集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gB2312ToolStripMenuItem,
            this.aSCIIToolStripMenuItem});
		this.生成字符集ToolStripMenuItem.Name = "生成字符集ToolStripMenuItem";
		this.生成字符集ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.生成字符集ToolStripMenuItem.Text = "生成字符集文本";
		// 
		// gB2312ToolStripMenuItem
		// 
		this.gB2312ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGB2312All,
            this.一级简码ToolStripMenuItem,
            this.二级简码ToolStripMenuItem,
            this.高级ToolStripMenuItem});
		this.gB2312ToolStripMenuItem.Name = "gB2312ToolStripMenuItem";
		this.gB2312ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
		this.gB2312ToolStripMenuItem.Text = "GB2312";
		// 
		// toolStripMenuItemGB2312All
		// 
		this.toolStripMenuItemGB2312All.Name = "toolStripMenuItemGB2312All";
		this.toolStripMenuItemGB2312All.Size = new System.Drawing.Size(118, 22);
		this.toolStripMenuItemGB2312All.Text = "GB2312";
		this.toolStripMenuItemGB2312All.Click += new System.EventHandler(this.gB2312ToolStripMenuItem_Click);
		// 
		// 一级简码ToolStripMenuItem
		// 
		this.一级简码ToolStripMenuItem.Name = "一级简码ToolStripMenuItem";
		this.一级简码ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
		this.一级简码ToolStripMenuItem.Text = "一级简码";
		this.一级简码ToolStripMenuItem.Click += new System.EventHandler(this.gB2312ToolStripMenuItem_Click);
		// 
		// 二级简码ToolStripMenuItem
		// 
		this.二级简码ToolStripMenuItem.Name = "二级简码ToolStripMenuItem";
		this.二级简码ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
		this.二级简码ToolStripMenuItem.Text = "二级简码";
		this.二级简码ToolStripMenuItem.Click += new System.EventHandler(this.gB2312ToolStripMenuItem_Click);
		// 
		// 高级ToolStripMenuItem
		// 
		this.高级ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxGBStart,
            this.toolStripTextBoxGBEnd,
            this.确定ToolStripMenuItem});
		this.高级ToolStripMenuItem.Name = "高级ToolStripMenuItem";
		this.高级ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
		this.高级ToolStripMenuItem.Text = "高级";
		// 
		// toolStripTextBoxGBStart
		// 
		this.toolStripTextBoxGBStart.MaxLength = 2;
		this.toolStripTextBoxGBStart.Name = "toolStripTextBoxGBStart";
		this.toolStripTextBoxGBStart.Size = new System.Drawing.Size(100, 21);
		this.toolStripTextBoxGBStart.ToolTipText = "输入GB2312的起始区号";
		// 
		// toolStripTextBoxGBEnd
		// 
		this.toolStripTextBoxGBEnd.MaxLength = 2;
		this.toolStripTextBoxGBEnd.Name = "toolStripTextBoxGBEnd";
		this.toolStripTextBoxGBEnd.Size = new System.Drawing.Size(100, 21);
		this.toolStripTextBoxGBEnd.ToolTipText = "输入GB2312的结束区号";
		// 
		// 确定ToolStripMenuItem
		// 
		this.确定ToolStripMenuItem.Name = "确定ToolStripMenuItem";
		this.确定ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
		this.确定ToolStripMenuItem.Text = "确定";
		this.确定ToolStripMenuItem.Click += new System.EventHandler(this.确定ToolStripMenuItem_Click);
		// 
		// aSCIIToolStripMenuItem
		// 
		this.aSCIIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ASCII全部ToolStripMenuItem});
		this.aSCIIToolStripMenuItem.Name = "aSCIIToolStripMenuItem";
		this.aSCIIToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
		this.aSCIIToolStripMenuItem.Text = "ASCII";
		// 
		// ASCII全部ToolStripMenuItem
		// 
		this.ASCII全部ToolStripMenuItem.Name = "ASCII全部ToolStripMenuItem";
		this.ASCII全部ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
		this.ASCII全部ToolStripMenuItem.Text = "全部";
		this.ASCII全部ToolStripMenuItem.Click += new System.EventHandler(this.gB2312ToolStripMenuItem_Click);
		// 
		// 自动生成ToolStripMenuItem
		// 
		this.自动生成ToolStripMenuItem.Name = "自动生成ToolStripMenuItem";
		this.自动生成ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.自动生成ToolStripMenuItem.Text = "自动生成..";
		this.自动生成ToolStripMenuItem.Click += new System.EventHandler(this.自动生成ToolStripMenuItem_Click);
		// 
		// 画图板ToolStripMenuItem
		// 
		this.画图板ToolStripMenuItem.Name = "画图板ToolStripMenuItem";
		this.画图板ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.画图板ToolStripMenuItem.Text = "画图板";
		this.画图板ToolStripMenuItem.Click += new System.EventHandler(this.画图板ToolStripMenuItem_Click);
		// 
		// toolStripMenuItem1
		// 
		this.toolStripMenuItem1.Name = "toolStripMenuItem1";
		this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
		this.toolStripMenuItem1.Text = "关于...(&A)";
		this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
		// 
		// toolStrip1
		// 
		this.toolStrip1.AllowItemReorder = true;
		this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
		this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxMultiple,
            this.toolStripComboBoxfont,
            this.toolStripComboBoxFontSize,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonUnderline,
            this.toolStripComboBoxModeSize,
            this.toolStripDropDownButton1});
		this.toolStrip1.Location = new System.Drawing.Point(3, 24);
		this.toolStrip1.Name = "toolStrip1";
		this.toolStrip1.Size = new System.Drawing.Size(464, 25);
		this.toolStrip1.TabIndex = 1;
		// 
		// toolStripComboBoxMultiple
		// 
		this.toolStripComboBoxMultiple.Items.AddRange(new object[] {
            "放大1倍",
            "放大2倍",
            "放大3倍",
            "放大4倍",
            "放大5倍",
            "放大6倍",
            "放大7倍",
            "放大8倍"});
		this.toolStripComboBoxMultiple.MaxLength = 2;
		this.toolStripComboBoxMultiple.Name = "toolStripComboBoxMultiple";
		this.toolStripComboBoxMultiple.Size = new System.Drawing.Size(75, 25);
		this.toolStripComboBoxMultiple.ToolTipText = "显示缩放";
		this.toolStripComboBoxMultiple.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxMultiple_SelectedIndexChanged);
		this.toolStripComboBoxMultiple.TextUpdate += new System.EventHandler(this.toolStripComboBoxMultiple_TextUpdate);
		this.toolStripComboBoxMultiple.Leave += new System.EventHandler(this.toolStripComboBoxMultiple_Leave);
		this.toolStripComboBoxMultiple.Click += new System.EventHandler(this.toolStripComboBoxClearText);
		// 
		// toolStripComboBoxfont
		// 
		this.toolStripComboBoxfont.DropDownWidth = 220;
		this.toolStripComboBoxfont.Name = "toolStripComboBoxfont";
		this.toolStripComboBoxfont.Size = new System.Drawing.Size(121, 25);
		this.toolStripComboBoxfont.ToolTipText = "字体";
		this.toolStripComboBoxfont.TextChanged += new System.EventHandler(this.toolStripComboBoxfont_TextChanged);
		// 
		// toolStripComboBoxFontSize
		// 
		this.toolStripComboBoxFontSize.Items.AddRange(new object[] {
            "自动",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "14",
            "18",
            "24",
            "32",
            "64"});
		this.toolStripComboBoxFontSize.Name = "toolStripComboBoxFontSize";
		this.toolStripComboBoxFontSize.Size = new System.Drawing.Size(75, 25);
		this.toolStripComboBoxFontSize.ToolTipText = "字号";
		this.toolStripComboBoxFontSize.TextChanged += new System.EventHandler(this.toolStripComboBoxFontSize_TextChanged);
		// 
		// toolStripButtonBold
		// 
		this.toolStripButtonBold.CheckOnClick = true;
		this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.toolStripButtonBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBold.Image")));
		this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButtonBold.Name = "toolStripButtonBold";
		this.toolStripButtonBold.Size = new System.Drawing.Size(23, 22);
		this.toolStripButtonBold.Text = "加粗";
		this.toolStripButtonBold.CheckedChanged += new System.EventHandler(this.toolStripButtonFont_CheckedChanged);
		// 
		// toolStripButtonItalic
		// 
		this.toolStripButtonItalic.CheckOnClick = true;
		this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.toolStripButtonItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonItalic.Image")));
		this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButtonItalic.Name = "toolStripButtonItalic";
		this.toolStripButtonItalic.Size = new System.Drawing.Size(23, 22);
		this.toolStripButtonItalic.Text = "斜体";
		this.toolStripButtonItalic.CheckedChanged += new System.EventHandler(this.toolStripButtonFont_CheckedChanged);
		// 
		// toolStripButtonUnderline
		// 
		this.toolStripButtonUnderline.CheckOnClick = true;
		this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.toolStripButtonUnderline.Image = global::WordMake.Properties.Resources.Underline;
		this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
		this.toolStripButtonUnderline.Size = new System.Drawing.Size(23, 22);
		this.toolStripButtonUnderline.Text = "下划线";
		this.toolStripButtonUnderline.CheckedChanged += new System.EventHandler(this.toolStripButtonFont_CheckedChanged);
		this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonFont_Click);
		// 
		// toolStripComboBoxModeSize
		// 
		this.toolStripComboBoxModeSize.DropDownHeight = 200;
		this.toolStripComboBoxModeSize.IntegralHeight = false;
		this.toolStripComboBoxModeSize.Items.AddRange(new object[] {
            "8,8",
            "12,12",
            "16,16",
            "24,24",
            "32,32",
            "64,64",
            "当然您可以自定义(宽),(高)"});
		this.toolStripComboBoxModeSize.Name = "toolStripComboBoxModeSize";
		this.toolStripComboBoxModeSize.Size = new System.Drawing.Size(75, 25);
		this.toolStripComboBoxModeSize.Text = "12,12";
		this.toolStripComboBoxModeSize.ToolTipText = "指定生成字模高宽\r\n当然您可以自定义\r\n用(宽),(高)的形式\r\n但不要太大哟";
		this.toolStripComboBoxModeSize.TextChanged += new System.EventHandler(this.toolStripComboBoxModeSize_TextChanged);
		// 
		// toolStripDropDownButton1
		// 
		this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.向上ToolStripMenuItem,
            this.向下ToolStripMenuItem,
            this.向左ToolStripMenuItem,
            this.向右ToolStripMenuItem,
            this.复位ToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripTextBox上下偏移,
            this.toolStripTextBox左右偏移});
		this.toolStripDropDownButton1.Image = global::WordMake.Properties.Resources.Offset;
		this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
		this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
		this.toolStripDropDownButton1.Text = "偏移";
		// 
		// 向上ToolStripMenuItem
		// 
		this.向上ToolStripMenuItem.Image = global::WordMake.Properties.Resources.TopArrow2HS;
		this.向上ToolStripMenuItem.Name = "向上ToolStripMenuItem";
		this.向上ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
		this.向上ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
		this.向上ToolStripMenuItem.Text = "向上";
		this.向上ToolStripMenuItem.Click += new System.EventHandler(this.CharOffsetToolStripMenuItem_Click);
		// 
		// 向下ToolStripMenuItem
		// 
		this.向下ToolStripMenuItem.Image = global::WordMake.Properties.Resources.BottomArrow2HS;
		this.向下ToolStripMenuItem.Name = "向下ToolStripMenuItem";
		this.向下ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
		this.向下ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
		this.向下ToolStripMenuItem.Text = "向下";
		this.向下ToolStripMenuItem.Click += new System.EventHandler(this.CharOffsetToolStripMenuItem_Click);
		// 
		// 向左ToolStripMenuItem
		// 
		this.向左ToolStripMenuItem.Image = global::WordMake.Properties.Resources.LiftArrow2HS;
		this.向左ToolStripMenuItem.Name = "向左ToolStripMenuItem";
		this.向左ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
		this.向左ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
		this.向左ToolStripMenuItem.Text = "向左";
		this.向左ToolStripMenuItem.Click += new System.EventHandler(this.CharOffsetToolStripMenuItem_Click);
		// 
		// 向右ToolStripMenuItem
		// 
		this.向右ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("向右ToolStripMenuItem.Image")));
		this.向右ToolStripMenuItem.Name = "向右ToolStripMenuItem";
		this.向右ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
		this.向右ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
		this.向右ToolStripMenuItem.Text = "向右";
		this.向右ToolStripMenuItem.Click += new System.EventHandler(this.CharOffsetToolStripMenuItem_Click);
		// 
		// 复位ToolStripMenuItem
		// 
		this.复位ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复位ToolStripMenuItem.Image")));
		this.复位ToolStripMenuItem.Name = "复位ToolStripMenuItem";
		this.复位ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
		this.复位ToolStripMenuItem.Text = "复位";
		this.复位ToolStripMenuItem.Click += new System.EventHandler(this.CharOffsetToolStripMenuItem_Click);
		// 
		// toolStripSeparator1
		// 
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
		// 
		// toolStripTextBox上下偏移
		// 
		this.toolStripTextBox上下偏移.AutoToolTip = true;
		this.toolStripTextBox上下偏移.Name = "toolStripTextBox上下偏移";
		this.toolStripTextBox上下偏移.Size = new System.Drawing.Size(100, 21);
		this.toolStripTextBox上下偏移.ToolTipText = "编辑上下偏移";
		this.toolStripTextBox上下偏移.TextChanged += new System.EventHandler(this.toolStripTextBox偏移_TextChanged);
		// 
		// toolStripTextBox左右偏移
		// 
		this.toolStripTextBox左右偏移.AutoToolTip = true;
		this.toolStripTextBox左右偏移.Name = "toolStripTextBox左右偏移";
		this.toolStripTextBox左右偏移.Size = new System.Drawing.Size(100, 21);
		this.toolStripTextBox左右偏移.ToolTipText = "编辑左右偏移";
		this.toolStripTextBox左右偏移.TextChanged += new System.EventHandler(this.toolStripTextBox偏移_TextChanged);
		// 
		// 简谱播放器ToolStripMenuItem
		// 
		this.简谱播放器ToolStripMenuItem.Name = "简谱播放器ToolStripMenuItem";
		this.简谱播放器ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.简谱播放器ToolStripMenuItem.Text = "简谱播放器";
		this.简谱播放器ToolStripMenuItem.Click += new System.EventHandler(this.简谱播放器ToolStripMenuItem_Click);
		// 
		// WordMakeForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(526, 266);
		this.Controls.Add(this.toolStripContainer1);
		this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::WordMake.Properties.Settings.Default, "主窗口位置", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.ForeColor = System.Drawing.SystemColors.ControlText;
		this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		this.Location = global::WordMake.Properties.Settings.Default.主窗口位置;
		this.MainMenuStrip = this.menuStrip1;
		this.Name = "WordMakeForm";
		this.Text = "WordMake";
		this.Load += new System.EventHandler(this.WordMakeForm_Load);
		this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordMakeForm_FormClosing);
		this.toolStripContainer1.ContentPanel.ResumeLayout(false);
		this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
		this.toolStripContainer1.TopToolStripPanel.PerformLayout();
		this.toolStripContainer1.ResumeLayout(false);
		this.toolStripContainer1.PerformLayout();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.contextMenuStripOut.ResumeLayout(false);
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		this.toolStrip1.ResumeLayout(false);
		this.toolStrip1.PerformLayout();
		this.ResumeLayout(false);

        }

        #endregion

        private WordBoard wordBoard;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.TextBox textBoxin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxMultiple;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxfont;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxModeSize;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量生成ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFontSize;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 向上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向左ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向右ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox上下偏移;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox左右偏移;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderline;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置文件另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成字符集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gB2312ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGB2312All;
        private System.Windows.Forms.ToolStripMenuItem 一级简码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二级简码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxGBStart;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxGBEnd;
        private System.Windows.Forms.ToolStripMenuItem 确定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载预定配置文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSMToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOut;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aSCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ASCII全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除文件中相同字符ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画图板ToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem 简谱播放器ToolStripMenuItem;
    }
}

