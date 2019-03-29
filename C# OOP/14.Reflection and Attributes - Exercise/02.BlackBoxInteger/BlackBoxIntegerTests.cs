namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);

            var instance = Activator.CreateInstance(type, true);

            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            string input = Console.ReadLine();

            while(input != "END")
            {
                string[] splitedInput = input.Split("_");
                string methodName = splitedInput[0];
                int value = int.Parse(splitedInput[1]);

                var method = methods.FirstOrDefault(x => x.Name == methodName);

                method.Invoke(instance, new object[] { value });

                var field = type.GetField("innerValue",BindingFlags.Instance | BindingFlags.NonPublic);

                Console.WriteLine(field.GetValue(instance));

                input = Console.ReadLine();
            }
        }
    }
}
