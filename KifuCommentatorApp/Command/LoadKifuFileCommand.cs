using DomainShogi.Kifus;
using Microsoft.Win32;
using System;
using System.Windows.Input;

namespace KifuCommentatorApp.Command
{
    public class LoadKifuFileCommand : ICommand
    {
        private IMainWindowViewModel _vm;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="mainWindowViewModel"></param>
        public LoadKifuFileCommand(IMainWindowViewModel mainWindowViewModel)
        {
            _vm = mainWindowViewModel;
        }

        public bool CanExecute(object? _) => true;

        public void Execute(object? _)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "棋譜ファイルの読み込み";
            dialog.Filter = "棋譜ファイル(*.kif)|*.kif";
            if (!dialog.ShowDialog() ?? false) return;

            //棋譜を読み込む
            _vm.SetKifu(KifuFile.LoadKifuFile(dialog.FileName));
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
