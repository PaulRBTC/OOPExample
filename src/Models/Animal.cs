namespace ProgrammingFundamentals.AnimalsOOP.Models
{
    internal class Animal
    {

        internal string Name { get; set; }

        internal Animal(
            string name
        )
        {
            Name = name;
        }

        internal Animal()
        {
            Name = "Animal";
        }

        public void Eat()
        {

            Console.WriteLine($"{Name} is eating.");

        }

    }
}
