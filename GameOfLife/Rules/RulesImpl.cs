namespace GameOfLife.Rules
{
    public class RulesImpl : IRules
    {
        private int _livingThreshold;
        private int _dyingThreshold;
        private int _resurrectionThreshold;
        
        public RulesImpl()
        {
            
        }
        
        
        public bool EnforceRules(bool state, int livingCells)
        {
            throw new System.NotImplementedException();
        }

        public void setLivingThreshold(int cells)
        {
            throw new System.NotImplementedException();
        }

        public void setDyingThreshold(int cells)
        {
            throw new System.NotImplementedException();
        }

        public void setResurrectionThreshold(int cells)
        {
            throw new System.NotImplementedException();
        }
    }
}