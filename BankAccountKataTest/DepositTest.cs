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
            Money amount = new Money(10);

            client.Deposit(account, amount);

            Money expected = amount;
            account.Amount.Should().Be(expected);
        }

        [TestMethod]
        public void ClientShouldNotBeAbleToDepositANegativeAmount()
        {
            Client client = new Client();
            Account account = new Account();
            Money amount = new Money(-5);

            client.Deposit(account, amount);

            Money expected = new Money(0);
            account.Amount.Should().Be(expected);
        }
    }
}
