using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WordMake.CharacterSet
{
    public sealed class  ASCII
    {
        private ASCII()
        { 
        }
        /// <summary>
        /// 获取所有ASCII代码
        /// </summary>
        /// <param name="stream">代码将写入</param>
        public static void GetAllChars(Stream stream)
        {
            byte[] buf = new byte[byte.MaxValue];
            for (int i = 0; i < byte.MaxValue; i++)
            {
                buf[i] = (byte)i;
            }
            stream.Write(buf,0,byte.MaxValue);
        }
    }
}
