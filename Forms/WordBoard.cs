using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Threading;

namespace WordMake.Forms
{
    public partial class WordBoard : Control
    {
        private static readonly Color fC = Color.FromArgb(0, 0, 0);
        private static readonly Color bC = Color.FromArgb(255, 255, 255);
        private static readonly int bCi = bC.ToArgb();

        private Color lcdColor = Color.Red;
        private Color frameColor = Color.FromArgb(100, 0, 0, 255);
        private Char @char;
        private Size latticeSize = new Size(16, 16);
        private Size oldSize;
        private Point charLocation;
        private PointF charOffset;
        private bool autoFontSize = true;
        private bool enableDraw = false;

        private int multiple = 5;
        private int width = 16;
        private int height = 16;
        private int working = 1;

        StringFormat stringFormat;
        private Brush fbrush = new SolidBrush(fC);
        private Bitmap bitmap, showBitmap;
        private Graphics g;
        private Font font;
        private BitArray drawData;
        public BitArray DrawData
        {
            get { return drawData; }
            set { drawData = value; }
        }

        public WordBoard()
        {
            stringFormat = (StringFormat)(StringFormat.GenericDefault.Clone());
            stringFormat.FormatFlags = StringFormatFlags.NoFontFallback | StringFormatFlags.MeasureTrailingSpaces;
            //charMake = new CharMake();
            //this.DataBindings.DefaultDataSourceUpdateMode
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
            this.font = base.Font;
            InitializeComponent();
            oldSize = Size;
        }
        public bool EnableDraw
        {
            get
            {
                return enableDraw;
            }
            set
            {
                if (enableDraw != value)
                {
                    enableDraw = value;
                    if (enableDraw)
                        drawData = new BitArray(latticeSize.Width * latticeSize.Height);
                    else
                        drawData = null;
                }
              

            }
        }
        bool MouseDownColor;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="p"></param>
     /// <param name="dat"></param>
        void setDrawData(Point p,bool dat)
        {
            if (enableDraw)
            {
                Rectangle r = new Rectangle(0, 0, latticeSize.Width * multiple, latticeSize.Height * multiple);

                if (r.Contains(p))
                {
                    int index = (p.X / multiple) + (p.Y / multiple) * latticeSize.Width;
                    drawData[index] = dat;
                    if (working > 0)
                    {
                        redrawShowBitmap();
                        this.Refresh();
                    }
                }
            }
        }
        bool getDrawData(Point p)
        {
            if (enableDraw)
            {
                Rectangle r = new Rectangle(0, 0, latticeSize.Width * multiple, latticeSize.Height * multiple);

                if (r.Contains(p))
                {
                    int index = (p.X / multiple) + (p.Y / multiple) * latticeSize.Width;
                    return drawData[index];
                }
            }
            return false;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            MouseDownColor = getDrawData(e.Location);
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                setDrawData(e.Location, !MouseDownColor);
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            setDrawData(e.Location, !MouseDownColor);
            base.OnMouseClick(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(showBitmap, 0, 0);
            base.OnPaint(e);
        }

        private void redrawShowBitmap()
        {
            if (showBitmap == null)
                return;
            int ib = 0;
            int w = width, h = height;
            Graphics g = Graphics.FromImage(showBitmap);
            Pen fp = new Pen(frameColor, multiple / 4);
            fp.Alignment = PenAlignment.Inset;
            Brush Fbrush = new SolidBrush(this.ForeColor);
            Brush Bbrush = new SolidBrush(this.lcdColor);
            int lsize = multiple / 4;
            Rectangle Bdr = new Rectangle(0, 0, multiple - lsize, multiple - lsize);
            Rectangle fr = new Rectangle(0, 0, multiple * w, multiple * h);
            Bitmap rectBitmap = new Bitmap(multiple, multiple);
            Graphics mapg = Graphics.FromImage(rectBitmap);
            mapg.Clear(this.BackColor);
            mapg.FillRectangle(Bbrush, Bdr);
            //mapg.Dispose();
            TextureBrush textureB = new TextureBrush(rectBitmap);
            g.FillRectangle(textureB, this.DisplayRectangle);
            textureB.Dispose();
            //mapg.FillRectangle(Fbrush, Bdr);
            //textureB = new TextureBrush(rectBitmap); 
            mapg.Dispose();
            rectBitmap.Dispose();
            g.SmoothingMode = SmoothingMode.HighSpeed;
            if (enableDraw)
            {
                BitArray bita = drawData;
                for (int i = 0; i < h; i++)
                {
                    for (int k = 0; k < w; k++)
                    {
                        if (bita[ib++])
                        {
                            g.FillRectangle(Fbrush, Bdr);
                        }
                        Bdr.X += multiple;
                    }
                    Bdr.X -= w * multiple;
                    Bdr.Y += multiple;
                }
                g.DrawRectangle(fp, fr);
                fr.X = fr.Right;
                if (!DisplayRectangle.Contains(new Point(fr.Right, fr.Y)))
                {
                    fr.X = 0;
                    fr.Y = fr.Bottom;
                }
                Bdr.Location = fr.Location;
                ib = 0;
            }
            else
            {
                for (int istr = 0; istr < this.Text.Length; istr++)
                {
                    if (!DisplayRectangle.Contains(fr.Location))
                    {
                        break;
                    }
                    BitArray bita = this.GetCharMap(this.Text[istr]);
                    for (int i = 0; i < h; i++)
                    {
                        for (int k = 0; k < w; k++)
                        {
                            if (bita[ib++])
                            {
                                g.FillRectangle(Fbrush, Bdr);
                            }
                            Bdr.X += multiple;
                        }
                        Bdr.X -= w * multiple;
                        Bdr.Y += multiple;
                    }
                    g.DrawRectangle(fp, fr);
                    fr.X = fr.Right;
                    if (!DisplayRectangle.Contains(new Point(fr.Right, fr.Y)))
                    {
                        fr.X = 0;
                        fr.Y = fr.Bottom;
                    }
                    Bdr.Location = fr.Location;
                    ib = 0;
                }
            }
            fp.Dispose();
            Fbrush.Dispose();
            Bbrush.Dispose();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (base.Text != value)
                {
                    base.Text = value;
                    if (working > 0)
                    {
                        redrawShowBitmap();
                        this.Refresh();
                    }
                }
            }
        }
        public override System.Drawing.Font Font
        {
            get
            {
                return font;
            }
            set
            {
                if (AutoFontSize)
                {
                    if (value.Name == font.Name && value.Style == font.Style)
                    {
                        return;
                    }
                }
                if (font != value)
                {
                    font = value;
                    if (!AutoFontSize)
                    {
                        OnFontChanged(EventArgs.Empty);
                    }
                    Ini();
                    if (working > 0)
                    {
                        redrawShowBitmap();
                        this.Refresh();
                    }
                }
            }
        }

