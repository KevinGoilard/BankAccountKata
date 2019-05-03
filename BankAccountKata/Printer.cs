using System.Linq;
using System.Text;

namespace BankAccountKata
{
    public class Printer
    {
        public string ComputeHistory(Account account)
        {
            StringBuilder builder = new StringBuilder();
            account.Historique.ForEach(operation => builder.AppendLine(operation.ToString()));
            return builder.ToString();
        }

        public string ComputeHistoryWithoutInvalids(Account account)
        {
            StringBuilder builder = new StringBuilder();
            account.Historique.ForEach(operation => { if (operation.IsValid()) { builder.AppendLine(operation.ToString()); } });
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
            int balance = account.Historique.Sum(operation => operation.ComputeBalance().Value);
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
