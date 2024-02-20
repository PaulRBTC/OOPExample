namespace ProgrammingFundamentals.AnimalsOOP.Models
{
    internal class Car : Vehicle
    {

        internal string Make { get; set; }
        internal string Model { get; set; }
        internal string RegistrationPlate { get; set; }
        internal Constants.CarColour Colour { get; set; }
        internal int RegistrationYear { get; set; }

        internal Car(
            string make,
            string model,
            string registrationPlate,
            Constants.CarColour colour,
            int registrationYear
        ) : base()
        {
            Make = make;
            Model = model;
            RegistrationPlate = registrationPlate;
            Colour = colour;
            RegistrationYear = registrationYear;
        }

        internal Car(
            string make,
            string model,
            string registrationPlate,
            string colour,
            int registrationYear
        ) : base()
        {
            Make = make;
            Model = model;
            RegistrationPlate = registrationPlate;
            RegistrationYear = registrationYear;

            if (Enum.TryParse<Constants.CarColour>(colour, true, out Constants.CarColour carColour))
            {
                Colour = carColour;
            }
            else
            {
                throw new Exceptions.InvalidEnumException<Constants.CarColour>(colour);
            }

        }

        internal override void DisplayInfo()
        {

            string carColor = Enum.GetName<Constants.CarColour>(Colour)!;

            Console.WriteLine($"This vehicle is a {carColor} {Make} {Model}, first registered in {RegistrationYear}, with the plate {RegistrationPlate}.");

        }

    }
}
