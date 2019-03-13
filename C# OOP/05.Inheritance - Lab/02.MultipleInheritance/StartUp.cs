namespace Farm
{
    public class StartUp
    {
       public static void Main()
        {
            Puppy puppy = new Puppy();

            puppy.Bark();
            puppy.Eat();
            puppy.Weep();

            Dog dog = new Dog();

            dog.Bark();
            dog.Eat();
        }
    }
}
