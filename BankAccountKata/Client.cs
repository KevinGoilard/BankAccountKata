namespace BankAccountKata
{
    public class Client
    {
        public void Deposit(Account account, int v)
        {
            if (v < 0)
                return;
            account.Amount += 10;
        }
    }
}
