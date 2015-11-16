using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面積管理システム.Model
{
    public static class Global
    {
        public static DataManager DataManager
        {
            get
            {
                if (m_DataManager == null)
                    m_DataManager = new DataManager();

                return m_DataManager;
            }
        }

        private static DataManager m_DataManager;
    }
}
