using System;
using System.Linq;

namespace C__Project
{

public class Helpers{

// Hit points is equal to 10 plus a modifier that is the value of CON minus ten, divided by two.

public static int Modifier(int score)
	  {
		  return (int)Math.Floor((score - 10f) /2f);
	  }

//Rolls four six sided dice and keeps the sum of the largest three dice, Called once for each stat.

public static int Attrubite()
	{
	  return new[] { s_rnd.Next(1, 7), s_rnd.Next(1, 7), s_rnd.Next(1, 7), s_rnd.Next(1, 7) }.OrderBy(v => v).Skip(1).Sum();	
	}

static readonly Random s_rnd = new Random();

}

}