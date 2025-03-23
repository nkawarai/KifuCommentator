using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KifuCommentatorApp.Command
{
    public class LoadKifuFileCommand : ICommand
    {
        public bool CanExecute(object? _) => true;

        public void Execute(object? _)
        {
            //TODO 実装
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

    }
}
