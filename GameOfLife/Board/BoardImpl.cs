using Board;

namespace GameOfLife.Board
{
    public class BoardImpl : IBoard
    {
        private bool[,] _board;
        
        public BoardImpl(int x, int y)
        {
            
            SetSize(x,y);
        }
        
        public void ClearBoard()
        {
            for (var x = 0; x < _board.GetLength(0); x++)
            {
                for (var y = 0; y < _board.GetLength(1); y++)
                {
                    SetCell(x, y, false);
                }
            }
        }

        public void PopulateBoard(bool[,] board)
        {
            throw new System.NotImplementedException();
        }

        public void SetSize(int x, int y)
        {
            _board = new bool[x,y];
        }

        public void SetCell(int x, int y, bool state)
        {
            _board[x,y] = state;
        }

        public bool GetCell(int x, int y)
        {
            return _board[x, y];
        }
    }
}