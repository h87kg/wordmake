namespace WordMake.Forms
{
    partial class BatchMake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchMake));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSelectFile = new System.Windows.Forms.Panel();
            this.buttonINFile = new System.Windows.Forms.Button();
            this.buttonOutFile = new System.Windows.Forms.Button();
            this.textBoxOutFile = new System.Windows.Forms.TextBox();
            this.textBoxINFile = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMaking = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSelectFile.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMaking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "批量生成工具\r\n用于将一个文本文件中的字符生为点阵库。\r\n此方法沿用主窗口的设置并要求指定一个文\r\n本输入文件和一个输出文件。";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(268, 158);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "下一步";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(349, 158);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入文本文件：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(34, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "输出文件：";
            // 
            // panelSelectFile
            // 
            this.panelSelectFile.Controls.Add(this.buttonINFile);
            this.panelSelectFile.Controls.Add(this.buttonOutFile);
            this.panelSelectFile.Controls.Add(this.textBoxOutFile);
            this.panelSelectFile.Controls.Add(this.textBoxINFile);
            this.panelSelectFile.Controls.Add(this.label3);
            this.panelSelectFile.Controls.Add(this.label2);
            this.panelSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelectFile.Location = new System.Drawing.Point(0, 0);
            this.panelSelectFile.Name = "panelSelectFile";
            this.panelSelectFile.Size = new System.Drawing.Size(438, 77);
            this.panelSelectFile.TabIndex = 3;
            // 
            // buttonINFile
            // 
            this.buttonINFile.AutoSize = true;
            this.buttonINFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonINFile.Location = new System.Drawing.Point(397, 17);
            this.buttonINFile.Name = "buttonINFile";
            this.buttonINFile.Size = new System.Drawing.Size(33, 23);
            this.buttonINFile.TabIndex = 1;
            this.buttonINFile.Text = "...";
            this.buttonINFile.UseVisualStyleBackColor = true;
            this.buttonINFile.Click += new System.EventHandler(this.buttonINFile_Click);
            // 
            // buttonOutFile
            // 
            this.buttonOutFile.AutoSize = true;
            this.buttonOutFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOutFile.Location = new System.Drawing.Point(397, 44);
            this.buttonOutFile.Name = "buttonOutFile";
            this.buttonOutFile.Size = new System.Drawing.Size(33, 23);
            this.buttonOutFile.TabIndex = 3;
            this.buttonOutFile.Text = "...";
            this.buttonOutFile.UseVisualStyleBackColor = true;
            this.buttonOutFile.Click += new System.EventHandler(this.buttonINFile_Click);
            // 
            // textBoxOutFile
            // 
            this.textBoxOutFile.Location = new System.Drawing.Point(96, 44);
            this.textBoxOutFile.Name = "textBoxOutFile";
            this.textBoxOutFile.Size = new System.Drawing.Size(295, 21);
            this.textBoxOutFile.TabIndex = 2;
            // 
            // textBoxINFile
            // 
            this.textBoxINFile.Location = new System.Drawing.Point(96, 17);
            this.textBoxINFile.Name = "textBoxINFile";
            this.textBoxINFile.Size = new System.Drawing.Size(295, 21);
            this.textBoxINFile.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.panelMaking);
            this.panelMain.Controls.Add(this.panelSelectFile);
            this.panelMain.Location = new System.Drawing.Point(-2, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(438, 77);
            this.panelMain.TabIndex = 4;
            // 
            // panelMaking
            // 
            this.panelMaking.Controls.Add(this.labelTime);
            this.panelMaking.Controls.Add(this.label4);
            this.panelMaking.Controls.Add(this.progressBar);
            this.panelMaking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaking.Location = new System.Drawing.Point(0, 0);
            this.panelMaking.Name = "panelMaking";
            this.panelMaking.Size = new System.Drawing.Size(438, 77);
            this.panelMaking.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "生成中请稍等...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 48);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(412, 23);
            this.progressBar.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(3, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(433, 4);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Title = "输出文件：";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "文本文件|*.txt";
            this.openFileDialog.Title = "输入文本文件：";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(29, 28);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 12);
            this.labelTime.TabIndex = 2;
            // 
            // BatchMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(438, 186);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchMake";
            this.ShowInTaskbar = false;
            this.Text = "批量生成...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSelectFile.ResumeLayout(false);
            this.panelSelectFile.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMaking.ResumeLayout(false);
            this.panelMaking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSelectFile;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxOutFile;
        private System.Windows.Forms.TextBox textBoxINFile;
        private System.Windows.Forms.Button buttonINFile;
        private System.Windows.Forms.Button buttonOutFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelMaking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTime;
    }
}