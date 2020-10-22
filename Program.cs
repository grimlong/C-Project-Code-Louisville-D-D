using System;
using System.Linq;

// notes for refactoring: move classes into seperate files, remove non class properties and put them in
// helper class.

namespace C__Project
{

  class program
 {
  class Character {
	public int Str {get;}
    public int Dex {get;}
    public int Con {get;}
    public int Int {get;}
    public int Wis {get;}
    public int Cha {get;}
    public int Hp {get; set;}
	public int Level {get; set;}

    // Hit points is equal to 10 plus a modifier that is the value of CON minus ten, divided by two.
	public static int Modifier(int score)
	  {
		  return (int)Math.Floor((score - 10f) /2f);
	  }
    public static Character Gernerate()
	{
		return new Character();
	}
	//Rolls four six sided dice and keeps the sum of the largest three dice, Called once for each stat.
    public static int Attrubite()
	{
	  return new[] { s_rnd.Next(1, 7), s_rnd.Next(1, 7), s_rnd.Next(1, 7), s_rnd.Next(1, 7) }.OrderBy(v => v).Skip(1).Sum();	
	}
   public Character()
	{
		Str = Attrubite();
		Dex = Attrubite();
		Con = Attrubite();
		Int = Attrubite();
		Wis = Attrubite();
		Cha = Attrubite();
		Hp = 10 + Modifier(Con);
		Level = 1;
	}
	static readonly Random s_rnd = new Random();
  }
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
		    //increment HP and Character level
			{ 
				newCharacter.Hp += 10 + Character.Modifier(newCharacter.Con);
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