        /// <summary>
        /// 获取字符的点阵表示
        /// </summary>
        /// <returns>有左至右，由上至下，的扫描结果。第一个像素(对应字符的左上角)由BitArray[0]表示</returns>
        public BitArray GetCharMap(char c)
        {
            SetChar(c);
            return this.CharMap;
        }
        [DefaultValueAttribute(typeof(Size), "16,16")]
        [DescriptionAttribute("设置默认的点阵大小")]
        [BrowsableAttribute(true)]
        [Category("Behavior")]
        public Size LatticeSize
        {
            get
            {
                return latticeSize;
            }
            set
            {
                if (value.Height == 0 || value.Width == 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                if (latticeSize != value)
                {
                    latticeSize = value;
                    this.width = latticeSize.Width;
                    this.height = latticeSize.Height;
                    if(enableDraw)
                        drawData = new BitArray(latticeSize.Width * latticeSize.Height);
                    if (LatticeSizeChanged != null)
                    {
                        LatticeSizeChanged(this, EventArgs.Empty);
                    }
                    Ini();
                    if (working > 0)
                    {
                        redrawShowBitmap();
                        this.Refresh();
                    }
                }
            }
        }
        public void ReDraw()
        {
                redrawShowBitmap();
                this.Refresh();
            
        }
        [DefaultValueAttribute(typeof(Color), "255,0,0")]
        [DescriptionAttribute("设置背景lcd颜色")]
        [BrowsableAttribute(true)]
        [Category("Appearance")]
        public Color LcdColor
        {
            get
            {
                return lcdColor;
            }
            set
            {
                if (lcdColor != value)
                {
                    this.lcdColor = value;
                    if (working > 0)
                    {
                        redrawShowBitmap();
                        this.Refresh();
                    }
                }
            }
        }
        [DefaultValueAttribute(typeof(Color), "100,0,0,255")]
        [DescriptionAttribute("边框颜色")]
        [BrowsableAttribute(true)]
        [Category("Appearance")]
        public Color FrameColor
        {
            get
            {
                return frameColor;
            }
            set
            {
                if (frameColor != value)
                {
                    frameColor = value;

                    if (working > 0)
                    {
                        redrawShowBitmap();
                        Refresh();
                    }
                }
            }
        }

        [DefaultValueAttribute(true)]
        [DescriptionAttribute("为真将自动缩放字体以适合输出")]
        [BrowsableAttribute(true)]
        [Category("Behavior")]
        public bool AutoFontSize
        {
            get
            {
                return autoFontSize;
            }
            set
            {
                if (autoFontSize != value)
                {
                    autoFontSize = value;
                    if (AutoFontSizeChanged != null)
                    {
                        AutoFontSizeChanged(this, EventArgs.Empty);
                    }
                    if (value)
                    {
                        Ini();
                        if (working > 0)
                        {
                            redrawShowBitmap();
                            Refresh();
                        }
                    }


                }
            }
        }
        [DefaultValueAttribute(5)]
        [DescriptionAttribute("字体的放大倍数")]
        [BrowsableAttribute(true)]
        [Category("Appearance")]
        /// <summary>
        /// 字体的放大倍数
        /// </summary>
        public int Multiple
        {
            get
            {
                return multiple;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Multiple必须大于1");
                }
                if (this.multiple != value)
                {
                    this.multiple = value;

                    if (MultipleChanged != null)
                    {
                        MultipleChanged(this, EventArgs.Empty);
                    }
                    if (working > 0)
                    {
                        redrawShowBitmap();
                        this.Refresh();
                    }
                }

            }
        }

