using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__Virtual__Overriding__and_New
{
	internal class CheckingAccount : BankAccount
	{
		double _overdraftFee;
		public CheckingAccount(string name, string accountNumber, double balance, double overdraftFee) : base(name, accountNumber, balance)
		{
			_overdraftFee = overdraftFee;
		}

		public double OverdraftFee { get => _overdraftFee; set => _overdraftFee = value; }

		public override bool Withdraw(double amount)
		{
			if (amount <= _balance)
			{
				_balance -= amount;
				return true;
			}
			_balance -= _overdraftFee;
			return false;
		}
		public override string ToString()
		{
			return base.ToString() + $" Overdraft fee is {_overdraftFee}";
		}
	}
}
