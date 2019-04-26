using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using BankAccountKata;

namespace BankAccountKataTest
{
    [TestClass]
    public class WithdrawTest
    {
        [TestMethod]
        public void ClientWithdrawPositiveAmountWithSufficientSavings()
        {
            Client client = new Client();
            Account account = new Account(new Money(15));
            Money amount = new Money(10);

            client.Withdraw(account, amount);

            Money expected = new Money(5);
            account.Amount.Should().Be(expected);
        }

        [TestMethod]
        public void ClientWithdrawPositiveAmountWithoutSufficientSavings()
        {
            Client client = new Client();
            Account account = new Account(new Money(5));
            Money amount = new Money(10);

            client.Withdraw(account, amount);

            Money expected = new Money(5);
            account.Amount.Should().Be(expected);
        }

        [TestMethod]
        public void ClientWithdrawAllHisSavings()
        {
            Client client = new Client();
            Account account = new Account(new Money(10));
            Money amount = new Money(10);

            client.Withdraw(account, amount);

            Money expected = new Money(0);
            account.Amount.Should().Be(expected);
        }

        [TestMethod]
        public void ClientCantWithdrawMoreThanHisSavings()
        {
            Client client = new Client();
            Account account = new Account(new Money(10));
            Money amount = new Money(15);

            client.Withdraw(account, amount);

            Money expected = new Money(10);
            account.Amount.Should().Be(expected);
        }
    }
}
