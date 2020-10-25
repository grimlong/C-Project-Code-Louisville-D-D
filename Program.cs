using System;

namespace C__Project
{
    partial class program
 {
	 //Ask for name and class, Print Name, Class, Stats, Level, HP
	static void Main(string[] args)
	
	{
		Character newCharacter = new Character();

		Console.WriteLine("Enter your name.");
		string cName = Console.ReadLine();
		Console.WriteLine("Welcome, " + cName);
		Console.WriteLine("What is your class (Fighter, Wizard, Rogue, etc.)");
		string cClass = Console.ReadLine();
		  start:
		Console.WriteLine(cName + " " + "the " + cClass + " " + "Level" + " " + newCharacter.Level);
		Console.WriteLine("STR" + " " + newCharacter.Str + " " +
		                  "DEX" + " " + newCharacter.Dex + " " +
						  "CON" + " " + newCharacter.Con + " " +
						  "INT" + " " + newCharacter.Int + " " +
						  "WIS" + " " + newCharacter.Wis + " " +
						  "CHA" + " " + newCharacter.Cha);
		Console.WriteLine("Hit Points:" + newCharacter.Hp);
		Console.WriteLine("Type 'level' to level up");

	//level up
		string Lvl = Console.ReadLine();Lvl.ToString();
		  if(Lvl.ToUpper() == "LEVEL")
	//increment HP and Character level and print new values.
			{ 
				newCharacter.Hp += 10 + Helpers.Modifier(newCharacter.Con);
				newCharacter.Level ++;
				goto start;
			}

			if(Lvl.ToUpper() == "EXIT")
			{ 
				Console.WriteLine("Goodbye");
			}

		  else
		  {
			 Console.WriteLine("Entry not recognized.  Please 'level' or 'exit'.");
			 goto start;
		  }	 
		
	}


 }

}