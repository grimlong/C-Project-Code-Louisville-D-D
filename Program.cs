using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace C__Project
{

  class program
 {

	 //Ask for name and class
	static void Main(string[] args)
	{
		Console.WriteLine("Enter your name.");
		string cName = Console.ReadLine();
		Console.WriteLine("Welcome, " + cName);
		Console.WriteLine("What is your class (Fighter, Wizard, Rogue, etc.)");
		string cClass = Console.ReadLine();
		Console.WriteLine(cName + " " + "the " + cClass);

	
	}

	//roll stats

	//level up
 }

}