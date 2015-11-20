using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 面積管理システム.Model;

namespace 面積管理システム.View.Commands
{
    public enum CommandType
    {
        Add,
        Delete,
    }

    public static class CommandManager
    {
        public static bool CanExecute(CommandType cmdType)
        {
            return GetCommand(cmdType).CanExecute;
        }

        public static bool Execute(CommandType cmdType)
        {
            ICommand command = GetCommand(cmdType);
            if (command.CanExecute)
                return command.Execute();

            return false;
        }

        private static ICommand GetCommand(CommandType cmdType)
        {
            switch (cmdType)
            {
                case CommandType.Add:
                    return new AddCommand();
                case CommandType.Delete:
                    return new DeleteCommand();
                default:
                    throw new NotImplementedException();
            }

        }
    }
}
