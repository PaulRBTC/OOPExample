namespace ProgrammingFundamentals.AnimalsOOP.Models
{
    internal class Account
    {

        private decimal Balance { get; set; }

        internal void Deposit(
            decimal amount
        )
        {
            Balance += amount;
        }

        internal void Withdraw(
            decimal amount
        )
        {

            if ((Balance - amount) < 0)
            {
                throw new Exceptions.NegativeBalanceException();
            }

            Balance -= amount;

        }

    }
}
