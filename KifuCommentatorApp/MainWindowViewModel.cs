using System.ComponentModel;
using System.Collections.ObjectModel;
using KifuCommentator.Rule;
using KifuCommentatorApp.Koma;
using DomainShogi.Kifus;
using System.Windows.Input;

namespace KifuCommentatorApp
{
    using Command;

    /// <summary>
    /// MainWindow のViewModel
    /// </summary>
    public class MainWindowViewModel : INotifyPropertyChanged, IMainWindowViewModel
    {
        /// <summary>
        /// 棋譜ファイルを読み込むコマンド
        /// </summary>
        public ICommand LoadKifuFileCommand { get; }

        /// <summary>
        /// 盤上の駒
        /// </summary>
        private ObservableCollection<IShogiKoma>? _komasOnBoard;
        public ObservableCollection<IShogiKoma>? KomasOnBoard
        {
            get => _komasOnBoard;
            set
            {
                if (_komasOnBoard == value) return;
                _komasOnBoard = value;
                OnPropertyChanged(nameof(KomasOnBoard));
            }
        }

        /// <summary>
        /// 棋譜
        /// </summary>
        private IKifu? _kifu;
        public IKifu? Kifu
        {
            get => _kifu;
            set
            {
                if (_kifu == value) return;
                _kifu = value;
                OnPropertyChanged(nameof(Kifu));
            }
        }

        /// <summary>
        /// 棋譜を設定する
        /// </summary>
        /// <param name="kifu"></param>
        public void SetKifu(IKifu kifu)
        {
            Kifu = kifu;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindowViewModel()
        {
            //コマンド
            this.LoadKifuFileCommand = new LoadKifuFileCommand(this);

            //初期配置
            KomasOnBoard = new ObservableCollection<IShogiKoma>(InitialPlacement.InitialKomaPlaces());
        }

        #region ==== INotifyPropertyChanged ===
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion

    }
}
