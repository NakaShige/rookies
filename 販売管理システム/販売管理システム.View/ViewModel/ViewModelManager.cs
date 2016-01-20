using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 販売管理システム.View.ViewModel
{
    public class ViewModelManager
    {
        public MainFormVM GetMainFormVM()
        {
            return null;
        }

        public static ViewModelManager getInstance()
        {
            if (m_Instance == null)
                m_Instance = new ViewModelManager();

            return m_Instance;
        }
        private static ViewModelManager m_Instance = null;
    }
}
