using DomainShogi.Koma;
using DomainShogi.Sashites;

namespace DomainShogi.Banmen
{
    /// <summary>
    /// 局面
    /// </summary>
    public interface IKyokumen
    {
        /// <summary>
        /// 対局状態
        /// </summary>
        GameState State { get; }

        /// <summary>
        /// 現在の指し手
        /// </summary>
        ISashite Current { get; }

        /// <summary>
        /// 盤上の駒
        /// </summary>
        IEnumerable<IKoma> KomasOnBoard { get; }

        /// <summary>
        /// 先手の持ち駒
        /// </summary>
        IEnumerable<IKoma>? SenteMochigoma { get; }

        /// <summary>
        /// 後手の持ち駒
        /// </summary>
        IEnumerable<IKoma>? GoteMochigoma { get; }

        /// <summary>
        /// 駒を動かす
        /// </summary>
        /// <returns></returns>
        IKyokumen Move(ISashite sashite);
    }
}
