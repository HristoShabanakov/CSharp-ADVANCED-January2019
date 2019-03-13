namespace Farm
{
    public class StartUp
    {
       public static void Main()
        {
            Dog dog = new Dog();

            dog.Bark();
            dog.Eat();

            Cat cat = new Cat();

            cat.Eat();
            cat.Meow();
        }
    }
}
