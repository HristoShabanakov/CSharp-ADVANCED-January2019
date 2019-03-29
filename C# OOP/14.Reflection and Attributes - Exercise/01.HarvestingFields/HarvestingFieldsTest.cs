namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type typeHarvestingFields = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == nameof(HarvestingFields));

            FieldInfo[] fieldInfos = typeHarvestingFields
                .GetFields(BindingFlags.Instance |
                BindingFlags.NonPublic | BindingFlags.Public);

            string accessModifierAsString = Console.ReadLine();

            while (accessModifierAsString != "HARVEST")
            {
                FieldInfo[] fieldInfosToPrint = null;

                switch (accessModifierAsString)
                {
                    case "private":
                        fieldInfosToPrint = fieldInfos.Where(x => x.IsPrivate).ToArray();
                        break;
                    case "protected":
                        fieldInfosToPrint = fieldInfos.Where(x => x.IsFamily).ToArray();
                        break;
                    case "public":
                        fieldInfosToPrint = fieldInfos.Where(x => x.IsPublic).ToArray();
                        break;
                    default:
                        fieldInfosToPrint = fieldInfos;
                        break;
                }

                foreach (var fieldInfo in fieldInfosToPrint)
                {
                    string accessModifier = fieldInfo.Attributes.ToString().ToLower() ==
                        "family" ? "protected" : fieldInfo.Attributes.ToString().ToLower();

                    Console.WriteLine($"{accessModifier} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
                }

                accessModifierAsString = Console.ReadLine();
            }
        }
    }
}
