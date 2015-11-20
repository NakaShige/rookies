using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 面積管理システム.Model;

namespace 面積管理システム.View.Commands
{
    public interface ICommand
    {
        bool CanExecute { get; }
        bool Execute();
    }
}
