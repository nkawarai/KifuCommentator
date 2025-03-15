namespace KifuCommentator.Koma.Impl
{
    /// <summary>
    /// 玉将クラス
    /// </summary>
    public class Gyoku : KomaBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Gyoku(int column, int row, bool isSentegoma) : base(column, row, isSentegoma)
        {
            Kind = KomaKinds.Gyoku;
            DisplayCharacter = "玉";
            DisplayOrder = 0;
            IsNarigoma = false;
        }
    }
}
