namespace BankAccountKata
{
    public class Client
    {
        public void Deposit(Account account, Money amount)
        {
            if (amount.ValueIsPositive())
            {
                account.Amount += amount;
            }
        }
    }
}
