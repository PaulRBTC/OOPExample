namespace ProgrammingFundamentals.AnimalsOOP.Models
{
    internal class Bicycle : Vehicle
    {

        internal string Brand { get; set; }
        internal string Type { get; set; }
        internal Constants.BikeColour BikeColour { get; set; }

        internal Bicycle(
            string brand,
            string type,
            Constants.BikeColour colour
        ) : base()
        {

            Brand = brand;
            Type = type;
            BikeColour = colour;

        }

        internal Bicycle(
            string brand,
            string type,
            string colour
        ) : base()
        {

            Brand = brand;
            Type = type;

            if (Enum.TryParse<Constants.BikeColour>(colour, true, out Constants.BikeColour bikeColour))
            {

                BikeColour = bikeColour;

            }
            else
            {

                throw new Exceptions.InvalidEnumException<Constants.BikeColour>(colour);

            }

        }

        internal override void DisplayInfo()
        {

            string bikeColour = Enum.GetName<Constants.BikeColour>(BikeColour)!;

            Console.WriteLine($"This vehicle is a {bikeColour} {Brand} {Type}.");

        }

    }
}
