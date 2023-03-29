namespace Temporary;

internal class Horse : AnimalBehavior
{
    private readonly string _name;

    public Horse(string name, uint satiety) : base(satiety)
    {
        _name = name;
    }

    public void GetHorseInfo(Horse horse)
    {
        Console.WriteLine($"Я - лошадь. Меня зовут {horse._name}. Уровень моей сытости: {Satiety}");
    }
}