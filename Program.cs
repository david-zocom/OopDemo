using System;

namespace OopDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Car myCar;
			myCar = new Car();
			Console.WriteLine($"My car is a {myCar.model} and has {myCar.numberOfWheels} wheels.");

			Car oldCar = new Car();
			oldCar.model = "Renault Clio";
			Console.WriteLine($"My old car was a {oldCar.model} and had {oldCar.numberOfWheels} wheels.");

			BankAccount account = new BankAccount();
			account.Deposit(500);
			decimal balance = account.GetBalance();
			Console.WriteLine($"There is {balance} lire on the account.");
		}
	}
}
