namespace DomainShogi.Players
{
    /// <summary>
    /// ‘Î‹ÇÒ
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// ‘Î‹ÇÒ–¼
        /// </summary>
        string Name { get; }

        /// <summary>
        /// ’iˆÊEŒhÌ
        /// </summary>
        string? RankName { get; }
    }
}
