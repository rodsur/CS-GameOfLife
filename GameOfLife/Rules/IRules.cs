namespace GameOfLife.Rules
{
    public interface IRules
    {
        bool EnforceRules(bool state,int livingCells);
        void setLivingThreshold(int cells);
        void setDyingThreshold(int cells);
        void setResurrectionThreshold(int cells);
    }
}