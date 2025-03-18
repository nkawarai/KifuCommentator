using KifuCommentatorApp.Koma;

namespace KifuCommentator.Koma.Impl
{
    using DomainShogi.Koma;

    abstract public class KomaBase : IShogiKoma
    {
        /// <summary>
        /// 駒種別
        /// </summary>
        public KomaKinds Kind { get; protected set; }

        /// <summary>
        /// 駒文字
        /// </summary>
        public string DisplayCharacter { get; protected set; }

        /// <summary>
        /// 成駒文字
        /// </summary>
        public string NariDisplayCharacter { get; protected set; }

        /// <summary>
        /// 表示順
        /// </summary>
        public int DisplayOrder { get; protected set; }

        /// <summary>
        /// 列番号
        /// </summary>
        public int Column { get; }

        /// <summary>
        /// 行番号
        /// </summary>
        public int Row { get; }

        /// <summary>
        /// 成駒か
        /// </summary>
        public bool IsNarigoma { get; protected set; }

        /// <summary>
        /// 先手の駒か
        /// </summary>
        public bool IsSentegoma { get; }

        /// <summary>
        /// 表示文字列
        /// </summary>
        public string CurrentDisplayCharacter
            => IsNarigoma ? NariDisplayCharacter : DisplayCharacter;

        /// <summary>
        /// 太字表示
        /// </summary>
        public bool IsBoldDisplay { get => false; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KomaBase(int column, int row, bool isSentegoma)
        {
            Column = column;
            Row = row;
            IsSentegoma = isSentegoma;
            DisplayCharacter = string.Empty;
            NariDisplayCharacter = string.Empty;
        }
    }
}
