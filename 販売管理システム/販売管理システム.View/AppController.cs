using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 販売管理システム.View.Forms;

namespace 販売管理システム.View
{
    public static class AppController
    {
        public static void Run()
        {
            System.Windows.Forms.Application.Run(new MainForm());
        }
    }
}
