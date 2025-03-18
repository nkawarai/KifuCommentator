namespace DomainShogi.Banmen
{
    /// <summary>
    /// Intに関する拡張クラス
    /// </summary>
    static public class AddressExtensions
    {
        /// <summary>
        /// 1～9の整数を漢字に変換する
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        static public string ToKanji(this int self)
        {
            if (self == 1)
            {
                return "一";
            }
            else if (self == 2)
            {
                return "二";
            }
            else if (self == 3)
            {
                return "三";
            }
            else if (self == 4)
            {
                return "四";
            }
            else if (self == 5)
            {
                return "五";
            }
            else if (self == 6)
            {
                return "六";
            }
            else if (self == 7)
            {
                return "七";
            }
            else if (self == 8)
            {
                return "八";
            }
            else if (self == 9)
            {
                return "九";
            }
            else
            {
                //とりま
                return string.Empty;
            }
        }

        /// <summary>
        /// 1～9の整数を全角数字文字列に変換する
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        static public string ToZenkakuString(this int self)
        {
            if (self == 1)
            {
                return "１";
            }
            else if (self == 2)
            {
                return "２";
            }
            else if (self == 3)
            {
                return "３";
            }
            else if (self == 4)
            {
                return "４";
            }
            else if (self == 5)
            {
                return "５";
            }
            else if (self == 6)
            {
                return "６";
            }
            else if (self == 7)
            {
                return "７";
            }
            else if (self == 8)
            {
                return "８";
            }
            else if (self == 9)
            {
                return "９";
            }
            else
            {
                //とりま
                return string.Empty;
            }
        }
    }
}
