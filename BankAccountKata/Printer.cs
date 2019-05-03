using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountKata
{
    public class Printer
    {
        public string ComputeHistory(Account account)
        {
            StringBuilder builder = new StringBuilder();
            List<string> operationStrings = account.GetOperationStrings();
            operationStrings.ForEach(s => builder.AppendLine(s));
            return builder.ToString();
        }

        public string ComputeHistoryWithoutInvalids(Account account)
        {
            StringBuilder builder = new StringBuilder();
            List<string> operationStrings = account.GetOnlyValidOperationStrings();
            operationStrings.ForEach(s => builder.AppendLine(s));
            return builder.ToString();
        }

        public string ComputeAccountPrint(Account account)
        {
            string content = ComputeHistory(account);
            return content;
        }

        public string ComputeAccountPrintWithoutInvalids(Account account)
        {
            string content = ComputeHistoryWithoutInvalids(account);
            return content;
        }

        public string ComputeHeader()
        {
            string content = Format("Operation", "Date", "Valeur", "Balance");
            return content;
        }

        public string ComputeTotal(Account account)
        {
            Money balance = account.ComputeBalance();
            string content = Format("", "", account.Amount.ToString(), balance.ToString());
            return content;
        }

        public string Format(string operation, string date, string value, string balance)
        {
            return string.Format("{0,-10}|{1,-30}|{2,-10}|{3,-10}", operation, date, value, balance);
        }

        internal string FormatOperation(string operation, string date, string value, string balance)
        {
            return string.Format("{0,-10}|{1,-30}|{2,10}|{3,10}", operation, date, value, balance);
        }
    }
}
