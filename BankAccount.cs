using System;
using System.Collections.Generic;
using System.Text;

namespace OopDemo
{
	class BankAccount
	{
		private string owner = "David";
		private decimal balance;

		public void Deposit(decimal amount)
		{
			// TODO: check if authorized
			balance += amount;
		}
		public decimal GetBalance()
		{
			return balance;
		}
	}
}
