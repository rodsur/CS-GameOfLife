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
    }
}