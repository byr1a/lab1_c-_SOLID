public class GameSettings
{
    public int MinNumber { get; set; }
    public int MaxNumber { get; set; }

    public GameSettings(int minNumber, int maxNumber)
    {
        MinNumber = minNumber;
        MaxNumber = maxNumber;
    }
}