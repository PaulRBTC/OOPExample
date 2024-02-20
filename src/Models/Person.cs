namespace ProgrammingFundamentals.AnimalsOOP.Models
{
    internal class Person
    {

        internal string Name { get; set; }

        internal int Age { get; set; }

        internal Person(
            string name,
            int age
        )
        {
            Name = name;
            Age = age;
        }

        internal void Introduce()
        {

            Console.WriteLine($"Hi, I'm {Name}! I'm {Age} years old.");

        }

    }
}
