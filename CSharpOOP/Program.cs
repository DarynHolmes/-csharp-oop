using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
	class Program
	{
		static void Main(string[] args)
		{
//			Console.WriteLine(Account.NumberOfAccounts);
//			var loudLogger = new LoudLogger();
//			var dbleLogger = new DoubleLogger(new ConsoleLogger(), new ConsoleLogger());
//			ILogger logger = new DoubleLogger(loudLogger, dbleLogger);
//			var accountA = new Account(0, logger);
			
////			Console.WriteLine(Account.NumberOfAccounts);
////			Account.GetAccountsCount();
//			var accountB = new Account(10, loudLogger);
////			Console.WriteLine(Account.NumberOfAccounts);
////			Console.WriteLine(accountA.NumberOfAccounts);
//			accountA.Deposit(50);
//			accountB.Deposit(200);
////			Console.WriteLine(accountA.Balance);
////			Console.WriteLine(accountB.Balance);

//			Console.ReadKey();

//			var logger = new ConsoleLogger();
//			Hello();

			// Abstract classes

			
			Animal poodle = new Dog();
			Animal goldFish = new Fish();
			Bird parrot = new Bird();
			
			List<Animal> animals = new List<Animal>();

			animals.Add(poodle);
			animals.Add(goldFish);
			animals.Add(parrot);
			animals.Add(new Fish());

			animals.ForEach(animal => DisplayAnimal(animal));
			
//			for (int i = 0; i < animals.Count; i++)
//			{
//				var animal = animals[i];
//				Console.WriteLine(animal.GetName() + " leg count: " + animal.GetNumberOfLegs());
//			}

//			Console.WriteLine("Dog leg count: " + poodle.GetNumberOfLegs());
//			Console.WriteLine("Fish leg count: " + goldFish.GetNumberOfLegs());
			Console.ReadKey();
		}

		public static void DisplayAnimal(Animal animal)
		{
			// polymorphism - the instance has different behaviours depending on thel instance
			Console.WriteLine($"{animal.GetName()} has {animal.GetNumberOfLegs()} legs");
		}
	}

	// This is an abstract class, not a concrete class like Dog
	// we may not instantiate it e.g. new Animal();
	public abstract class Animal
	{
		public virtual string GetName()
		{
			return "Animal";
		}

		public abstract int GetNumberOfLegs();
	}

	public abstract class Mamal : Animal
	{
		public override string GetName()
		{
			return base.GetName() + " : Mamal";
		}
	}

	// var a = new Animal();
	// a.GetNumberOfLegs();

	public class Dog : Mamal
	{
		// method overriding - a child class supplies its own implimentation of a method
		// method overloading - a class has 2 or more methods with a different signature
		// You can impliment multiple interfaces, but you can only inherit from 1 class
		public override int GetNumberOfLegs()
		{
//			Console.WriteLine(base.GetNumberOfLegs());
			return 4;
		}

		public override string GetName()
		{
			return base.GetName() + " : Dog";
		}

	}

	public class Bird : Animal
	{
		public override int GetNumberOfLegs()
		{
			return 2;
		}

		public override string GetName()
		{
			return "Bird";
		}
	}

	public class Fish : Animal
	{
		public override int GetNumberOfLegs()
		{
			return 0;
		}

		public override string GetName()
		{
			return "Fish (" + base.GetName() + ")";
		}
	}

}
