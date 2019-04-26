namespace BankAccountKata
{
    public class Account
    {

        public Account()
        {
            Amount = new Money(0);
        }

        public Account(Money initialValue)
        {
            Amount = initialValue;
        }

        public Money Amount { get; set; }
    }
}
