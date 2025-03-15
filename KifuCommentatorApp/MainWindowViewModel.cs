using System.ComponentModel;
using System.Collections.ObjectModel;
using KifuCommentator.Koma;
using KifuCommentator.Rule;

namespace KifuCommentator
{
    /// <summary>
    /// MainWindow のViewModel
    /// </summary>
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// 盤上の駒
        /// </summary>
        private ObservableCollection<IKoma>? _komasOnBoard;
        public ObservableCollection<IKoma>? KomasOnBoard
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
        /// コンストラクタ
        /// </summary>
        public MainWindowViewModel()
        {
            //初期配置
            KomasOnBoard = new ObservableCollection<IKoma>(InitialPlacement.InitialKomaPlaces());
        }

        #region ==== INotifyPropertyChanged ===
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion

    }
}
