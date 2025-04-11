namespace DomainShogi.Koma
{
    /// <summary>
    /// 盤上に配置された駒
    /// </summary>
    public interface IBanjoKoma : IKoma
    {
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
