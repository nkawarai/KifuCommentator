﻿namespace KifuCommentator.Koma.Impl
{
    using DomainShogi.Koma;

    /// <summary>
    /// 香車クラス
    /// </summary>
    internal class Kyousha : KomaBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Kyousha(int column, int row, bool isSentegoma, bool isNarigoma) : base (column, row, isSentegoma)
        {
            Kind = KomaKinds.Kyou;
            DisplayCharacter = "香";
            NariDisplayCharacter = "杏";
            DisplayOrder = 60;
            IsNarigoma = isNarigoma;
        }
    }
}
