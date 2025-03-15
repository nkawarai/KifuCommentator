namespace KifuCommentator.Koma.Impl
{
    /// <summary>
    /// 金将クラス
    /// </summary>
    internal class Kin : KomaBase
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
