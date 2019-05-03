using BankAccountKata.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class History
    {
        public readonly List<Operation> history = new List<Operation>();

        internal void Add(Operation result)
        {
            history.Add(result);
        }

        internal Money ComputeBalance()
        {
            int balance = history.Sum(operation => operation.ComputeBalance().Value);
            return new Money(balance);
        }

        internal List<string> GetOperationStrings()
        {
            List<string> operationStrings = new List<string>();
            history.ForEach(operation => operationStrings.Add(operation.ToString()));
            return operationStrings;
        }

        internal List<string> GetOnlyValidOperationStrings()
        {
            List<string> operationStrings = new List<string>();
            history.ForEach(operation => { if(operation.IsValid()) operationStrings.Add(operation.ToString()); });
            return operationStrings;
        }
    }
}
