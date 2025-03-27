namespace DomainShogi.Kifus
{
    using Statics;
    using Players;
    using System.Text;

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

            var lines = ReadAllLinesWithAutoEncoding(filePath).ToList();
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
                var array = lines[i].Trim().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x))?.ToArray();
                if (array == null || array.Length < 2) throw new FormatException(); //とりあえず2カラムあればよい
                if (!int.TryParse(array[0], out var count)) throw new FormatException();
                kifu.AddSasite(array[1]); //消費時間はとりあえず無視

                if (array[1] == "投了") break; //TODO 仮実装
            }

            return kifu;
        }

        static string[] ReadAllLinesWithAutoEncoding(string filePath)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            byte[] bytes = File.ReadAllBytes(filePath);

            // UTF-8 の BOM あり判定
            if (bytes.Length >= 3 && bytes[0] == 0xEF && bytes[1] == 0xBB && bytes[2] == 0xBF)
            {
                return File.ReadAllLines(filePath, Encoding.UTF8);
            }

            // Shift-JIS で読み込んで文字化けしないか確認
            string sjisText = Encoding.GetEncoding("shift_jis").GetString(bytes);
            if (sjisText.Contains("�"))
            {
                return File.ReadAllLines(filePath, Encoding.UTF8);
            }

            // 正常に読み込めたら Shift-JIS とみなす
            return File.ReadAllLines(filePath, Encoding.GetEncoding("shift_jis"));
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
