using DomainShogi.Koma;
using DomainShogi.Sashites;

namespace DomainShogi.Banmen.Impl
{
    /// <summary>
    /// 局面クラス
    /// </summary>
    internal class Kyokumen : IKyokumen
    {
        /// <summary>
        /// 手数
        /// </summary>
        public int TurnCount { get; }

        /// <summary>
        /// 対局状態
        /// </summary>
        public GameState State { get; }

        /// <summary>
        /// 現在の指し手
        /// </summary>
        public ISashite? Current { get; }

        /// <summary>
        /// 盤上の駒
        /// </summary>
        public IEnumerable<IBanjoKoma> KomasOnBoard { get; }

        /// <summary>
        /// 先手の持ち駒
        /// </summary>
        public IEnumerable<IKoma>? SenteMochigoma { get; }

        /// <summary>
        /// 後手の持ち駒
        /// </summary>
        public IEnumerable<IKoma>? GoteMochigoma { get; }

        /// <summary>
        /// 駒を動かす
        /// </summary>
        /// <returns></returns>
        public IKyokumen Move(ISashite sashite)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// [Factory]初期盤面を返す
        /// </summary>
        /// <returns></returns>
        static public IKyokumen Init()
            => new Kyokumen(0, GameState.Init, null, Rule.InitialPlacement.InitialKomaPlaces());

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Kyokumen(
            int turnCount,
            GameState state,
            ISashite? current,
            IEnumerable<IBanjoKoma> komasOnBoard,
            IEnumerable<IKoma>? senteMochigoma = null,
            IEnumerable<IKoma>? goteMochigoma = null)
        {
            TurnCount = turnCount;
            State = state;
            Current = current;
            KomasOnBoard = komasOnBoard;
            SenteMochigoma = senteMochigoma;
            GoteMochigoma = goteMochigoma;
        }
    }
}
