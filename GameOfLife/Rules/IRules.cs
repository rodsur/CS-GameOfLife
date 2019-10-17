namespace GameOfLife.Rules
{
    public interface IRules
    {
        bool EnforceRules(bool state,int livingCells);
    }
}