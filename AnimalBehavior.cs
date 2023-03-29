namespace Temporary;

internal class AnimalBehavior
{
    public static uint Satiety { get; private set; }

    public AnimalBehavior(uint satiety)
    {
        Satiety = satiety;
    }

    public void Talking()
    {
        Console.WriteLine("Я разговариваю на своем животном языке. Потрачено 10 единиц сытости.");

        Satiety -= 10;
    }

    public void Eating(Food food)
    {
        Console.WriteLine($"Я ем {food.Type}. Восполнил единиц сытости на {food.Calories}");

        Satiety += food.Calories;
    }

    public void Sleeping()
    {
        Console.WriteLine("Я сплю. Во время сна я трачу 3 единицы сытости.");

        Satiety -= 3;
    }
}