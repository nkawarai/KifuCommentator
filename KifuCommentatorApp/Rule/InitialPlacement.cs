using System.Collections.Generic;
using KifuCommentator.Koma;

namespace KifuCommentator.Rule
{
    /// <summary>
    /// 初期配置
    /// </summary>
    internal class InitialPlacement
    {
        /// <summary>
        /// 初期配置を表す駒リストを返す
        /// </summary>
        /// <returns></returns>
        static public IEnumerable<IKoma> InitialKomaPlaces()
        {
            var list = new List<IKoma>();

            //先手
            list.Add(KomaFactory.CreateGyoku(5, 9, true));
            list.Add(KomaFactory.CreateKin(6, 9, true));
            list.Add(KomaFactory.CreateKin(4, 9, true));
            list.Add(KomaFactory.CreateGin(7, 9, true));
            list.Add(KomaFactory.CreateGin(3, 9, true));
            list.Add(KomaFactory.CreateKeima(8, 9, true));
            list.Add(KomaFactory.CreateKeima(2, 9, true));
            list.Add(KomaFactory.CreateKyosha(9, 9, true));
            list.Add(KomaFactory.CreateKyosha(1, 9, true));
            list.Add(KomaFactory.CreateKaku(8, 8, true));
            list.Add(KomaFactory.CreateHisha(2, 8, true));
            list.Add(KomaFactory.CreateFu(1, 7, true));
            list.Add(KomaFactory.CreateFu(2, 7, true));
            list.Add(KomaFactory.CreateFu(3, 7, true));
            list.Add(KomaFactory.CreateFu(4, 7, true));
            list.Add(KomaFactory.CreateFu(5, 7, true));
            list.Add(KomaFactory.CreateFu(6, 7, true));
            list.Add(KomaFactory.CreateFu(7, 7, true));
            list.Add(KomaFactory.CreateFu(8, 7, true));
            list.Add(KomaFactory.CreateFu(9, 7, true));

            //後手
            list.Add(KomaFactory.CreateGyoku(5, 1, false));
            list.Add(KomaFactory.CreateKin(6, 1, false));
            list.Add(KomaFactory.CreateKin(4, 1, false));
            list.Add(KomaFactory.CreateGin(7, 1, false));
            list.Add(KomaFactory.CreateGin(3, 1, false));
            list.Add(KomaFactory.CreateKeima(8, 1, false));
            list.Add(KomaFactory.CreateKeima(2, 1, false));
            list.Add(KomaFactory.CreateKyosha(9, 1, false));
            list.Add(KomaFactory.CreateKyosha(1, 1, false));
            list.Add(KomaFactory.CreateKaku(2, 2, false));
            list.Add(KomaFactory.CreateHisha(8, 2, false));
            list.Add(KomaFactory.CreateFu(1, 3, false));
            list.Add(KomaFactory.CreateFu(2, 3, false));
            list.Add(KomaFactory.CreateFu(3, 3, false));
            list.Add(KomaFactory.CreateFu(4, 3, false));
            list.Add(KomaFactory.CreateFu(5, 3, false));
            list.Add(KomaFactory.CreateFu(6, 3, false));
            list.Add(KomaFactory.CreateFu(7, 3, false));
            list.Add(KomaFactory.CreateFu(8, 3, false));
            list.Add(KomaFactory.CreateFu(9, 3, false));

            return list;
        }
    }
}
