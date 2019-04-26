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
        public string ComputeAccountPrint(Account account)
        {
            return account.ToString();
        }
    }
}
