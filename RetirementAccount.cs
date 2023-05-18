using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__Virtual__Overriding__and_New
{
	internal class RetirementAccount : SavingsAccount
	{
		public RetirementAccount(string name, string accountNumber, double balance, double interest) : base(name, accountNumber, balance, interest)
		{
		}

		public override bool Withdraw(double amount)
		{
			Console.WriteLine("Cannot withdraw from a retirement account");
			return false;
		}
	}
}
