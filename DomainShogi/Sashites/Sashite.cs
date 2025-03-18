namespace DomainShogi.Sashites
{
    using Banmen;
    using Koma;

    public class Sashite : ISashite
    {
        /// <summary>
        /// 手数
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// 指し手の元符号
        /// </summary>
        public IAddress? From { get; }

        /// <summary>
        /// 指し手の符号
        /// </summary>
        public IAddress To { get; }

        /// <summary>
        /// 駒
        /// </summary>
        public IKoma Koma { get; }

        /// <summary>
        /// 先手の指し手か
        /// </summary>
        public bool IsSente => Count % 2 == 0;

        /// <summary>
        /// 指し手の文字列変換
        /// </summary>
        public string ToDisplayString()
        {
            var sashiteStr = string.Empty;
            //TODO 実装する
            return sashiteStr;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Sashite(int count, IKoma koma, IAddress? from, IAddress to)
        {
            Count = count;
            Koma = koma;
            From = from;
            To = to;
        }
    }
}
