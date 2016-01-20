using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 販売管理システム
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            販売管理システム.View.AppController.Run();
        }
    }
}
