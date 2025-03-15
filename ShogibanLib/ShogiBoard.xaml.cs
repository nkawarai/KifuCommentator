using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ShogibanLib
{
    /// <summary>
    /// ShogiBoard.xaml の相互作用ロジック
    /// </summary>
    public partial class ShogiBoard : UserControl, INotifyPropertyChanged
    {
        #region ==== 依存関係プロパティ ====
        /// <summary>
        /// 盤上配置情報プロパティ
        /// </summary>
        public static readonly DependencyProperty KomaArrayProperty =
            DependencyProperty.Register(
                nameof(KomaArray),
                typeof(IEnumerable<IKomaDisplay>),
                typeof(ShogiBoard),
                new PropertyMetadata(null, KomaArrayPropertyChanged));
        public IEnumerable<IKomaDisplay> KomaArray
        {
            get => (IEnumerable<IKomaDisplay>)GetValue(KomaArrayProperty);
            set => SetValue(KomaArrayProperty, value);
        }
        static private void KomaArrayPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var view = obj as ShogiBoard;
            if (view == null) return;
            view.UpdateKomaPlace((IEnumerable<IKomaDisplay>)e.NewValue);
        }

        /// <summary>
        /// 先手持ち駒情報プロパティ
        /// </summary>
        public static readonly DependencyProperty SenteMochigomaArrayProperty =
            DependencyProperty.Register(
                nameof(SenteMochigomaArray),
                typeof(IEnumerable<IKomaDisplay>),
                typeof(ShogiBoard),
                new PropertyMetadata(null, SenteMochigomaArrayPropertyChanged));
        public IEnumerable<IKomaDisplay> SenteMochigomaArray
        {
            get => (IEnumerable<IKomaDisplay>)GetValue(SenteMochigomaArrayProperty);
            set => SetValue(SenteMochigomaArrayProperty, value);
        }
        static private void SenteMochigomaArrayPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var view = obj as ShogiBoard;
            if (view == null) return;

            //TODO 何か処理
        }

        /// <summary>
        /// 後手持ち駒情報プロパティ
        /// </summary>
        public static readonly DependencyProperty GoteMochigomaArrayProperty =
            DependencyProperty.Register(
                nameof(GoteMochigomaArray),
                typeof(IEnumerable<IKomaDisplay>),
                typeof(ShogiBoard),
                new PropertyMetadata(null, GoteMochigomaArrayPropertyChanged));
        public IEnumerable<IKomaDisplay> GoteMochigomaArray
        {
            get => (IEnumerable<IKomaDisplay>)GetValue(GoteMochigomaArrayProperty);
            set => SetValue(GoteMochigomaArrayProperty, value);
        }
        static private void GoteMochigomaArrayPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var view = obj as ShogiBoard;
            if (view == null) return;

            //TODO 何か処理
        }
        #endregion

        #region ==== 1段目 ====
        /// <summary>
        /// 11
        /// </summary>
        private IKomaDisplay? _koma11;
        public IKomaDisplay? Koma11
        {
            get => _koma11;
            set
            {
                if (_koma11 == value) return;
                _koma11 = value;
                OnPropertyChanged(nameof(Koma11));
            }
        }

        /// <summary>
        /// 21
        /// </summary>
        private IKomaDisplay? _koma21;
        public IKomaDisplay? Koma21
        {
            get => _koma21;
            set
            {
                if (_koma21 == value) return;
                _koma21 = value;
                OnPropertyChanged(nameof(Koma21));
            }
        }

        /// <summary>
        /// 31
        /// </summary>
        private IKomaDisplay? _koma31;
        public IKomaDisplay? Koma31
        {
            get => _koma31;
            set
            {
                if (_koma31 == value) return;
                _koma31 = value;
                OnPropertyChanged(nameof(Koma31));
            }
        }

        /// <summary>
        /// 41
        /// </summary>
        private IKomaDisplay? _koma41;
        public IKomaDisplay? Koma41
        {
            get => _koma41;
            set
            {
                if (_koma41 == value) return;
                _koma41 = value;
                OnPropertyChanged(nameof(Koma41));
            }
        }

        /// <summary>
        /// 51
        /// </summary>
        private IKomaDisplay? _koma51;
        public IKomaDisplay? Koma51
        {
            get => _koma51;
            set
            {
                if (_koma51 == value) return;
                _koma51 = value;
                OnPropertyChanged(nameof(Koma51));
            }
        }

        /// <summary>
        /// 61
        /// </summary>
        private IKomaDisplay? _koma61;
        public IKomaDisplay? Koma61
        {
            get => _koma61;
            set
            {
                if (_koma61 == value) return;
                _koma61 = value;
                OnPropertyChanged(nameof(Koma61));
            }
        }

        /// <summary>
        /// 71
        /// </summary>
        private IKomaDisplay? _koma71;
        public IKomaDisplay? Koma71
        {
            get => _koma71;
            set
            {
                if (_koma71 == value) return;
                _koma71 = value;
                OnPropertyChanged(nameof(Koma71));
            }
        }

        /// <summary>
        /// 81
        /// </summary>
        private IKomaDisplay? _koma81;
        public IKomaDisplay? Koma81
        {
            get => _koma81;
            set
            {
                if (_koma81 == value) return;
                _koma81 = value;
                OnPropertyChanged(nameof(Koma81));
            }
        }

        /// <summary>
        /// 91
        /// </summary>
        private IKomaDisplay? _koma91;
        public IKomaDisplay? Koma91
        {
            get => _koma91;
            set
            {
                if (_koma91 == value) return;
                _koma91 = value;
                OnPropertyChanged(nameof(Koma91));
            }
        }
        #endregion

        #region ==== 2段目 ====
        /// <summary>
        /// 12
        /// </summary>
        private IKomaDisplay? _koma12;
        public IKomaDisplay? Koma12
        {
            get => _koma12;
            set
            {
                if (_koma12 == value) return;
                _koma12 = value;
                OnPropertyChanged(nameof(Koma12));
            }
        }

        /// <summary>
        /// 22
        /// </summary>
        private IKomaDisplay? _koma22;
        public IKomaDisplay? Koma22
        {
            get => _koma22;
            set
            {
                if (_koma22 == value) return;
                _koma22 = value;
                OnPropertyChanged(nameof(Koma22));
            }
        }

        /// <summary>
        /// 32
        /// </summary>
        private IKomaDisplay? _koma32;
        public IKomaDisplay? Koma32
        {
            get => _koma32;
            set
            {
                if (_koma32 == value) return;
                _koma32 = value;
                OnPropertyChanged(nameof(Koma32));
            }
        }

        /// <summary>
        /// 42
        /// </summary>
        private IKomaDisplay? _koma42;
        public IKomaDisplay? Koma42
        {
            get => _koma42;
            set
            {
                if (_koma42 == value) return;
                _koma42 = value;
                OnPropertyChanged(nameof(Koma42));
            }
        }

        /// <summary>
        /// 52
        /// </summary>
        private IKomaDisplay? _koma52;
        public IKomaDisplay? Koma52
        {
            get => _koma52;
            set
            {
                if (_koma52 == value) return;
                _koma52 = value;
                OnPropertyChanged(nameof(Koma52));
            }
        }

        /// <summary>
        /// 62
        /// </summary>
        private IKomaDisplay? _koma62;
        public IKomaDisplay? Koma62
        {
            get => _koma62;
            set
            {
                if (_koma62 == value) return;
                _koma62 = value;
                OnPropertyChanged(nameof(Koma62));
            }
        }

        /// <summary>
        /// 72
        /// </summary>
        private IKomaDisplay? _koma72;
        public IKomaDisplay? Koma72
        {
            get => _koma72;
            set
            {
                if (_koma72 == value) return;
                _koma72 = value;
                OnPropertyChanged(nameof(Koma72));
            }
        }

        /// <summary>
        /// 82
        /// </summary>
        private IKomaDisplay? _koma82;
        public IKomaDisplay? Koma82
        {
            get => _koma82;
            set
            {
                if (_koma82 == value) return;
                _koma82 = value;
                OnPropertyChanged(nameof(Koma82));
            }
        }

        /// <summary>
        /// 92
        /// </summary>
        private IKomaDisplay? _koma92;
        public IKomaDisplay? Koma92
        {
            get => _koma92;
            set
            {
                if (_koma92 == value) return;
                _koma92 = value;
                OnPropertyChanged(nameof(Koma92));
            }
        }
        #endregion

        #region ==== 3段目 ====
        /// <summary>
        /// 13
        /// </summary>
        private IKomaDisplay? _koma13;
        public IKomaDisplay? Koma13
        {
            get => _koma13;
            set
            {
                if (_koma13 == value) return;
                _koma13 = value;
                OnPropertyChanged(nameof(Koma13));
            }
        }

        /// <summary>
        /// 23
        /// </summary>
        private IKomaDisplay? _koma23;
        public IKomaDisplay? Koma23
        {
            get => _koma23;
            set
            {
                if (_koma23 == value) return;
                _koma23 = value;
                OnPropertyChanged(nameof(Koma23));
            }
        }

        /// <summary>
        /// 32
        /// </summary>
        private IKomaDisplay? _koma33;
        public IKomaDisplay? Koma33
        {
            get => _koma33;
            set
            {
                if (_koma33 == value) return;
                _koma33 = value;
                OnPropertyChanged(nameof(Koma33));
            }
        }

        /// <summary>
        /// 43
        /// </summary>
        private IKomaDisplay? _koma43;
        public IKomaDisplay? Koma43
        {
            get => _koma43;
            set
            {
                if (_koma43 == value) return;
                _koma43 = value;
                OnPropertyChanged(nameof(Koma43));
            }
        }

        /// <summary>
        /// 53
        /// </summary>
        private IKomaDisplay? _koma53;
        public IKomaDisplay? Koma53
        {
            get => _koma53;
            set
            {
                if (_koma53 == value) return;
                _koma53 = value;
                OnPropertyChanged(nameof(Koma53));
            }
        }

        /// <summary>
        /// 62
        /// </summary>
        private IKomaDisplay? _koma63;
        public IKomaDisplay? Koma63
        {
            get => _koma63;
            set
            {
                if (_koma63 == value) return;
                _koma63 = value;
                OnPropertyChanged(nameof(Koma63));
            }
        }

        /// <summary>
        /// 73
        /// </summary>
        private IKomaDisplay? _koma73;
        public IKomaDisplay? Koma73
        {
            get => _koma73;
            set
            {
                if (_koma73 == value) return;
                _koma73 = value;
                OnPropertyChanged(nameof(Koma73));
            }
        }

        /// <summary>
        /// 83
        /// </summary>
        private IKomaDisplay? _koma83;
        public IKomaDisplay? Koma83
        {
            get => _koma83;
            set
            {
                if (_koma83 == value) return;
                _koma83 = value;
                OnPropertyChanged(nameof(Koma83));
            }
        }

        /// <summary>
        /// 93
        /// </summary>
        private IKomaDisplay? _koma93;
        public IKomaDisplay? Koma93
        {
            get => _koma93;
            set
            {
                if (_koma93 == value) return;
                _koma93 = value;
                OnPropertyChanged(nameof(Koma93));
            }
        }
        #endregion

        #region ==== 4段目 ====
        /// <summary>
        /// 14
        /// </summary>
        private IKomaDisplay? _koma14;
        public IKomaDisplay? Koma14
        {
            get => _koma14;
            set
            {
                if (_koma14 == value) return;
                _koma14 = value;
                OnPropertyChanged(nameof(Koma14));
            }
        }

        /// <summary>
        /// 24
        /// </summary>
        private IKomaDisplay? _koma24;
        public IKomaDisplay? Koma24
        {
            get => _koma24;
            set
            {
                if (_koma24 == value) return;
                _koma24 = value;
                OnPropertyChanged(nameof(Koma24));
            }
        }

        /// <summary>
        /// 34
        /// </summary>
        private IKomaDisplay? _koma34;
        public IKomaDisplay? Koma34
        {
            get => _koma34;
            set
            {
                if (_koma34 == value) return;
                _koma34 = value;
                OnPropertyChanged(nameof(Koma34));
            }
        }

        /// <summary>
        /// 44
        /// </summary>
        private IKomaDisplay? _koma44;
        public IKomaDisplay? Koma44
        {
            get => _koma44;
            set
            {
                if (_koma44 == value) return;
                _koma44 = value;
                OnPropertyChanged(nameof(Koma44));
            }
        }

        /// <summary>
        /// 54
        /// </summary>
        private IKomaDisplay? _koma54;
        public IKomaDisplay? Koma54
        {
            get => _koma54;
            set
            {
                if (_koma54 == value) return;
                _koma54 = value;
                OnPropertyChanged(nameof(Koma54));
            }
        }

        /// <summary>
        /// 64
        /// </summary>
        private IKomaDisplay? _koma64;
        public IKomaDisplay? Koma64
        {
            get => _koma64;
            set
            {
                if (_koma64 == value) return;
                _koma64 = value;
                OnPropertyChanged(nameof(Koma64));
            }
        }

        /// <summary>
        /// 74
        /// </summary>
        private IKomaDisplay? _koma74;
        public IKomaDisplay? Koma74
        {
            get => _koma74;
            set
            {
                if (_koma74 == value) return;
                _koma74 = value;
                OnPropertyChanged(nameof(Koma74));
            }
        }

        /// <summary>
        /// 84
        /// </summary>
        private IKomaDisplay? _koma84;
        public IKomaDisplay? Koma84
        {
            get => _koma84;
            set
            {
                if (_koma84 == value) return;
                _koma84 = value;
                OnPropertyChanged(nameof(Koma84));
            }
        }

        /// <summary>
        /// 94
        /// </summary>
        private IKomaDisplay? _koma94;
        public IKomaDisplay? Koma94
        {
            get => _koma94;
            set
            {
                if (_koma94 == value) return;
                _koma94 = value;
                OnPropertyChanged(nameof(Koma94));
            }
        }
        #endregion

        #region ==== 5段目 ====
        /// <summary>
        /// 15
        /// </summary>
        private IKomaDisplay? _koma15;
        public IKomaDisplay? Koma15
        {
            get => _koma15;
            set
            {
                if (_koma15 == value) return;
                _koma15 = value;
                OnPropertyChanged(nameof(Koma15));
            }
        }

        /// <summary>
        /// 25
        /// </summary>
        private IKomaDisplay? _koma25;
        public IKomaDisplay? Koma25
        {
            get => _koma25;
            set
            {
                if (_koma25 == value) return;
                _koma25 = value;
                OnPropertyChanged(nameof(Koma25));
            }
        }

        /// <summary>
        /// 35
        /// </summary>
        private IKomaDisplay? _koma35;
        public IKomaDisplay? Koma35
        {
            get => _koma35;
            set
            {
                if (_koma35 == value) return;
                _koma35 = value;
                OnPropertyChanged(nameof(Koma35));
            }
        }

        /// <summary>
        /// 45
        /// </summary>
        private IKomaDisplay? _koma45;
        public IKomaDisplay? Koma45
        {
            get => _koma45;
            set
            {
                if (_koma45 == value) return;
                _koma45 = value;
                OnPropertyChanged(nameof(Koma45));
            }
        }

        /// <summary>
        /// 55
        /// </summary>
        private IKomaDisplay? _koma55;
        public IKomaDisplay? Koma55
        {
            get => _koma55;
            set
            {
                if (_koma55 == value) return;
                _koma55 = value;
                OnPropertyChanged(nameof(Koma55));
            }
        }

        /// <summary>
        /// 65
        /// </summary>
        private IKomaDisplay? _koma65;
        public IKomaDisplay? Koma65
        {
            get => _koma65;
            set
            {
                if (_koma65 == value) return;
                _koma65 = value;
                OnPropertyChanged(nameof(Koma65));
            }
        }

        /// <summary>
        /// 75
        /// </summary>
        private IKomaDisplay? _koma75;
        public IKomaDisplay? Koma75
        {
            get => _koma75;
            set
            {
                if (_koma75 == value) return;
                _koma75 = value;
                OnPropertyChanged(nameof(Koma75));
            }
        }

        /// <summary>
        /// 85
        /// </summary>
        private IKomaDisplay? _koma85;
        public IKomaDisplay? Koma85
        {
            get => _koma85;
            set
            {
                if (_koma85 == value) return;
                _koma85 = value;
                OnPropertyChanged(nameof(Koma85));
            }
        }

        /// <summary>
        /// 95
        /// </summary>
        private IKomaDisplay? _koma95;
        public IKomaDisplay? Koma95
        {
            get => _koma95;
            set
            {
                if (_koma95 == value) return;
                _koma95 = value;
                OnPropertyChanged(nameof(Koma95));
            }
        }
        #endregion

        #region ==== 6段目 ====
        /// <summary>
        /// 16
        /// </summary>
        private IKomaDisplay? _koma16;
        public IKomaDisplay? Koma16
        {
            get => _koma16;
            set
            {
                if (_koma16 == value) return;
                _koma16 = value;
                OnPropertyChanged(nameof(Koma16));
            }
        }

        /// <summary>
        /// 26
        /// </summary>
        private IKomaDisplay? _koma26;
        public IKomaDisplay? Koma26
        {
            get => _koma26;
            set
            {
                if (_koma26 == value) return;
                _koma26 = value;
                OnPropertyChanged(nameof(Koma26));
            }
        }

        /// <summary>
        /// 36
        /// </summary>
        private IKomaDisplay? _koma36;
        public IKomaDisplay? Koma36
        {
            get => _koma36;
            set
            {
                if (_koma36 == value) return;
                _koma36 = value;
                OnPropertyChanged(nameof(Koma36));
            }
        }

        /// <summary>
        /// 46
        /// </summary>
        private IKomaDisplay? _koma46;
        public IKomaDisplay? Koma46
        {
            get => _koma46;
            set
            {
                if (_koma46 == value) return;
                _koma46 = value;
                OnPropertyChanged(nameof(Koma46));
            }
        }

        /// <summary>
        /// 56
        /// </summary>
        private IKomaDisplay? _koma56;
        public IKomaDisplay? Koma56
        {
            get => _koma56;
            set
            {
                if (_koma56 == value) return;
                _koma56 = value;
                OnPropertyChanged(nameof(Koma56));
            }
        }

        /// <summary>
        /// 66
        /// </summary>
        private IKomaDisplay? _koma66;
        public IKomaDisplay? Koma66
        {
            get => _koma66;
            set
            {
                if (_koma66 == value) return;
                _koma66 = value;
                OnPropertyChanged(nameof(Koma66));
            }
        }

        /// <summary>
        /// 76
        /// </summary>
        private IKomaDisplay? _koma76;
        public IKomaDisplay? Koma76
        {
            get => _koma76;
            set
            {
                if (_koma76 == value) return;
                _koma76 = value;
                OnPropertyChanged(nameof(Koma76));
            }
        }

        /// <summary>
        /// 86
        /// </summary>
        private IKomaDisplay? _koma86;
        public IKomaDisplay? Koma86
        {
            get => _koma86;
            set
            {
                if (_koma86 == value) return;
                _koma86 = value;
                OnPropertyChanged(nameof(Koma86));
            }
        }

        /// <summary>
        /// 96
        /// </summary>
        private IKomaDisplay? _koma96;
        public IKomaDisplay? Koma96
        {
            get => _koma96;
            set
            {
                if (_koma96 == value) return;
                _koma96 = value;
                OnPropertyChanged(nameof(Koma96));
            }
        }
        #endregion

        #region ==== 7段目 ====
        /// <summary>
        /// 17
        /// </summary>
        private IKomaDisplay? _koma17;
        public IKomaDisplay? Koma17
        {
            get => _koma17;
            set
            {
                if (_koma17 == value) return;
                _koma17 = value;
                OnPropertyChanged(nameof(Koma17));
            }
        }

        /// <summary>
        /// 27
        /// </summary>
        private IKomaDisplay? _koma27;
        public IKomaDisplay? Koma27
        {
            get => _koma27;
            set
            {
                if (_koma27 == value) return;
                _koma27 = value;
                OnPropertyChanged(nameof(Koma27));
            }
        }

        /// <summary>
        /// 37
        /// </summary>
        private IKomaDisplay? _koma37;
        public IKomaDisplay? Koma37
        {
            get => _koma37;
            set
            {
                if (_koma37 == value) return;
                _koma37 = value;
                OnPropertyChanged(nameof(Koma37));
            }
        }

        /// <summary>
        /// 47
        /// </summary>
        private IKomaDisplay? _koma47;
        public IKomaDisplay? Koma47
        {
            get => _koma47;
            set
            {
                if (_koma47 == value) return;
                _koma47 = value;
                OnPropertyChanged(nameof(Koma47));
            }
        }

        /// <summary>
        /// 57
        /// </summary>
        private IKomaDisplay? _koma57;
        public IKomaDisplay? Koma57
        {
            get => _koma57;
            set
            {
                if (_koma57 == value) return;
                _koma57 = value;
                OnPropertyChanged(nameof(Koma57));
            }
        }

        /// <summary>
        /// 67
        /// </summary>
        private IKomaDisplay? _koma67;
        public IKomaDisplay? Koma67
        {
            get => _koma67;
            set
            {
                if (_koma67 == value) return;
                _koma67 = value;
                OnPropertyChanged(nameof(Koma67));
            }
        }

        /// <summary>
        /// 77
        /// </summary>
        private IKomaDisplay? _koma77;
        public IKomaDisplay? Koma77
        {
            get => _koma77;
            set
            {
                if (_koma77 == value) return;
                _koma77 = value;
                OnPropertyChanged(nameof(Koma77));
            }
        }

        /// <summary>
        /// 87
        /// </summary>
        private IKomaDisplay? _koma87;
        public IKomaDisplay? Koma87
        {
            get => _koma87;
            set
            {
                if (_koma87 == value) return;
                _koma87 = value;
                OnPropertyChanged(nameof(Koma87));
            }
        }

        /// <summary>
        /// 97
        /// </summary>
        private IKomaDisplay? _koma97;
        public IKomaDisplay? Koma97
        {
            get => _koma97;
            set
            {
                if (_koma97 == value) return;
                _koma97 = value;
                OnPropertyChanged(nameof(Koma97));
            }
        }
        #endregion

        #region ==== 8段目 ====
        /// <summary>
        /// 18
        /// </summary>
        private IKomaDisplay? _koma18;
        public IKomaDisplay? Koma18
        {
            get => _koma18;
            set
            {
                if (_koma18 == value) return;
                _koma18 = value;
                OnPropertyChanged(nameof(Koma18));
            }
        }

        /// <summary>
        /// 28
        /// </summary>
        private IKomaDisplay? _koma28;
        public IKomaDisplay? Koma28
        {
            get => _koma28;
            set
            {
                if (_koma28 == value) return;
                _koma28 = value;
                OnPropertyChanged(nameof(Koma28));
            }
        }

        /// <summary>
        /// 38
        /// </summary>
        private IKomaDisplay? _koma38;
        public IKomaDisplay? Koma38
        {
            get => _koma38;
            set
            {
                if (_koma38 == value) return;
                _koma38 = value;
                OnPropertyChanged(nameof(Koma38));
            }
        }

        /// <summary>
        /// 48
        /// </summary>
        private IKomaDisplay? _koma48;
        public IKomaDisplay? Koma48
        {
            get => _koma48;
            set
            {
                if (_koma48 == value) return;
                _koma48 = value;
                OnPropertyChanged(nameof(Koma48));
            }
        }

        /// <summary>
        /// 58
        /// </summary>
        private IKomaDisplay? _koma58;
        public IKomaDisplay? Koma58
        {
            get => _koma58;
            set
            {
                if (_koma58 == value) return;
                _koma58 = value;
                OnPropertyChanged(nameof(Koma58));
            }
        }

        /// <summary>
        /// 68
        /// </summary>
        private IKomaDisplay? _koma68;
        public IKomaDisplay? Koma68
        {
            get => _koma68;
            set
            {
                if (_koma68 == value) return;
                _koma68 = value;
                OnPropertyChanged(nameof(Koma68));
            }
        }

        /// <summary>
        /// 78
        /// </summary>
        private IKomaDisplay? _koma78;
        public IKomaDisplay? Koma78
        {
            get => _koma78;
            set
            {
                if (_koma78 == value) return;
                _koma78 = value;
                OnPropertyChanged(nameof(Koma78));
            }
        }

        /// <summary>
        /// 88
        /// </summary>
        private IKomaDisplay? _koma88;
        public IKomaDisplay? Koma88
        {
            get => _koma88;
            set
            {
                if (_koma88 == value) return;
                _koma88 = value;
                OnPropertyChanged(nameof(Koma88));
            }
        }

        /// <summary>
        /// 98
        /// </summary>
        private IKomaDisplay? _koma98;
        public IKomaDisplay? Koma98
        {
            get => _koma98;
            set
            {
                if (_koma98 == value) return;
                _koma98 = value;
                OnPropertyChanged(nameof(Koma98));
            }
        }
        #endregion

        #region ==== 9段目 ====
        /// <summary>
        /// 19
        /// </summary>
        private IKomaDisplay? _koma19;
        public IKomaDisplay? Koma19
        {
            get => _koma19;
            set
            {
                if (_koma19 == value) return;
                _koma19 = value;
                OnPropertyChanged(nameof(Koma19));
            }
        }

        /// <summary>
        /// 29
        /// </summary>
        private IKomaDisplay? _koma29;
        public IKomaDisplay? Koma29
        {
            get => _koma29;
            set
            {
                if (_koma29 == value) return;
                _koma29 = value;
                OnPropertyChanged(nameof(Koma29));
            }
        }

        /// <summary>
        /// 39
        /// </summary>
        private IKomaDisplay? _koma39;
        public IKomaDisplay? Koma39
        {
            get => _koma39;
            set
            {
                if (_koma39 == value) return;
                _koma39 = value;
                OnPropertyChanged(nameof(Koma39));
            }
        }

        /// <summary>
        /// 49
        /// </summary>
        private IKomaDisplay? _koma49;
        public IKomaDisplay? Koma49
        {
            get => _koma49;
            set
            {
                if (_koma49 == value) return;
                _koma49 = value;
                OnPropertyChanged(nameof(Koma49));
            }
        }

        /// <summary>
        /// 59
        /// </summary>
        private IKomaDisplay? _koma59;
        public IKomaDisplay? Koma59
        {
            get => _koma59;
            set
            {
                if (_koma59 == value) return;
                _koma59 = value;
                OnPropertyChanged(nameof(Koma59));
            }
        }

        /// <summary>
        /// 69
        /// </summary>
        private IKomaDisplay? _koma69;
        public IKomaDisplay? Koma69
        {
            get => _koma69;
            set
            {
                if (_koma69 == value) return;
                _koma69 = value;
                OnPropertyChanged(nameof(Koma69));
            }
        }

        /// <summary>
        /// 79
        /// </summary>
        private IKomaDisplay? _koma79;
        public IKomaDisplay? Koma79
        {
            get => _koma79;
            set
            {
                if (_koma79 == value) return;
                _koma79 = value;
                OnPropertyChanged(nameof(Koma79));
            }
        }

        /// <summary>
        /// 89
        /// </summary>
        private IKomaDisplay? _koma89;
        public IKomaDisplay? Koma89
        {
            get => _koma89;
            set
            {
                if (_koma89 == value) return;
                _koma89 = value;
                OnPropertyChanged(nameof(Koma89));
            }
        }

        /// <summary>
        /// 99
        /// </summary>
        private IKomaDisplay? _koma99;
        public IKomaDisplay? Koma99
        {
            get => _koma99;
            set
            {
                if (_koma99 == value) return;
                _koma99 = value;
                OnPropertyChanged(nameof(Koma99));
            }
        }
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ShogiBoard()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void UpdateKomaPlace(IEnumerable<IKomaDisplay> komaDisplays)
        {
            //HACK:アホみたいなコードだが、とりあえず動くことを優先させる
            Koma11 = komaDisplays.Where(x => x.Column == 1 && x.Row == 1)?.FirstOrDefault();
            Koma21 = komaDisplays.Where(x => x.Column == 2 && x.Row == 1)?.FirstOrDefault();
            Koma31 = komaDisplays.Where(x => x.Column == 3 && x.Row == 1)?.FirstOrDefault();
            Koma41 = komaDisplays.Where(x => x.Column == 4 && x.Row == 1)?.FirstOrDefault();
            Koma51 = komaDisplays.Where(x => x.Column == 5 && x.Row == 1)?.FirstOrDefault();
            Koma61 = komaDisplays.Where(x => x.Column == 6 && x.Row == 1)?.FirstOrDefault();
            Koma71 = komaDisplays.Where(x => x.Column == 7 && x.Row == 1)?.FirstOrDefault();
            Koma81 = komaDisplays.Where(x => x.Column == 8 && x.Row == 1)?.FirstOrDefault();
            Koma91 = komaDisplays.Where(x => x.Column == 9 && x.Row == 1)?.FirstOrDefault();

            Koma12 = komaDisplays.Where(x => x.Column == 1 && x.Row == 2)?.FirstOrDefault();
            Koma22 = komaDisplays.Where(x => x.Column == 2 && x.Row == 2)?.FirstOrDefault();
            Koma32 = komaDisplays.Where(x => x.Column == 3 && x.Row == 2)?.FirstOrDefault();
            Koma42 = komaDisplays.Where(x => x.Column == 4 && x.Row == 2)?.FirstOrDefault();
            Koma52 = komaDisplays.Where(x => x.Column == 5 && x.Row == 2)?.FirstOrDefault();
            Koma62 = komaDisplays.Where(x => x.Column == 6 && x.Row == 2)?.FirstOrDefault();
            Koma72 = komaDisplays.Where(x => x.Column == 7 && x.Row == 2)?.FirstOrDefault();
            Koma82 = komaDisplays.Where(x => x.Column == 8 && x.Row == 2)?.FirstOrDefault();
            Koma92 = komaDisplays.Where(x => x.Column == 9 && x.Row == 2)?.FirstOrDefault();

            Koma13 = komaDisplays.Where(x => x.Column == 1 && x.Row == 3)?.FirstOrDefault();
            Koma23 = komaDisplays.Where(x => x.Column == 2 && x.Row == 3)?.FirstOrDefault();
            Koma33 = komaDisplays.Where(x => x.Column == 3 && x.Row == 3)?.FirstOrDefault();
            Koma43 = komaDisplays.Where(x => x.Column == 4 && x.Row == 3)?.FirstOrDefault();
            Koma53 = komaDisplays.Where(x => x.Column == 5 && x.Row == 3)?.FirstOrDefault();
            Koma63 = komaDisplays.Where(x => x.Column == 6 && x.Row == 3)?.FirstOrDefault();
            Koma73 = komaDisplays.Where(x => x.Column == 7 && x.Row == 3)?.FirstOrDefault();
            Koma83 = komaDisplays.Where(x => x.Column == 8 && x.Row == 3)?.FirstOrDefault();
            Koma93 = komaDisplays.Where(x => x.Column == 9 && x.Row == 3)?.FirstOrDefault();

            Koma14 = komaDisplays.Where(x => x.Column == 1 && x.Row == 4)?.FirstOrDefault();
            Koma24 = komaDisplays.Where(x => x.Column == 2 && x.Row == 4)?.FirstOrDefault();
            Koma34 = komaDisplays.Where(x => x.Column == 3 && x.Row == 4)?.FirstOrDefault();
            Koma44 = komaDisplays.Where(x => x.Column == 4 && x.Row == 4)?.FirstOrDefault();
            Koma54 = komaDisplays.Where(x => x.Column == 5 && x.Row == 4)?.FirstOrDefault();
            Koma64 = komaDisplays.Where(x => x.Column == 6 && x.Row == 4)?.FirstOrDefault();
            Koma74 = komaDisplays.Where(x => x.Column == 7 && x.Row == 4)?.FirstOrDefault();
            Koma84 = komaDisplays.Where(x => x.Column == 8 && x.Row == 4)?.FirstOrDefault();
            Koma94 = komaDisplays.Where(x => x.Column == 9 && x.Row == 4)?.FirstOrDefault();

            Koma15 = komaDisplays.Where(x => x.Column == 1 && x.Row == 5)?.FirstOrDefault();
            Koma25 = komaDisplays.Where(x => x.Column == 2 && x.Row == 5)?.FirstOrDefault();
            Koma35 = komaDisplays.Where(x => x.Column == 3 && x.Row == 5)?.FirstOrDefault();
            Koma45 = komaDisplays.Where(x => x.Column == 4 && x.Row == 5)?.FirstOrDefault();
            Koma55 = komaDisplays.Where(x => x.Column == 5 && x.Row == 5)?.FirstOrDefault();
            Koma65 = komaDisplays.Where(x => x.Column == 6 && x.Row == 5)?.FirstOrDefault();
            Koma75 = komaDisplays.Where(x => x.Column == 7 && x.Row == 5)?.FirstOrDefault();
            Koma85 = komaDisplays.Where(x => x.Column == 8 && x.Row == 5)?.FirstOrDefault();
            Koma95 = komaDisplays.Where(x => x.Column == 9 && x.Row == 5)?.FirstOrDefault();

            Koma16 = komaDisplays.Where(x => x.Column == 1 && x.Row == 6)?.FirstOrDefault();
            Koma26 = komaDisplays.Where(x => x.Column == 2 && x.Row == 6)?.FirstOrDefault();
            Koma36 = komaDisplays.Where(x => x.Column == 3 && x.Row == 6)?.FirstOrDefault();
            Koma46 = komaDisplays.Where(x => x.Column == 4 && x.Row == 6)?.FirstOrDefault();
            Koma56 = komaDisplays.Where(x => x.Column == 5 && x.Row == 6)?.FirstOrDefault();
            Koma66 = komaDisplays.Where(x => x.Column == 6 && x.Row == 6)?.FirstOrDefault();
            Koma76 = komaDisplays.Where(x => x.Column == 7 && x.Row == 6)?.FirstOrDefault();
            Koma86 = komaDisplays.Where(x => x.Column == 8 && x.Row == 6)?.FirstOrDefault();
            Koma96 = komaDisplays.Where(x => x.Column == 9 && x.Row == 6)?.FirstOrDefault();

            Koma17 = komaDisplays.Where(x => x.Column == 1 && x.Row == 7)?.FirstOrDefault();
            Koma27 = komaDisplays.Where(x => x.Column == 2 && x.Row == 7)?.FirstOrDefault();
            Koma37 = komaDisplays.Where(x => x.Column == 3 && x.Row == 7)?.FirstOrDefault();
            Koma47 = komaDisplays.Where(x => x.Column == 4 && x.Row == 7)?.FirstOrDefault();
            Koma57 = komaDisplays.Where(x => x.Column == 5 && x.Row == 7)?.FirstOrDefault();
            Koma67 = komaDisplays.Where(x => x.Column == 6 && x.Row == 7)?.FirstOrDefault();
            Koma77 = komaDisplays.Where(x => x.Column == 7 && x.Row == 7)?.FirstOrDefault();
            Koma87 = komaDisplays.Where(x => x.Column == 8 && x.Row == 7)?.FirstOrDefault();
            Koma97 = komaDisplays.Where(x => x.Column == 9 && x.Row == 7)?.FirstOrDefault();

            Koma18 = komaDisplays.Where(x => x.Column == 1 && x.Row == 8)?.FirstOrDefault();
            Koma28 = komaDisplays.Where(x => x.Column == 2 && x.Row == 8)?.FirstOrDefault();
            Koma38 = komaDisplays.Where(x => x.Column == 3 && x.Row == 8)?.FirstOrDefault();
            Koma48 = komaDisplays.Where(x => x.Column == 4 && x.Row == 8)?.FirstOrDefault();
            Koma58 = komaDisplays.Where(x => x.Column == 5 && x.Row == 8)?.FirstOrDefault();
            Koma68 = komaDisplays.Where(x => x.Column == 6 && x.Row == 8)?.FirstOrDefault();
            Koma78 = komaDisplays.Where(x => x.Column == 7 && x.Row == 8)?.FirstOrDefault();
            Koma88 = komaDisplays.Where(x => x.Column == 8 && x.Row == 8)?.FirstOrDefault();
            Koma98 = komaDisplays.Where(x => x.Column == 9 && x.Row == 8)?.FirstOrDefault();

            Koma19 = komaDisplays.Where(x => x.Column == 1 && x.Row == 9)?.FirstOrDefault();
            Koma29 = komaDisplays.Where(x => x.Column == 2 && x.Row == 9)?.FirstOrDefault();
            Koma39 = komaDisplays.Where(x => x.Column == 3 && x.Row == 9)?.FirstOrDefault();
            Koma49 = komaDisplays.Where(x => x.Column == 4 && x.Row == 9)?.FirstOrDefault();
            Koma59 = komaDisplays.Where(x => x.Column == 5 && x.Row == 9)?.FirstOrDefault();
            Koma69 = komaDisplays.Where(x => x.Column == 6 && x.Row == 9)?.FirstOrDefault();
            Koma79 = komaDisplays.Where(x => x.Column == 7 && x.Row == 9)?.FirstOrDefault();
            Koma89 = komaDisplays.Where(x => x.Column == 8 && x.Row == 9)?.FirstOrDefault();
            Koma99 = komaDisplays.Where(x => x.Column == 9 && x.Row == 9)?.FirstOrDefault();
        }

        #region ==== INotifyPropertyChanged ===
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
