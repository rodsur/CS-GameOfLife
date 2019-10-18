using NUnit.Framework;
using GameOfLife;
using GameOfLife.Board;

namespace Tests
{
    public class Tests
    {
        
        private BoardImpl _board;
        
        [SetUp]
        public void Setup()
        {
            _board = new BoardImpl(10,10);
        }

        [Test]
        public void SetGetCellTest()
        {
            _board.SetCell(2,2,true);
            Assert.True(_board.GetCell(2,2));
        }

        [Test]
        public void SetGetSizeTest()
        {
            _board.SetSize(2,3);
            Assert.AreEqual(_board.GetSize()[0],2);
            Assert.AreEqual(_board.GetSize()[1],3);
        }

        [Test]
        public void ClearBoardTest()
        {
            _board.SetCell(1,2,true);
            _board.ClearBoard();
            Assert.False(_board.GetCell(1,2));
        }
    }
}