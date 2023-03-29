namespace Temporary;

internal class Dog : AnimalBehavior
{
    private readonly string _name;

    public Dog(string name, uint satiety) : base(satiety)
    {
        _name = name;
    }

    public void GetDogInfo(Dog dog)
    {
        Console.WriteLine($"Я - собака. Меня зовут {dog._name}. Уровень моей сытости: {Satiety}");
    }
}