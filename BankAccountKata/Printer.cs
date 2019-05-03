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
            string content = string.Format("{0,-10}|{1,-30}|{2,-10}|{3,-10}", "Operation", "Date", "Valeur", "Balance");
            return content;
        }

        public string ComputeTotal(Account account)
        {
            int balance = account.Historique.Sum(operation => operation.ComputeBalance().Value);
            string content = string.Format("{0,-10}|{1,-30}|{2,-10}|{3,-10}", "", "", account.Amount, balance);
            return content;
        }
    }
}
