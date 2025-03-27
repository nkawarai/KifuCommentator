namespace DomainShogi.Statics
{
    /// <summary>
    /// 拡張メソッド
    /// </summary>
    static public class Extensions
    {
        /// <summary>
        /// string型をDateTime型に変換する
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        static public DateTime? ToDatetime(this string self)
        {
            if (DateTime.TryParse(self, out var result))
            {
                return result;
            }
            return null;
        }
    }
}
