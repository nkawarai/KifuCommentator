namespace DomainShogi.Banmen
{
    public interface IAddress
    {
        /// <summary>
        /// 筋
        /// </summary>
        int Column { get; }

        /// <summary>
        /// 段
        /// </summary>
        int Row { get; }

        /// <summary>
        /// 文字列表現
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}
