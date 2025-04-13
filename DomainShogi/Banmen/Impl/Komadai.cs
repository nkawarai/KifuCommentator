using DomainShogi.Koma;

namespace DomainShogi.Banmen.Impl
{
    /// <summary>
    /// 駒台クラス
    /// </summary>
    internal class Komadai : IKomadai
    {
        private List<IKoma> _mochigomas;

        /// <summary>
        /// 駒を追加する
        /// </summary>
        public void Add(IKoma koma)
        {
            if (koma.Kind == KomaKinds.Gyoku)
            {
                throw new ArgumentException("Gyoku cannot be added to komadai.");
            }
            _mochigomas.Add(koma);
        }

        /// <summary>
        /// 駒を取り除く
        /// </summary>
        /// <param name="koma"></param>
        public bool Remove(IKoma koma)
        {
            return _mochigomas.Remove(koma);
        }

        /// <summary>
        /// 「金」をカウントする
        /// </summary>
        /// <returns></returns>
        public int CountKin()
            => _mochigomas.Count(x => x.Kind == KomaKinds.Kin);

        /// <summary>
        /// 「銀」をカウントする
        /// </summary>
        /// <returns></returns>
        public int CountGin()
            => _mochigomas.Count(x => x.Kind == KomaKinds.Gin);


        /// <summary>
        /// 「桂」をカウントする
        /// </summary>
        /// <returns></returns>
        public int CountKei()
            => _mochigomas.Count(x => x.Kind == KomaKinds.Kei);
        
        /// <summary>
        /// 「香」をカウントする
        /// </summary>
        /// <returns></returns>
        public int CountKyou()
            => _mochigomas.Count(x => x.Kind == KomaKinds.Kyou);

        /// <summary>
        /// 「飛車」をカウントする
        /// </summary>
        /// <returns></returns>
        public int CountHisha()
            => _mochigomas.Count(x => x.Kind == KomaKinds.Hisha);

        /// <summary>
        /// 「角」をカウントする
        /// </summary>
        /// <returns></returns>
        public int CountKaku()
            => _mochigomas.Count(x => x.Kind == KomaKinds.Kaku);

        /// <summary>
        /// ファクトリーメソッド
        /// </summary>
        /// <returns></returns>
        static public IKomadai Factory()
            => new Komadai();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Komadai()
        {
            _mochigomas = new List<IKoma>();
        }

    }
}
