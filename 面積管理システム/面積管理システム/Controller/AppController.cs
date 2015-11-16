using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 面積管理システム.Model;
using 面積管理システム.View;

namespace 面積管理システム.Controller
{
    public class AppController
    {
        public void Run(string[] args)
        {
            Global.DataManager.OnChangedData += m_DataManager_OnChangedData;

            Application.Run(m_MainForm);
        }

        private void m_DataManager_OnChangedData()
        {
            m_MainForm.UI更新();
        }

        private Form1 m_MainForm = new Form1();
    }
}
