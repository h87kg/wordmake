using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WordMake.Forms;

namespace WordMake
{
    static class Program
    {
       public static  WordMakeForm WordMakeForm;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WordMakeForm = new Forms.WordMakeForm();
            Application.Run(WordMakeForm);
        }
    }
}