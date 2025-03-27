namespace DomainShogi.Kifus
{
    using Players;

    internal class Kifu : IKifu
    {
        /// <summary>
        /// 先手対局者
        /// </summary>
        public IPlayer SentePlayer { get; }

        /// <summary>
        /// 後手対局者
        /// </summary>
        public IPlayer GotePlayer { get; }

        /// <summary>
        /// 対局日時
        /// </summary>
        public DateTime? GameDateTime { get; }

        /// <summary>
        /// 対局名
        /// </summary>
        public string? GameTitle { get; }

        /// <summary>
        /// 指し手リスト
        /// </summary>
        public IEnumerable<string>? PlayerHands { get; }

        /// <summary>
        /// 指し手を追加する
        /// </summary>
        public void AddSasite(string sashite)
        {
            PlayerHands?.ToList().Add(sashite);
        }


        /// <summary>
        /// Factory
        /// </summary>
        /// <returns></returns>
        static public IKifu Factory(IPlayer sente, IPlayer gote, DateTime? gameDatetime = null, string? gameTitle = null)
            => new Kifu(sente, gote, gameDatetime, gameTitle);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Kifu(IPlayer sente, IPlayer gote, DateTime? gameDatetime = null, string? gameTitle = null)
        {
            SentePlayer = sente;
            GotePlayer = gote;
            GameDateTime = gameDatetime;
            GameTitle = gameTitle;
            PlayerHands = new List<string>();
        }
    }
}
