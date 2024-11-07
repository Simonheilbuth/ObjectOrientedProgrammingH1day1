namespace ObjectOrientedProgrammingH1day1
{
    using System;






    class Program
    {
        static void Main(string[] args)
        {
             
            string text = @"It supports the principle of inheritance. Types can derive from other types, called base types. The derived type inherits (with some restrictions) the methods, properties, and other members of the base type. The base type can in turn derive from some other type, in which case the derived type inherits the members of both base types in its inheritance hierarchy. All types, including built-in numeric types such as System.Int32 (C# keyword: int), derive ultimately from a single base type, which is System.Object (C# keyword: object). This unified type hierarchy is called the Common Type System (CTS). For more information about inheritance in C#, see Inheritance.
                Each type in the CTS is defined as either a value type or a reference type. These types include all custom types in the .NET class library and also your own user-defined types. Types that you define by using the struct keyword are value types; all the built-in numeric types are structs. Types that you define by using the class or record keyword are reference types. Reference types and value types have different compile-time rules, and different run-time behavior.";

            WordCounter counter = new WordCounter();
            string wordToCount = "type";

            // Get both singular and plural counts
            var counts = counter.CountWordAndPlural(text, wordToCount);

            // Display detailed results
            Console.WriteLine($"Word count statistics:");
            Console.WriteLine($"- The word '{wordToCount}' appears {counts.singular} times");
            Console.WriteLine($"- The word '{wordToCount}s' appears {counts.plural} times");
            Console.WriteLine($"- Total occurrences (including plural): {counts.singular + counts.plural} times");

            Console.ReadKey();
        }
    }
}