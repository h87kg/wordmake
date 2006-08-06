using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WordMake
{
    public sealed class GB2312 
    {
        private GB2312()
        { }
        /// <summary>
        /// 获取所有GB2312代码
        /// </summary>
        /// <param name="stream">代码将写入</param>
        public static void GetAllChars(Stream stream)
        {
            GetChars(stream, 1, 94);
        }
        /// <summary>
        /// 获取GB2312代码的一级简码；第一级汉字是常用汉字，计 3755 个，置于 16～55 区，按汉语拼音字母／笔形顺序排列。
        /// </summary>
        /// <param name="stream">代码将写入</param>
        public static void GetStairChars(Stream stream)
        {
            GetChars(stream, 16, 1,3755);
        }
        /// <summary>
        /// 获取GB2312代码的二级简码；第二级汉字是次常用汉字，计 3008 个，置于 56～87 区，按部首／笔画顺序排列。
        /// </summary>
        /// <param name="stream">代码将写入</param>
        public static void GetSecondaryChars(Stream stream)
        {
            GetChars(stream, 56, 87);
        }
        /// <summary>
        /// 获取指定区的GB2312代码
        /// </summary>
        /// <param name="stream">指定区的GB2312代码将写入（已UTF8编码）</param>
        /// <param name="st">开始区号</param>
        /// <param name="end">结束区号</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static void GetChars(Stream stream, int st, int end)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            if (st <= 0 || st > 94)
            {
                throw new ArgumentOutOfRangeException("st","开始区号应大于或等于0或小于94");
            }
            if (end >95||end<=st)
            {
                throw new ArgumentOutOfRangeException("end","结束区号应大于开始区号并小于96");
            }
            MemoryStream ms = new MemoryStream((end-st)*94*2);
            for (byte q = (byte)(0xa0 + st); q < 0xa0 + end; q++)
            {
                for (byte w = 0xa0 + 1; w <= 94 + 0xa0; w++)
                {
                    ms.WriteByte(q);
                    ms.WriteByte(w);
                }
            }
            GBtoUTF8(stream, ms);
            ms.Dispose();
        }
        /// <summary>
        /// 获取指定区位后指定字符数的GB2312代码
        /// </summary>
        /// <param name="stream">指定的GB2312代码将写入（已UTF8编码）</param>
        /// <param name="qh">指定区号</param>
        /// <param name="wh">指定位号</param>
        /// <param name="couont">指定字符数</param>
        public static void GetChars(Stream stream, byte qh, byte wh, int couont)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            if (qh <= 0 || qh > 94)
            {
                throw new ArgumentOutOfRangeException("qh");
            }
            if (wh <= 0 || wh > 94)
            {
                throw new ArgumentOutOfRangeException("wh");
            }
            MemoryStream ms = new MemoryStream(couont * 2);
            byte w = (byte)(0xa0 + wh);
            for (byte q = (byte)(0xa0 + qh); q <= 94 + 0xa0; q++)
            {
                for (; w <= 94 + 0xa0; w++)
                {
                    ms.WriteByte(q);
                    ms.WriteByte(w);
                    if ((--couont) == 0)
                    {
                        goto End;
                    }
                }
                w = 0xa0 + 1;
            }
            End:
            GBtoUTF8(stream, ms);
            ms.Dispose();
        }

        private static void GBtoUTF8(Stream utf8, Stream gb2312)
        {
            gb2312.Position = 0;
            StreamReader tr = new StreamReader(gb2312, Encoding.GetEncoding("gb2312"));
            StreamWriter sw = new StreamWriter(utf8, Encoding.UTF8);
            char [] bu = new char[128];
            int Readed = 0;
            while ((Readed=tr.Read(bu, 0, bu.Length)) != 0)
            {
                sw.Write(bu, 0, Readed);
            }
            sw.Flush();
        }
    }
}