        /// <summary>
        /// 获取生成点阵的点数
        /// </summary>
        [BrowsableAttribute(false)]
        public int BitCount
        {
            get
            {
                return height * width;
            }
        }
        [DefaultValueAttribute(null)]
        [DescriptionAttribute("Multiple属性已更改。")]
        [BrowsableAttribute(true)]
        [Category("属性已更改")]
        public event EventHandler MultipleChanged;
        [DefaultValueAttribute(null)]
        [DescriptionAttribute("AutoFontSize属性已更改。")]
        [BrowsableAttribute(true)]
        [Category("属性已更改")]
        public event EventHandler AutoFontSizeChanged;
        [DefaultValueAttribute(null)]
        [DescriptionAttribute("CharLocation属性已更改。")]
        [BrowsableAttribute(true)]
        [Category("属性已更改")]
        public event EventHandler CharLocationChanged;
        [DefaultValueAttribute(null)]
        [DescriptionAttribute("LatticeSize属性已更改。")]
        [BrowsableAttribute(true)]
        [Category("属性已更改")]
        public event EventHandler LatticeSizeChanged;

        /// <summary>
        /// 挂起对WordBoard的更改的重绘请求
        /// </summary>
        public void Suspend()
        {
            working--;
        }

        /// <summary>
        /// 应用对WordBoard的更改，初始化WordBoard后需要调用以开始工作。调用Suspend方法后也需调用，并且每次掉用Suspend方法都需对应的调用此方法。
        /// </summary>
        public void Resume()
        {
            working++;
            if (working > 0)
            {
                working = 1;
                Refresh();
            }
        }


        public PointF CharOffset
        {
            get { return charOffset; }
        }
        [DefaultValueAttribute(typeof(PointF), "0,0")]
        [DescriptionAttribute("设置输出文字的偏移")]
        [BrowsableAttribute(true)]
        [Category("Behavior")]
        public Point CharLocation
        {
            get
            {
                return charLocation;
            }
            set
            {
                if (charLocation != value)
                {
                    charLocation = value;
                    if (CharLocationChanged != null)
                    {
                        CharLocationChanged(this, EventArgs.Empty);
                    }
                    Ini();
                    if (working > 0)
                    {
                        redrawShowBitmap();
                        Refresh();
                    }
                }
            }
        }




