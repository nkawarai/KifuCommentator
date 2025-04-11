namespace DomainShogi.Koma.Impl
{
    /// <summary>
    /// 歩クラス
    /// </summary>
    internal class Fu : BanjoKomaBase
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
