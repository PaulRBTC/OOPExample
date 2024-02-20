namespace ProgrammingFundamentals.AnimalsOOP.Exceptions
{
    internal class InvalidEnumException<T> : Exception
        where T : Enum
    {

        public InvalidEnumException(string givenValue)
            : base($"Value '{givenValue}' for enum {typeof(T).Name} is not valid.")
        { }

    }
}
