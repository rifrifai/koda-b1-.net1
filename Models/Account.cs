using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
	public class Account(string accountNumber, string ownerName, double balance)
	{
		private readonly string AccountNumber = accountNumber;
		private readonly string OwnerName = ownerName;
		private readonly double Balance = balance;

        public override string ToString()
        {
            return $"Account Number: {AccountNumber} \nName: {OwnerName} \nBalance: {Balance}";
        }
	}
}