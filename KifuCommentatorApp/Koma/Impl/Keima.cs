namespace KifuCommentator.Koma.Impl
{
    using DomainShogi.Koma;

    /// <summary>
    /// 桂馬クラス
    /// </summary>
    internal class Keima : KomaBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Keima(int column, int row, bool isSentegoma, bool isNarigoma) : base(column, row, isSentegoma)
        {
            Kind = KomaKinds.Kei;
            DisplayCharacter = "桂";
            NariDisplayCharacter = "圭";
            DisplayOrder = 50;
            IsNarigoma = isNarigoma;
        }
    }
}
