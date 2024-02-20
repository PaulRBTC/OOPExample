namespace ProgrammingFundamentals.AnimalsOOP.Exceptions
{
    internal class NegativeBalanceException : Exception
    {

        public NegativeBalanceException() : base("Your balance has gone below zero!")
        { }

    }
}
