using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 面積管理システム.Model;

namespace 面積管理システム.View.Commands
{
    public class DeleteCommand : ICommand
    {
        public bool CanExecute
        {
            get
            {
                return Global.図形一覧.IsSelected;
            }
        }

        public bool Execute()
        {
            Global.図形一覧.Remove(Global.図形一覧.SelectedItem);

            return true;
        }
    }
}
