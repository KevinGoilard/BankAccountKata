using System;

namespace BankAccountKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Account account = new Account(new Money(15));
            Money five = new Money(5);
            Money ten = new Money(10);
            Money minusTen = new Money(-10);

            client.Withdraw(account, ten);
            client.Withdraw(account, minusTen);
            client.Deposit(account, five);
            client.Deposit(account, minusTen);

            Printer printer = new Printer();
            Console.WriteLine("Account history without invalids");
            Console.Write(printer.ComputeAccountPrintWithoutInvalids(account));
            Console.WriteLine();
            Console.WriteLine("Account history with invalids");
            Console.Write(printer.ComputeAccountPrint(account));
            Console.ReadKey();

        }
    }
}
