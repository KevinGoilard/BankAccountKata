using System.Text;
using System.Linq;

namespace BankAccountKata
{
    public class Printer
    {
        public string ComputeHistory(Account account)
        {
            StringBuilder builder = new StringBuilder();
            account.Historique.ForEach(operation =>builder.AppendLine(operation.ToString()));
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
            string content = string.Format("{0,-10}|{1,-30}|{2,-10}|{3,-10}\n", "Operation", "Date", "Valeur", "Balance");
            content += ComputeHistory(account);
            return content;
        }

        public string ComputeAccountPrintWithoutInvalids(Account account)
        {
            string content = string.Format("{0,-10}|{1,-30}|{2,-10}|{3,-10}\n", "Operation", "Date", "Valeur", "Balance");
            content += ComputeHistoryWithoutInvalids(account);
            return content;
        }
    }
}
