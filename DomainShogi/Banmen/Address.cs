namespace DomainShogi.Banmen
{
    public class Address : IAddress
    {
        /// <summary>
        /// 筋
        /// </summary>
        public int Column { get; }

        /// <summary>
        /// 段
        /// </summary>
        public int Row { get; }

        /// <summary>
        /// 文字列表現
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Column.ToZenkakuString() + Row.ToKanji();
        }

        /// <summary>
        /// Factory
        /// </summary>
        static public IAddress Factory(int column, int row)
        {
            if (column < 0 || 9 < column)
            {
                throw new ArgumentOutOfRangeException("column");
            }
            if (row < 0 || 9 < row)
            {
                throw new ArgumentOutOfRangeException("row");
            }
            return new Address(column, row);
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Address(int column, int row)
        {
            Column = column;
            Row = row;
        }
    }
}
