namespace GameOfLife.Rules
{
    public class RulesImpl : IRules
    {
        private int _underpopThreshold;
        private int _overpopThreshold;
        private int _resurrectionThreshold;
        
        public RulesImpl()
        {
            _underpopThreshold = 2;
            _overpopThreshold = 4;
        }
        
        
        public bool EnforceRules(bool state, int livingCells)
        {
            throw new System.NotImplementedException();
        }

        public void setUnderpopThreshold(int cells)
        {
            throw new System.NotImplementedException();
        }

        public void setOverpopThreshold(int cells)
        {
            throw new System.NotImplementedException();
        }

        public void setResurrectionThreshold(int cells)
        {
            throw new System.NotImplementedException();
        }
    }
}