namespace DomainShogi.Players
{
    public class Player : IPlayer
    {
        /// <summary>
        /// 対局者名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 段位・敬称
        /// </summary>
        public string? RankName { get; }

        /// <summary>
        /// Factory
        /// </summary>
        static public IPlayer Factory(string name, string? rankName = null)
            => new Player(name, rankName);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Player(string name, string? rankName)
        {
            Name = name;
            RankName = rankName;
        }
    }
}
