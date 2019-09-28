using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swfplayer
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            if (args.Length == 0)
            {
                //若沒有傳入參數則正常啟動
                Application.Run(new Form1());
            }
            else
            {
                //若有傳入參數進入自定義的啟動模式
                Application.Run(new Form1(args[0].ToString()));
            }

        }
    }
}
