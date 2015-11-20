using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 面積管理システム.Model;

namespace 面積管理システム.View.Commands
{
    public enum 面積管理システムCommandType
    {
        Add,
        Delete,
    }

    public static class CommandManager
    {
        public static bool CanExecute(面積管理システムCommandType cmdType)
        {
            return GetCommand(cmdType).CanExecute;
        }

        public static bool Execute(面積管理システムCommandType cmdType)
        {
            ICommand command = GetCommand(cmdType);
            if (command.CanExecute)
                return command.Execute();

            return false;
        }

        private static ICommand GetCommand(面積管理システムCommandType cmdType)
        {
            switch (cmdType)
            {
                case 面積管理システムCommandType.Add:
                    return new AddCommand();
                case 面積管理システムCommandType.Delete:
                    return new DeleteCommand();
                default:
                    throw new NotImplementedException();
            }

        }
    }
}
