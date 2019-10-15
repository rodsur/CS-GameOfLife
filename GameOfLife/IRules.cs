namespace Board
{
    public interface IRules
    {
        bool EnforceRules(bool state,int livingCells);
    }
}