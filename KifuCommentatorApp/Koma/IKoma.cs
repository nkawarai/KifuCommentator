using ShogibanLib;

namespace KifuCommentator.Koma
{
    /// <summary>
    /// 将棋駒　インターフェイス
    /// </summary>
    public interface IKoma : IKomaDisplay
    {
        /// <summary>
        /// 駒種別
        /// </summary>
        KomaKinds Kind { get; }

        /// <summary>
        /// 駒文字
        /// </summary>
        string DisplayCharacter { get; }

        /// <summary>
        /// 成駒文字
        /// </summary>
        string? NariDisplayCharacter { get; }

        /// <summary>
        /// 成駒か
        /// </summary>
        bool IsNarigoma { get; }
    }
}
