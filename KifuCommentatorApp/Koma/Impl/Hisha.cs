namespace KifuCommentator.Koma.Impl
{
    /// <summary>
    /// 飛車クラス
    /// </summary>
    internal class Hisha : KomaBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Hisha(int column, int row, bool isSentegoma, bool isNarigoma) : base (column, row, isSentegoma)
        {
            Kind = KomaKinds.Hisha;
            DisplayCharacter = "飛";
            NariDisplayCharacter = "龍";
            DisplayOrder = 10;
            IsNarigoma = isNarigoma;
        }
    }
}
