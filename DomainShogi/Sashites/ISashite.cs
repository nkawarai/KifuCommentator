namespace DomainShogi.Sashites
{
    using Koma;
    using Banmen;

    /// <summary>
    /// 指し手
    /// </summary>
    public interface ISashite
    {
        /// <summary>
        /// 手数
        /// </summary>
        int Count { get; }

        /// <summary>
        /// 指し手の元符号
        /// </summary>
        IAddress? From { get; }


        /// <summary>
        /// 指し手の符号
        /// </summary>
        IAddress To { get; }

        /// <summary>
        /// 駒
        /// </summary>
        IKoma Koma { get; }

        /// <summary>
        /// 先手の指し手か
        /// </summary>
        bool IsSente { get; }

        /// <summary>
        /// 指し手の文字列変換
        /// </summary>
        string ToDisplayString();
    }
}
