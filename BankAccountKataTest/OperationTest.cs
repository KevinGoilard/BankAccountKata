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

            Operation expected = new Operation(Operation.DepositOperation, exampleDate, amount);
            value.Should().Be(expected);
        }

        [TestMethod]
        public void ClientWithdrawReturnAnOperation()
        {
            Client client = new Client();
            Account account = new Account(new Money(15));
            Money amount = new Money(10);

            Operation value = client.Withdraw(account, amount, exampleDate);

            Operation expected = new Operation(Operation.WithdrawOperation, exampleDate, amount);
            value.Should().Be(expected);
        }

        [TestMethod]
        public void ClientInvalidDepositReturnAnInvalidOperation()
        {
            Client client = new Client();
            Account account = new Account(new Money(15));
            Money amount = new Money(-10);

            Operation value = client.Deposit(account, amount, exampleDate);

            Operation expected = new Operation(Operation.InvalidOperation, exampleDate, amount);
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

            Operation expected = new Operation(Operation.InvalidOperation, exampleDate, amount);
            operationValue.Should().Be(expected);
        }

        [TestMethod]
        public void AccountSaveTheOperations()
        {
            Client client = new Client();
            Account account = new Account(new Money(15));
            Money amount = new Money(10);

            Operation depositValue = client.Deposit(account, amount, exampleDate);
            Operation withdrawValue = client.Withdraw(account, amount, exampleDate);

            account.Historique.Should().Contain(depositValue);
            account.Historique.Should().Contain(withdrawValue);
        }

        [TestMethod]
        public void OperationBalanceIsPositiveForValidDeposit()
        {
            Money amount = new Money(10);
            Operation operation = new Operation(Operation.DepositOperation, exampleDate, amount);

            Money value = operation.ComputeBalance();

            value.Should().Be(amount);
        }

        [TestMethod]
        public void OperationBalanceIsNegativeForValidWithdraw()
        {
            Money amount = new Money(10);
            Operation operation = new Operation(Operation.WithdrawOperation, exampleDate, amount);

            Money value = operation.ComputeBalance();

            value.Should().Be(-amount);
        }

        [TestMethod]
        public void OperationBalanceIsZeroForInvalidOperation()
        {
            Money amount = new Money(10);
            Operation operation = new Operation(Operation.InvalidOperation, exampleDate, amount);

            Money value = operation.ComputeBalance();

            Money expected = new Money(0);
            value.Should().Be(expected);
        }
    }
}
