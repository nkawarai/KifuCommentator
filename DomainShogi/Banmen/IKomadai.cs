
namespace DomainShogi.Banmen
{
    using Koma;

    /// <summary>
    /// 駒台
    /// </summary>
    public interface IKomadai
    {
        /// <summary>
        /// 駒を追加する
        /// </summary>
        /// <param name="koma"></param>
        void Add(IKoma koma);

        /// <summary>
        /// 駒を取り除く
        /// </summary>
        /// <param name="koma"></param>
        bool Remove(IKoma koma);

        /// <summary>
        /// 「金」をカウントする
        /// </summary>
        /// <returns></returns>
        int CountKin();

        /// <summary>
        /// 「銀」をカウントする
        /// </summary>
        /// <returns></returns>
        int CountGin();

        /// <summary>
        /// 「桂」をカウントする
        /// </summary>
        /// <returns></returns>
        int CountKei();

        /// <summary>
        /// 「香」をカウントする
        /// </summary>
        /// <returns></returns>
        int CountKyou();

        /// <summary>
        /// 「飛車」をカウントする
        /// </summary>
        /// <returns></returns>
        int CountHisha();

        /// <summary>
        /// 「角」をカウントする
        /// </summary>
        /// <returns></returns>
        int CountKaku();
    }
}
