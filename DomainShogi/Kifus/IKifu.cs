using DomainShogi.Players;

namespace DomainShogi.Kifus
{
    public interface IKifu
    {
        /// <summary>
        /// 先手対局者
        /// </summary>
        IPlayer SentePlayer { get; }

        /// <summary>
        /// 後手対局者
        /// </summary>
        IPlayer GotePlayer { get; }

        /// <summary>
        /// 対局日時
        /// </summary>
        DateTime? GameDateTime { get; }

        /// <summary>
        /// 対局名
        /// </summary>
        string? GameTitle { get; }

        /// <summary>
        /// 指し手リスト
        /// </summary>
        IEnumerable<string>? PlayerHands { get; }

        /// <summary>
        /// 指し手を追加する
        /// </summary>
        void AddSasite(string sashite);
    }
}