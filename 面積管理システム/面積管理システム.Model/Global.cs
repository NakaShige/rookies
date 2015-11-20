using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 面積管理システム.Model.図形;

namespace 面積管理システム.Model
{
    public static class Global
    {
        public static 図形一覧 図形一覧
        {
            get
            {
                if (m_DataManager == null)
                    m_DataManager = new 図形一覧();

                return m_DataManager;
            }
        }

        private static 図形一覧 m_DataManager;
    }
}
