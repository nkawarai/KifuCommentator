namespace DomainShogi.Players
{
    /// <summary>
    /// �΋ǎ�
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// �΋ǎҖ�
        /// </summary>
        string Name { get; }

        /// <summary>
        /// �i�ʁE�h��
        /// </summary>
        string? RankName { get; }
    }
}
