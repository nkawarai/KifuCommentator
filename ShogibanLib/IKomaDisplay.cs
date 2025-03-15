namespace ShogibanLib
{
    /// <summary>
    /// 駒を表示するための要求インターフェイス
    /// </summary>
    public interface IKomaDisplay
    {
        /// <summary>
        /// 表示順
        /// </summary>
        int DisplayOrder { get; }

        /// <summary>
        /// 列情報(筋)
        /// </summary>
        int Column { get; }

        /// <summary>
        /// 行情報(段)
        /// </summary>
        int Row { get; }

        /// <summary>
        /// 表示文字列
        /// </summary>
        string CurrentDisplayCharacter { get; }

        /// <summary>
        /// 太字表示
        /// </summary>
        bool IsBoldDisplay { get; }

        /// <summary>
        /// 先手の駒か
        /// </summary>
        bool IsSentegoma { get; }
    }
}
