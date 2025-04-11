namespace DomainShogi.Koma
{
    using Impl;

    /// <summary>
    /// 駒ファクトリ
    /// </summary>
    public class BanjoKomaFactory
    {
        /// <summary>
        /// "玉"オブジェクトを返す
        /// </summary>
        /// <returns></returns>
        static public IBanjoKoma CreateGyoku(int column, int row, bool isSentegoma)
        {
            return new Gyoku(column, row, isSentegoma);
        }

        /// <summary>
        /// "飛車"オブジェクトを返す
        /// </summary>
        static public IBanjoKoma CreateHisha(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Hisha(column, row, isSentegoma, isNarigoma);
        }

        /// <summary>
        /// "角"オブジェクトを返す
        /// </summary>
        static public IBanjoKoma CreateKaku(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Kaku(column, row, isSentegoma, isNarigoma);
        }

        /// <summary>
        /// "金"オブジェクトを返す
        /// </summary>
        static public IBanjoKoma CreateKin(int column, int row, bool isSentegoma)
        {
            return new Kin(column, row, isSentegoma);
        }

        /// <summary>
        /// "銀"オブジェクトを返す
        /// </summary>
        static public IBanjoKoma CreateGin(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Gin(column, row, isSentegoma, isNarigoma);
        }

        /// <summary>
        /// "桂馬"オブジェクトを返す
        /// </summary>
        static public IBanjoKoma CreateKeima(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Keima(column, row, isSentegoma, isNarigoma);
        }

        /// <summary>
        /// "香車"オブジェクトを返す
        /// </summary>
        static public IBanjoKoma CreateKyosha(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Kyousha(column, row, isSentegoma, isNarigoma);
        }

        /// <summary>
        /// "歩"オブジェクトを返す
        /// </summary>
        static public IBanjoKoma CreateFu(int column, int row, bool isSentegoma, bool isNarigoma = false)
        {
            return new Fu(column, row, isSentegoma, isNarigoma);
        }
    }
}
