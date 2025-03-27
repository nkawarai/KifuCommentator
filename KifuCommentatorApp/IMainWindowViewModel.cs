namespace KifuCommentatorApp
{
    using DomainShogi.Kifus;

    public interface IMainWindowViewModel
    {
        /// <summary>
        /// 棋譜を設定する
        /// </summary>
        /// <param name="kifu"></param>
        void SetKifu(IKifu kifu);
    }
}
