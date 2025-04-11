namespace DomainShogi.Koma.Impl
{
    /// <summary>
    /// 銀将クラス
    /// </summary>
    internal class Gin : BanjoKomaBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Gin(int column, int row, bool isSentegoma, bool isNarigoma) : base (column, row, isSentegoma)
        {
            Kind = KomaKinds.Gin;
            DisplayCharacter = "銀";
            NariDisplayCharacter = "全";
            DisplayOrder = 40;
            IsNarigoma = isNarigoma;
        }
    }
}
