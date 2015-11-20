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
            Global.図形一覧.OnChangedData += m_DataManager_OnChangedData;

            Application.Run(m_MainForm);
        }

        private void m_DataManager_OnChangedData()
        {
            m_MainForm.UI更新();
        }

        private MainForm m_MainForm = new MainForm();
    }
}
