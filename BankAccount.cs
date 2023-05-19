using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__Virtual__Overriding__and_New
{
	internal abstract class BankAccount
	{
		protected string _name;
		protected string _accountNumber;
		protected double _balance;

		public BankAccount(string name, string accountNumber, double balance)
		{
			_name = name;
			_accountNumber = accountNumber;
			_balance = balance;
		}

		public string Name { get => _name; set => _name = value; }
		public string AccountNumber { get => _accountNumber; }
		public double Balance { get => _balance; }

		public abstract bool Deposit(double amount);


		public abstract bool Withdraw(double amount);

		public override string ToString()
		{
			return this.GetType().Name + $"{_name}, account number {_accountNumber}, balance {Balance}.";
		}
	}
}
