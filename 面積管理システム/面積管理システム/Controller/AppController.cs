using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 面積管理システム.View;

namespace 面積管理システム.Controller
{
    public class AppController
    {
        public static void Run(string[] args)
        {
            Application.Run(new Form1());
        }
    }
}
