namespace KifuCommentator.Koma
{
    using Impl;

    /// <summary>
    /// 駒ファクトリ
    /// </summary>
    public class KomaFactory
    {
        /// <summary>
        /// "玉"オブジェクトを返す
        /// </summary>
        /// <returns></returns>
        static public IKoma CreateGyoku(int column, int row, bool isSentegoma)
        {
            return new Gyoku(column, row, isSentegoma);
        }

        /// <summary>
        /// "飛車"オブジェクトを返す
        /// </summary>
        static public IKoma CreateHisha(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Hisha(column, row, isSentegoma, isNarigoma);
        }

        /// <summary>
        /// "角"オブジェクトを返す
        /// </summary>
        static public IKoma CreateKaku(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Kaku(column, row, isSentegoma, isNarigoma);
        }

        /// <summary>
        /// "金"オブジェクトを返す
        /// </summary>
        static public IKoma CreateKin(int column, int row, bool isSentegoma)
        {
            return new Kin(column, row, isSentegoma);
        }

        /// <summary>
        /// "銀"オブジェクトを返す
        /// </summary>
        static public IKoma CreateGin(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Gin(column, row, isSentegoma, isNarigoma);
        }

        /// <summary>
        /// "桂馬"オブジェクトを返す
        /// </summary>
        static public IKoma CreateKeima(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Keima(column, row, isSentegoma, isNarigoma);
        }

        /// <summary>
        /// "香車"オブジェクトを返す
        /// </summary>
        static public IKoma CreateKyosha(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Kyousha(column, row, isSentegoma, isNarigoma);
        }

        /// <summary>
        /// "歩"オブジェクトを返す
        /// </summary>
        static public IKoma CreateFu(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Fu(column, row, isSentegoma, isNarigoma);
        }
    }
}
