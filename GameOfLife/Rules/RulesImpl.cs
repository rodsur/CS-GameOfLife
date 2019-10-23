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
            _resurrectionThreshold = 3;
        }
        
        
        public bool EnforceRules(bool state, int livingCells)
        {
            if ((state == true && livingCells <= _underpopThreshold) || (state == true && livingCells >= _overpopThreshold))
            {
                return false;
            } else if (state == false && livingCells == _resurrectionThreshold)
            {
                return true;
            }
            
            return state;
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