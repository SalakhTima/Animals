namespace Temporary;

class Controller
{
    static void Main(string[] args)
    {
        // все, что связано с котом
        Cat cat = new Cat("Сережа", 11);

        Food pivko = new Food("Пиво", 5);

        cat.Sleeping();

        cat.Eating(pivko);

        cat.Talking();

        cat.GetCatInfo(cat);

        Console.WriteLine("------------------------------------------------------------------------");

        // все, что связано с собакой
        Dog dog = new Dog("Леван", 18);

        Food sandwich = new Food("Сэндвич", 12);

        dog.Sleeping();

        dog.Eating(sandwich);

        dog.Talking();

        dog.GetDogInfo(dog);

        Console.WriteLine("------------------------------------------------------------------------");

        // все, что связано с лошадью
        Horse horse = new Horse("Не придумал имя", 15);

        Food carrot = new Food("Морковка", 17);

        horse.Sleeping();

        horse.Eating(carrot);

        horse.Talking();

        horse.GetHorseInfo(horse);
    }
}