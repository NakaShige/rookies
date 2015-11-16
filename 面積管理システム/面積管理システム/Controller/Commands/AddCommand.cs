using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面積管理システム.Controller.Commands
{
    public class AddCommandImplement : ICommandImplement
    {
        #region ICommandImplement メンバー

        public bool CanRun(object args)
        {
            return true;
        }

        #endregion
    }

    public class AddCommand : ICommand
    {
        #region ICommand メンバー

        public bool Run(object args)
        {
            return false;
        }

        #endregion
    }
}
