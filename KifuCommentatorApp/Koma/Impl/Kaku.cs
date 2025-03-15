namespace KifuCommentator.Koma.Impl
{
    /// <summary>
    /// 角行クラス
    /// </summary>
    internal class Kaku : KomaBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Kaku(int column, int row, bool isSentegoma, bool isNarigoma) : base(column, row, isSentegoma)
        {
            Kind = KomaKinds.Kaku;
            DisplayCharacter = "角";
            NariDisplayCharacter = "馬";
            DisplayOrder = 20;
            IsNarigoma = isNarigoma;
        }
    }
}
