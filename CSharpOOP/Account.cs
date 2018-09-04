using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
	class Account
	{
		// encapsulation 
		private decimal balance;
		private static int numberOfAccounts = 0;
		private readonly ILogger logger;

		public decimal Balance
		{
			get { return balance; }
		}

		public static decimal NumberOfAccounts
		{
			get { return numberOfAccounts; }
		}

		public Account(decimal balance, ILogger logger)
		{
			//			Console.WriteLine("Constructoer WITH params");
			this.logger = logger;
			this.balance = balance;
			numberOfAccounts++;

		}

		public static int GetAccountsCount()
		{
			return numberOfAccounts;
		}
		
		public Decimal Deposit(decimal amount)
		{
			// pollymorphism with an interface
			logger.Write("Depositing " + amount);
			//			Console.WriteLine("Making a deposit");
			balance += amount;
			return Balance;
		}
	}
}
