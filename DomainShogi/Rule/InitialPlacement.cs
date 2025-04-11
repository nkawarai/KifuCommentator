namespace DomainShogi.Rule
{
    using Koma;

    /// <summary>
    /// 初期配置
    /// </summary>
    public class InitialPlacement
    {
        /// <summary>
        /// 初期配置を表す駒リストを返す
        /// </summary>
        /// <returns></returns>
        static public IEnumerable<IBanjoKoma> InitialKomaPlaces()
        {
            var list = new List<IBanjoKoma>();

            //先手
            list.Add(BanjoKomaFactory.CreateGyoku(5, 9, true));
            list.Add(BanjoKomaFactory.CreateKin(6, 9, true));
            list.Add(BanjoKomaFactory.CreateKin(4, 9, true));
            list.Add(BanjoKomaFactory.CreateGin(7, 9, true));
            list.Add(BanjoKomaFactory.CreateGin(3, 9, true));
            list.Add(BanjoKomaFactory.CreateKeima(8, 9, true));
            list.Add(BanjoKomaFactory.CreateKeima(2, 9, true));
            list.Add(BanjoKomaFactory.CreateKyosha(9, 9, true));
            list.Add(BanjoKomaFactory.CreateKyosha(1, 9, true));
            list.Add(BanjoKomaFactory.CreateKaku(8, 8, true));
            list.Add(BanjoKomaFactory.CreateHisha(2, 8, true));
            list.Add(BanjoKomaFactory.CreateFu(1, 7, true));
            list.Add(BanjoKomaFactory.CreateFu(2, 7, true));
            list.Add(BanjoKomaFactory.CreateFu(3, 7, true));
            list.Add(BanjoKomaFactory.CreateFu(4, 7, true));
            list.Add(BanjoKomaFactory.CreateFu(5, 7, true));
            list.Add(BanjoKomaFactory.CreateFu(6, 7, true));
            list.Add(BanjoKomaFactory.CreateFu(7, 7, true));
            list.Add(BanjoKomaFactory.CreateFu(8, 7, true));
            list.Add(BanjoKomaFactory.CreateFu(9, 7, true));

            //後手
            list.Add(BanjoKomaFactory.CreateGyoku(5, 1, false));
            list.Add(BanjoKomaFactory.CreateKin(6, 1, false));
            list.Add(BanjoKomaFactory.CreateKin(4, 1, false));
            list.Add(BanjoKomaFactory.CreateGin(7, 1, false));
            list.Add(BanjoKomaFactory.CreateGin(3, 1, false));
            list.Add(BanjoKomaFactory.CreateKeima(8, 1, false));
            list.Add(BanjoKomaFactory.CreateKeima(2, 1, false));
            list.Add(BanjoKomaFactory.CreateKyosha(9, 1, false));
            list.Add(BanjoKomaFactory.CreateKyosha(1, 1, false));
            list.Add(BanjoKomaFactory.CreateKaku(2, 2, false));
            list.Add(BanjoKomaFactory.CreateHisha(8, 2, false));
            list.Add(BanjoKomaFactory.CreateFu(1, 3, false));
            list.Add(BanjoKomaFactory.CreateFu(2, 3, false));
            list.Add(BanjoKomaFactory.CreateFu(3, 3, false));
            list.Add(BanjoKomaFactory.CreateFu(4, 3, false));
            list.Add(BanjoKomaFactory.CreateFu(5, 3, false));
            list.Add(BanjoKomaFactory.CreateFu(6, 3, false));
            list.Add(BanjoKomaFactory.CreateFu(7, 3, false));
            list.Add(BanjoKomaFactory.CreateFu(8, 3, false));
            list.Add(BanjoKomaFactory.CreateFu(9, 3, false));

            return list;
        }
    }
}
