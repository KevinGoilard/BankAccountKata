using System;
using BankAccountKata;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountKataTest
{
    [TestClass]
    public class OperationTest
    {
        readonly DateTime exampleDate = new DateTime(2019, 04, 25, 16, 23, 45);

        [TestMethod]
        public void ClientDepositReturnAnOperation()
        {
            Client client = new Client();
            Account account = new Account(new Money(15));
            Money amount = new Money(10);

            Operation value = client.Deposit(account, amount, exampleDate);

            Operation expected = new Operation("Deposit", exampleDate, amount);
            value.Should().Be(expected);
        }

        [TestMethod]
        public void ClientWithdrawReturnAnOperation()
        {
            Client client = new Client();
            Account account = new Account(new Money(15));
            Money amount = new Money(10);

            Operation value = client.Withdraw(account, amount, exampleDate);

            Operation expected = new Operation("Withdraw", exampleDate, amount);
            value.Should().Be(expected);
        }

        [TestMethod]
        public void ClientInvalidDepositReturnAnInvalidOperation()
        {
            Client client = new Client();
            Account account = new Account(new Money(15));
            Money amount = new Money(-10);

            Operation value = client.Deposit(account, amount, exampleDate);

            Operation expected = new Operation("Invalid", exampleDate, amount);
            value.Should().Be(expected);
        }

        [DataTestMethod]
        [DataRow(-10)]
        [DataRow(20)]
        public void ClientInvalidWithdrawReturnAnInvalidOperation(int value)
        {
            Client client = new Client();
            Account account = new Account(new Money(15));
            Money amount = new Money(value);

            Operation operationValue = client.Withdraw(account, amount, exampleDate);

            Operation expected = new Operation("Invalid", exampleDate, amount);
            operationValue.Should().Be(expected);
        }
    }
}
