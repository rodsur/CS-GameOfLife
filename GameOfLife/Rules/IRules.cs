namespace GameOfLife.Rules
{
    public interface IRules
    {
        bool EnforceRules(bool state,int livingCells);
        void setUnderpopThreshold(int cells);
        void setOverpopThreshold(int cells);
        void setResurrectionThreshold(int cells);
    }
}