        /// <summary>
        /// 计算合适的字体大小与偏移，并创建“g”和“bitmap”。
        /// </summary>
        /// <remarks>关联属性更改后调用</remarks>
        private void Ini()
        {
            if (bitmap != null)
            {
                if (latticeSize != bitmap.Size)
                {
                    bitmap.Dispose();
                    bitmap = null;
                    if (g != null)
                    {
                        g.Dispose();
                    }
                }
            }
            if (bitmap == null)
            {
                bitmap = new Bitmap(width, height);
                g = Graphics.FromImage(bitmap);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            }
            if (autoFontSize)
            {
                float h = height;
                Font fontn = new Font(Font.FontFamily, h, Font.Style, GraphicsUnit.Pixel);
                if (!fontn.Equals(font))
                {
                    font = fontn;
                    base.OnFontChanged(EventArgs.Empty);
                }
            }

            RectangleF re = new Rectangle(0, 0, 10000, 10000);
            StringFormat sf = new StringFormat();
            string testString = "w";
            CharacterRange[] cr = { new CharacterRange(0, 1) };//,new CharacterRange(1,1)};
            sf.SetMeasurableCharacterRanges(cr);
            Region[] charRegions;
            charRegions = g.MeasureCharacterRanges(testString, font, re, sf);
            if (charRegions.Length > 0)
            {
                PointF t2 = charRegions[0].GetBounds(g).Location;
                charOffset = new PointF(charLocation.X - t2.X, charLocation.Y - t2.Y);
            }
            sf.Dispose();
            DrawChar();

        }

        /// <summary>
        /// 获取字符的点阵表示
        /// </summary>
        /// <returns>有左至右，由上至下，的扫描结果。第一个像素(对应字符的左上角)由BitArray[0]表示</returns>
        public BitArray CharMap
        {
            get
            {
                int fCi;
                BitArray map = new BitArray(height * width, false);
                int ib = 0;
                for (int i = 0; i < height; i++)
                {
                    for (int k = 0; k < width; k++)
                    {
                        fCi = bitmap.GetPixel(k, i).ToArgb();

                        if (fCi != bCi)
                        {
                            map[ib] = true;
                        }
                        ib++;
                    }
                }
                return map;
            }
        }

        private void DrawChar()
        {
            //lock (Lock)
            {
                g.Clear(bC);
                //string ds = " "+@char+" ";
                string ds = @char.ToString();
                //try
                {
                    g.DrawString(ds, font, fbrush, charOffset, stringFormat);

                }
                //catch (Exception ee)
                {
                    // MessageBox.Show(this, ee.Message+Thread.CurrentThread.Name);
                }
            }

        }
        public void SetChar(char value)
        {
            if (@char != value)
            {
                this.@char = value;
                DrawChar();
            }
        }
        /// <summary>
        /// 获取字符的点阵表示指定点的值。由左至右，由上至下的方式扫描。第一个像素(对应字符的左上角)由CharMake[0,0]表示
        /// </summary>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        /// <returns>在 [x,y] 位置处的位的值。</returns>
        public bool this[int x, int y]
        {
            get
            {
                if (enableDraw)
                   return  drawData[y * width + x];
                else
                    return (bitmap.GetPixel(x, y).ToArgb() != bCi);
            }
        }
        /// <summary>
        /// 获取字符的点阵表示指定点的值。由左至右，由上至下的方式扫描。第一个像素(对应字符的左上角)由CharMake[0]表示
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns>在 [index] 位置处的位的值。</returns>
        public bool this[int index]
        {
            get
            {
                return this[index % width, index / width];
            }
        }
        public int ModeWidth
        {
            get
            {
                return width;
            }
            set
            {
                if (width != value)
                {
                    LatticeSize = new Size(value, latticeSize.Height);
                }
            }
        }
        public int ModeHeight
        {
            get
            {
                return height;
            }
            set
            {
                if (height != value)
                {
                    LatticeSize = new Size(latticeSize.Width, value);
                }
            }
        }

        /// <summary>
        /// 创建WordBoard的副本
        /// </summary>
        public WordBoard Clone()
        {
            WordBoard o = new WordBoard();
            o.AutoFontSize = this.AutoFontSize;
            o.CharLocation = this.CharLocation;
            o.Font = (Font)(Font.Clone());
            o.FrameColor = this.FrameColor;
            o.LatticeSize = this.LatticeSize;
            o.LcdColor = this.LcdColor;
            o.Multiple = this.Multiple;
            o.Text = this.Text;
            return o;
        }

        /// <param name="e">包含事件数据的 <see cref="T:System.EventArgs"></see>。</param>
        protected override void OnSizeChanged(System.EventArgs e)
        {
            if (oldSize.Width < Size.Width || oldSize.Height < Size.Height)
            {
                if (showBitmap != null)
                {
                    showBitmap.Dispose();
                }
                if (Size.Width != 0 & Size.Height != 0)
                {
                    showBitmap = new Bitmap(Size.Width, Size.Height);
                    redrawShowBitmap();
                    if (working > 0)
                    {
                        Refresh();
                    }
                }
                else
                {
                    showBitmap = null;
                }
            }
            oldSize = Size;
        }
    }
}
