using System;

namespace C__Project
{
   class program
 {
	 //Ask for name and class, Print Name, Class, Stats, Level, HP
	static void Main(string[] args)
	
	{
		Character newCharacter = new Character();
		RollDice rollDice = new RollDice();

		Console.WriteLine("Enter your name.");
		string cName = Console.ReadLine();
		Console.WriteLine("Welcome, " + cName);
		Console.WriteLine("What is your class (Fighter, Wizard, Rogue, etc.)");
		string cClass = Console.ReadLine();
		  start:
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine(cName + " " + "the " + cClass + " " + "Level" + " " + newCharacter.Level);
		Console.ResetColor();
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("STR" + " " + newCharacter.Str + " " +
		                  "DEX" + " " + newCharacter.Dex + " " +
						  "CON" + " " + newCharacter.Con + " " +
						  "INT" + " " + newCharacter.Int + " " +
						  "WIS" + " " + newCharacter.Wis + " " +
						  "CHA" + " " + newCharacter.Cha);
		Console.ResetColor();
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Hit Points:" + newCharacter.Hp);
		Console.ResetColor();
		Console.WriteLine("Please enter a command.  Enter 'List' for list of commands.");
        string uInput = Console.ReadLine();uInput.ToString();

		 switch(uInput.ToUpper()) {
                
                case "LIST":
                    Console.WriteLine("d4: rolls a 4 sided die");
                    Console.WriteLine("d6: rolls a 6 sided die");
                    Console.WriteLine("d8: rolls a 8 sided die");
                    Console.WriteLine("d10: rolls a 10 sided die");
                    Console.WriteLine("d20: rolls a 20 sided die");
					Console.WriteLine("Level: Levels the Character");
					Console.WriteLine("Exit: Exits Program");
					break;

				case "D4":
					Console.WriteLine("Rolling 4 sided die...");
					Console.WriteLine(rollDice.rollD4().ToString());
					break;

				case "D6":
					Console.WriteLine("Rolling 6 sided die...");
					Console.WriteLine(rollDice.rollD6().ToString());
					break;
					
				case "D8":
					Console.WriteLine("Rolling 8 sided die...");
					Console.WriteLine(rollDice.rollD8().ToString());
					break;	

				case "D10":
					Console.WriteLine("Rolling 10 sided die...");
					Console.WriteLine(rollDice.rollD10().ToString());
					break;

				case "D20":
					Console.WriteLine("Rolling 20 sided die...");
					Console.WriteLine(rollDice.rollD20().ToString());
					break;

				case "LEVEL":	
				newCharacter.Hp += 10 + Helper.Modifier(newCharacter.Con);
				newCharacter.Level ++;
				break;

				case "EXIT":
			    Console.WriteLine("Goodbye");
				System.Environment.Exit(1);
				break;
			
                   
				default:
			    Console.WriteLine("Entry not recognized. Please enter valid command.");
				break;
				
			}
			    goto start;
     
		
	}
 }
}