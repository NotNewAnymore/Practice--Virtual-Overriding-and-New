using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__Virtual__Overriding__and_New
{
	internal class SavingsAccount : BankAccount
	{
		double _interest;

		public SavingsAccount(string name, string accountNumber, double balance, double interest) : base(name, accountNumber, balance)
		{
			_interest = interest;

		}

		public double Interest { get => _interest; set => _interest = value; }

		public override bool Deposit(double amount)
		{
			if (amount > 0)
			{
				_balance += amount;
				_balance += _interest;
				return true;
			}
			return false;
		}

		public override string ToString()
		{
			return base.ToString() + $" interest is {_interest}";
		}
	}
}
