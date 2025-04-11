namespace DomainShogi.Koma.Impl
{
    /// <summary>
    /// 金将クラス
    /// </summary>
    internal class Kin : BanjoKomaBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Kin(int column, int row, bool isSentegoma) : base (column, row, isSentegoma)
        {
            Kind = KomaKinds.Kin;
            DisplayCharacter = "金";
            DisplayOrder = 30;
            IsNarigoma = false;
        }
    }
}
