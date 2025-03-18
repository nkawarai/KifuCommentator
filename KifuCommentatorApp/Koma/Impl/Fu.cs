namespace KifuCommentator.Koma.Impl
{
    using DomainShogi.Koma;

    /// <summary>
    /// 歩クラス
    /// </summary>
    internal class Fu : KomaBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Fu(int column, int row, bool isSentegoma, bool isNarigoma) : base(column, row, isSentegoma)
        {
            Kind = KomaKinds.Fu;
            DisplayCharacter = "歩";
            NariDisplayCharacter = "と";
            DisplayOrder = 70;
            IsNarigoma = isNarigoma;
        }
    }
}
