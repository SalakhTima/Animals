namespace Temporary;

internal class Cat : AnimalBehavior
{
    private readonly string _name;
        
    public Cat(string name, uint satiety) : base(satiety)
    {
        _name = name;
    }

    public void GetCatInfo(Cat cat)
    {
        Console.WriteLine($"Я - кот. Меня зовут {cat._name}. Уровень моей сытости: {Satiety}");
    }
}