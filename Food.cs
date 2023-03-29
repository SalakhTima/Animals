namespace Temporary;

internal class Food
{
    public string Type { get; }
    public uint Calories { get; }

    public Food(string type, uint calories)
    {
        Type = type;
        Calories = calories;
    }
}