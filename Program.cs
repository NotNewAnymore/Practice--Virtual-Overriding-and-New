namespace Practice__Virtual__Overriding__and_New
{
	internal class Program
	{
		static void Main(string[] args)
		{
			RetirementAccount account1 = new RetirementAccount("Henry","1987868",5163.25,50);
			Console.WriteLine(account1);
			account1.Deposit(0);
			account1.Deposit(5);
			account1.Withdraw(1892347);
			account1.Withdraw(50);
			Console.WriteLine(account1);
		}
	}
}