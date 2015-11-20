using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 面積管理システム.Model;

namespace 面積管理システム.View.Commands
{
    public class AddCommand : ICommand
    {
        public bool CanExecute
        {
            get { return true; }
        }

        public bool Execute()
        {
            var dlg = new AddFigureDialog();
            var ret = dlg.ShowDialog();

            if (ret == DialogResult.OK)
            {
                var item = dlg.SelectFigureItem;
                if (item != null)
                {
                    Global.図形一覧.Add(item);
                }
            }

            return true;
        }
    }
}
