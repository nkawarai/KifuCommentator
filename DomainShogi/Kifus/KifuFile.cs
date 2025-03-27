namespace DomainShogi.Kifus
{
    using Statics;
    using Players;

    /// <summary>
    /// 棋譜ファイル
    /// </summary>
    public class KifuFile
    {
        /// <summary>
        /// 棋譜ファイルを読み込む
        /// </summary>
        static public IKifu LoadKifuFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"{filePath}");
            }

            var lines = File.ReadAllLines(filePath).ToList();
            var sentePlayerName = lines
                .Where(x => x.Contains(Spec.SENTE_NAME))
                .FirstOrDefault()?
                .Replace(Spec.SENTE_NAME, "") ?? string.Empty;

            var gotePlayerName = lines
                .Where(x => x.Contains(Spec.GOTE_NAME))
                .FirstOrDefault()?
                .Replace(Spec.GOTE_NAME, "") ?? string.Empty;

            var gameDate = lines
                .Where(x => x.Contains(Spec.GAME_DATE))
                .FirstOrDefault()?
                .Replace(Spec.GAME_DATE, "")
                .ToDatetime();

            var gameName = lines
                .Where(x => x.Contains(Spec.GAME_NAME))
                .FirstOrDefault()?
                .Replace(Spec.GAME_NAME, "");

            var kifu = Kifu.Factory(
                Player.Factory(sentePlayerName),
                Player.Factory(gotePlayerName),
                gameDate,
                gameName);

            var sasiteIndex = lines.IndexOf(Spec.SASITE_HEAD);
            if (sasiteIndex < 0) throw new FormatException();
            for (var i = sasiteIndex + 1; i < lines.Count; i++)
            {
                if (lines[i].Contains("*")) continue;
                var array = lines[i].Trim().Split(' ');
                if (array.Length != 3) throw new FormatException();
                if (!int.TryParse(array[0], out var count)) throw new FormatException();
                kifu.AddSasite(array[1]); //消費時間はとりあえず無視
            }

            return kifu;
        }

        /// <summary>
        /// ファイル仕様
        /// </summary>
        private static class Spec
        {
            static public readonly string SENTE_NAME = "先手：";
            static public readonly string GOTE_NAME = "後手：";
            static public readonly string GAME_DATE = "開始日時：";
            static public readonly string GAME_NAME = "棋戦：";
            static public readonly string SASITE_HEAD = "手数----指手---------消費時間--";
        }
    }
}
