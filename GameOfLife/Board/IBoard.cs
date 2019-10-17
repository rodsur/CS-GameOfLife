namespace GameOfLife.Board
{
    public interface IBoard
    {
        void ClearBoard();
        void PopulateBoard(bool[,] board);
        void SetSize(int x, int y);
        void SetCell(int x, int y, bool state);
        bool GetCell(int x, int y);

    }
}