namespace _1656
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    struct Cell
    {
/*        public Cell(int row, int col, int rank)
        {
            this.row = row;
            this.col = col;
            this.rank = rank;
        }
        */
        public int row;
        public int col;
        public int rank;

        public static int CompareTo(Cell cell1, Cell cell2)
        {
            return cell1.rank.CompareTo(cell2.rank);
        }
    }

    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            List<byte> height = new List<byte>(size * size);
            for (int line = 0; line < size*size; ++line)
                height.Add(byte.Parse(Console.ReadLine()));
            height.Sort();
            height.Reverse();

            var field = new int[size, size];
            var cells = new List<Cell>(size * size);

            for (int row = 0; row < size; ++row)
                for (int col = 0; col < size; ++col)
                {
                    int row2 = row - size / 2;
                    int col2 = col - size / 2;
                    int rank = Math.Abs(row2) + Math.Abs(col2);
                    field[row, col] = rank;
                    Cell cell = new Cell();
                    cell.row = row;
                    cell.col = col;
                    cell.rank = rank;
                    cells.Add(cell);
                }
            cells.Sort(Cell.CompareTo);
            var hh = height.GetEnumerator();
            hh.MoveNext();
            foreach (var cell in cells)
            {
//                Console.WriteLine("{0} {1} {2} {3}", cell.rank, cell.row, cell.col, hh.Current);
                field[cell.row, cell.col] = hh.Current;
                hh.MoveNext();
            }

            for (var row = 0; row < size; ++row)
            {
                for (var col = 0; col < size; ++col)
                {
                    Console.Write("{0,2}", field[row, col]);
                    if (col != size - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
