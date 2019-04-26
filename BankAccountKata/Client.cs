namespace BankAccountKata
{
    public class Client
    {
        public void Deposit(Account account, int amount)
        {
            if (amount > 0)
            {
                account.Amount += amount;
            }
        }
    }
}
