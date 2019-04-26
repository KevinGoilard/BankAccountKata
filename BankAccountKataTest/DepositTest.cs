using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using BankAccountKata;

namespace BankAccountKataTest
{
    [TestClass]
    public class DepositTest
    {
        [TestMethod]
        public void ClientDepositPositiveAmount()
        {
            Client client = new Client();
            Account account = new Account();

            client.Deposit(account, 10);

            account.Amount.Should().Be(10);
        }
    }
}
