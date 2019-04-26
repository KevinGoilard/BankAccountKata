using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class Client
    {
        public void Deposit(Account account, int v)
        {
            account.Amount += 10;
        }
    }
}
