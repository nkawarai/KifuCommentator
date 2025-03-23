using System;
using System.Windows.Input;

namespace KifuCommentatorApp.Command
{
    /// <summary>
    /// アプリ終了コマンド
    /// </summary>
    public class AppExitCommand : ICommand
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
