using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework.Linq
{
	public class Person
	{
		public Person(string firstName, string lastName, int age, char gender)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Gender = gender;
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public char Gender { get; set; }

	}
	class Program
    {
        static void Main(string[] args)
        {
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			Console.WriteLine("all people aged 50 or more:");
			List<Person> Over50 = people
										.Where(x => x.Age >= 50)
										.ToList();

			Over50.ForEach(x => Console.WriteLine($"{x.FirstName} is {x.Age}"));

			// Task 02
			Console.WriteLine("all people name starts with B:");
			List<Person> nameStartsWithB = people
													.Where(x => x.FirstName.StartsWith('B'))
													.ToList();
			nameStartsWithB.ForEach(x => Console.WriteLine($"{x.FirstName}"));

			// Task 03
			Console.WriteLine("first person whose surname starts with T:");
			Person surnameStartsWithT = people
													.Where(x => x.LastName.StartsWith('T'))
													.First();
			Console.WriteLine($"{surnameStartsWithT.FirstName} {surnameStartsWithT.LastName}");

			//// Task 04
			Console.WriteLine("find youngest and oldest person:");
			Person yongest = people									
									.Where(x => x.Age.Equals(people.Min(y => y.Age)))
									.First();
			Person oldest = people
									.Where(x => x.Age.Equals(people.Max(y => y.Age)))
									.First();
			Console.WriteLine($"Yongest is {yongest.FirstName} {yongest.LastName}. Oldest is {oldest.FirstName} {oldest.LastName}");
			
			// Task 05
			Console.WriteLine("find all male people aged 45 or more:");
			List<Person> maleOver45 = people
										.Where(x => x.Gender == 'M')
										.Where(x => x.Age >= 45)
										.ToList();
			maleOver45.ForEach(x => Console.WriteLine($"{x.FirstName} is {x.Age}"));

			// Task 06
			Console.WriteLine("find all females whose name starts with V:");
			List<Person> femaleStartsWithV = people
										.Where(x => x.Gender == 'F')
										.Where(x => x.FirstName.StartsWith('V'))
										.ToList();
			femaleStartsWithV.ForEach(x => Console.WriteLine($"{x.FirstName}"));

			// Task 07
			Console.WriteLine("find last female person older than 30 whose name starts with p:");
			Person femaleStartsWithPOver30 = people
										.Where(x => x.Gender == 'F')
										.Where(x => x.FirstName.StartsWith('P'))
										.Where(x=> x.Age >= 30)
										.LastOrDefault();
			Console.WriteLine(femaleStartsWithPOver30 == null ? "No results found!" : femaleStartsWithPOver30.FirstName);

			// Task 08
			Console.WriteLine("find first male younger than 40:");
			Person firstMaleYongerThan40 = people
										.Where(x => x.Gender == 'M')										
										.Where(x => x.Age <= 40)
										.First();
			Console.WriteLine($"{firstMaleYongerThan40.FirstName} {firstMaleYongerThan40.LastName} is {firstMaleYongerThan40.Age} years.");

			// Task 09
			Console.WriteLine("print the names of the male persons that have firstName longer than lastName:");
			List<string> maleFirstNameLonger = people
										.Where(x => x.Gender == 'M')
										.Where(x => x.FirstName.Length > x.LastName.Length)
										.Select(x => x.FirstName)
										.ToList();
			maleFirstNameLonger.ForEach(Console.WriteLine);

			// Task 10
			Console.WriteLine("print the lastNames of the female persons that have odd number of ages:");
			List<string> femaleOddNumberAge = people
										.Where(x => x.Gender == 'F')
										.Where(x => x.Age % 2 != 0)
										.Select(x => x.LastName)
										.ToList();
			femaleOddNumberAge.ForEach(Console.WriteLine);

			Console.ReadLine();
		}
    }
}
