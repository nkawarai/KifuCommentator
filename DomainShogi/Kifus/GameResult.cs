namespace DomainShogi.Kifus
{
    /// <summary>
    /// 対局結果
    /// </summary>
    public class GameResult
    {
        static public bool KifuIsCompleted(string kifuString)
        {
            if (kifuString == "投了"
                || kifuString == "中断"
                || kifuString == "持将棋"
                || kifuString == "千日手"
                || kifuString == "切れ負け"
                || kifuString == "反則勝ち"
                || kifuString == "反則負け"
                || kifuString == "入玉勝ち")
            {
                return true;
            }
            return false;
        }
    }
}
